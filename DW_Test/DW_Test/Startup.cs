using DW_Test.DWEModels;
using DW_Test.Models;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.ObjectPool;
using Microsoft.OpenApi.Models;
using OfficeOpenXml;
using System;
using System.Reflection;
using Thinktecture;
using TrueSight.Common;
using Z.EntityFramework.Extensions;
using License = TrueSight.Common.License;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace DW_Test
{
    public class MyDesignTimeService : DesignTimeService { }
    public class Startup
    {
        public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()

            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();

            Configuration = builder.Build();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            License.Activate("Z8P9tYJTeNvTjsdUebrwYrxthb0B77z4thBipP1rhcVF1+5RZGPzuJPjtlcR2C1C9KmZjlmeLeE7404p8GDx0w==");
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _ = DataEntity.ErrorResource;

            services.AddControllers();

            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage(Configuration.GetConnectionString("DataContext"), new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                }));

            // Add the processing server as IHostedService
            services.AddHangfireServer();

            services.AddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();
            services.AddDbContext<DWEContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DWEContext"), sqlOptions =>
                {
                    sqlOptions.AddTempTableSupport();
                });
                options.AddInterceptors(new HintCommandInterceptor());

            });
            EntityFrameworkManager.ContextFactory = context =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<DWEContext>();
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DWEContext"));
                DWEContext DW_DMSContext = new DWEContext(optionsBuilder.Options);
                return DW_DMSContext;
            };

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DataContext"), sqlOptions =>
                {
                    sqlOptions.AddTempTableSupport();
                });
                options.AddInterceptors(new HintCommandInterceptor());

            });
            EntityFrameworkManager.ContextFactory = context =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DataContext"));
                DataContext DataContext = new DataContext(optionsBuilder.Options);
                DataContext.Database.SetCommandTimeout(0);
                return DataContext;
            };
            Assembly[] assemblies = new[] {
                Assembly.GetAssembly(typeof(IServiceScoped)),
                Assembly.GetAssembly(typeof(Startup))
            };
            services.Scan(scan => scan
                .FromAssemblies(assemblies)
                .AddClasses(classes => classes.AssignableTo<IServiceScoped>())
                     .AsImplementedInterfaces()
                     .WithScopedLifetime());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IBackgroundJobClient backgroundJobs, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHangfireDashboard();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHangfireDashboard();
            });
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "rpc/dw/swagger/{documentname}/swagger.json";
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/rpc/dw/swagger/v1/swagger.json", "report API");
                c.RoutePrefix = "rpc/dw/swagger";
            });
            app.UseDeveloperExceptionPage();
        }
    }
}
