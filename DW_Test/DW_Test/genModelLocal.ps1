dotnet ef dbcontext scaffold  "data source=NGUYENDUYHUNG;initial catalog=DW_TEST;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -c DataContext  -o Models -f --no-build --use-database-names --json
$content = Get-Content -Path 'Models\DataContext.cs' -Encoding UTF8
$content | Set-Content -Path "Models\DataContext.cs"  -Encoding UTF8