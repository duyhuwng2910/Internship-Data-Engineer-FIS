using DW_Test.HashModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;

namespace DW_Test.Services.RDService.Specialized_channel
{
    public interface ISpecializedChannelService : IServiceScoped
    {
        public Task<bool> Init(List<Raw_SpecializedChannelDAO> Remote);
    }
    public class SpecializedChannelService : ISpecializedChannelService
    {
        private DataContext DataContext;

        public SpecializedChannelService(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public async Task<bool> Init(List<Raw_SpecializedChannelDAO> Remote)
        {
            List<Raw_SpecializedChannelDAO> Local = await DataContext.Raw_SpecializedChannel.ToListAsync();

            List<Raw_SpecializedChannel> HashRemote = Remote.Select(x => new Raw_SpecializedChannel(x)).ToList();

            List<Raw_SpecializedChannel> HashLocal = Local.Select(x => new Raw_SpecializedChannel(x)).ToList();

            HashRemote = HashRemote.OrderBy(x => x.Key).ToList();

            HashLocal = HashLocal.OrderBy(x => x.Key).ToList();

            List<Raw_SpecializedChannelDAO> InsertList = new List<Raw_SpecializedChannelDAO>();

            List<Raw_SpecializedChannelDAO> UpdateList = new List<Raw_SpecializedChannelDAO>();

            List<Raw_SpecializedChannelDAO> DeleteList = new List<Raw_SpecializedChannelDAO>();

            int index = 0;

            if (Local.Count == 0)
            {
                foreach(var remote in Remote)
                {
                    Local.Add(new Raw_SpecializedChannelDAO()
                    {
                        TenMien = remote.TenMien,
                        TenKenh = remote.TenKenh,
                        SPC1 = remote.SPC1
                    });
                }

                await DataContext.BulkMergeAsync(Local);
            }
            else
            {
                for (int j = 0; j < HashRemote.Count && index < HashLocal.Count;)
                {
                    if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) < 0)
                    {
                        InsertList.Add(new Raw_SpecializedChannelDAO()
                        {
                            TenMien = HashRemote[j].TenMien,
                            TenKenh = HashRemote[j].TenKenh,
                            SPC1 = HashRemote[j].SPC1
                        });

                        j++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) == 0)
                    {
                        if (HashRemote[j].Value != HashLocal[index].Value)
                        {
                            UpdateList.Add(new Raw_SpecializedChannelDAO()
                            {
                                Id = HashLocal[index].Id,
                                TenMien = HashLocal[index].TenMien,
                                TenKenh = HashLocal[index].TenKenh,
                                SPC1 = HashRemote[j].SPC1
                            });
                        }
                        j++;

                        index++;
                    }
                    else if (CompareMethod.Compare(HashRemote[j].Key, HashLocal[index].Key) > 0)
                    {
                        DeleteList.Add(new Raw_SpecializedChannelDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            SPC1 = HashLocal[index].SPC1
                        });

                        index++;
                    }
                }

                if (index == HashLocal.Count && HashRemote.Last().Key != HashLocal.Last().Key)
                {
                    while (index < HashRemote.Count)
                    {
                        InsertList.Add(new Raw_SpecializedChannelDAO()
                        {
                            TenMien = HashRemote[index].TenMien,
                            TenKenh = HashRemote[index].TenKenh,
                            SPC1 = HashRemote[index].SPC1
                        });

                        index++;
                    }
                }
                else if (index < HashLocal.Count)
                {
                    while (index < HashLocal.Count)
                    {
                        DeleteList.Add(new Raw_SpecializedChannelDAO()
                        {
                            Id = HashLocal[index].Id,
                            TenMien = HashLocal[index].TenMien,
                            TenKenh = HashLocal[index].TenKenh,
                            SPC1 = HashLocal[index].SPC1
                        });

                        index++;
                    }
                }

                await DataContext.BulkDeleteAsync(DeleteList);
                await DataContext.BulkMergeAsync(InsertList);
                await DataContext.BulkMergeAsync(UpdateList);
            }

            return true;
        }
    }
}
