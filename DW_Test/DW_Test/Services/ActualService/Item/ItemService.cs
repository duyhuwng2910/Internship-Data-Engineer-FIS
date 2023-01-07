using DW_Test.DWEModels;
using DW_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueSight.Common;
using Dim_ItemDAO = DW_Test.Models.Dim_ItemDAO;
using Raw_Item_RepDAO = DW_Test.Models.Raw_Item_RepDAO;

namespace DW_Test.Services.ActualService.ItemService
{
    public interface IItemService : IServiceScoped
    {
        Task<bool> ItemInit();

        Task<bool> IncrementalItemInit();
        Task ItemTransform();
    }
    public class ItemService : IItemService
    {
        private DataContext DataContext;
        private DWEContext DWEContext;

        public ItemService(DataContext DataContext, DWEContext DWEContext)
        {
            this.DataContext = DataContext;
            this.DWEContext = DWEContext;
        }

        public async Task<bool> ItemInit()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepLocalDAOs = await DataContext.Raw_Item_Rep.ToListAsync();
            List<DWEModels.Raw_Item_RepDAO> Raw_Item_RepRemoteDAOs = await DWEContext.Raw_Item_Rep.ToListAsync();

            await DataContext.BulkDeleteAsync(Raw_Item_RepLocalDAOs);
            List<Raw_Item_RepDAO> Raw_Item_RepNewDAOs = Raw_Item_RepRemoteDAOs.Select(x => new Raw_Item_RepDAO()
            {
                ItemCode = x.ItemCode,
                ItemName = x.ItemName,
            }).ToList();

            await DataContext.BulkMergeAsync(Raw_Item_RepNewDAOs);

            return true;
        }

        /*
         * Hàm IncrementalItemInit
         * load dữ liệu trong bảng Raw_Item_Rep theo hướng gia tăng
         */
        public async Task<bool> IncrementalItemInit()
        {
            // List dữ liệu trong bảng Raw_Item_Rep của Local
            List<Raw_Item_RepDAO> Raw_Item_RepLocalDAOs = await DataContext.Raw_Item_Rep.ToListAsync();

            // List dữ liệu trong bảng Raw_Item_Rep của Local
            List<DWEModels.Raw_Item_RepDAO> Raw_Item_RepRemoteDAOs = await DWEContext.Raw_Item_Rep.ToListAsync();

            // Sắp xếp List của Local theo ItemCode
            Raw_Item_RepLocalDAOs = Raw_Item_RepLocalDAOs.OrderBy(x => x.ItemCode).ToList();

            // Sắp xếp List của Remote theo ItemCode
            Raw_Item_RepRemoteDAOs = Raw_Item_RepRemoteDAOs.OrderBy(x => x.ItemCode).ToList();

            // List dùng để insert các dòng dữ liệu mới
            List<Raw_Item_RepDAO> InsertList = new List<Raw_Item_RepDAO>();

            // List dùng để update các dòng dữ liệu cũ
            List<Raw_Item_RepDAO> UpdateList = new List<Raw_Item_RepDAO>();

            // List dùng để delete các dòng dữ liệu không còn tồn tại
            List<Raw_Item_RepDAO> DeleteList = new List<Raw_Item_RepDAO>();

            // Chỉ số dùng cho Local
            int index = 0;

            // Vòng lặp chạy incremental load
            for (int j = 0; j < Raw_Item_RepRemoteDAOs.Count && index < Raw_Item_RepLocalDAOs.Count;)
            {
                // Nếu Key của remote nhỏ hơn tức là trong Local chưa có, ta thêm 
                // dòng vào trong InsertList và cộng 1 vào j
                if (CompareMethod.Compare(Raw_Item_RepRemoteDAOs[j].ItemCode,
                                    Raw_Item_RepLocalDAOs[index].ItemCode) < 0)
                {
                    InsertList.Add(new Raw_Item_RepDAO()
                    {
                        ItemCode = Raw_Item_RepRemoteDAOs[j].ItemCode,
                        ItemName = Raw_Item_RepRemoteDAOs[j].ItemName,
                    });
                    
                    j++;
                }

                // Nếu hai Key đã bằng nhau thì kiểm tra Value
                // Nếu hai Value khác nhau thì thêm dòng vào UpdateList
                // còn bằng nhau thì continue
                // sau đó cộng 1 vào j và index
                else if (CompareMethod.Compare(Raw_Item_RepRemoteDAOs[j].ItemCode,
                                        Raw_Item_RepLocalDAOs[index].ItemCode) == 0)
                {
                    if (Raw_Item_RepRemoteDAOs[j].ItemName != Raw_Item_RepLocalDAOs[index].ItemName)
                    {
                        UpdateList.Add(new Raw_Item_RepDAO()
                        {
                            Id = Raw_Item_RepLocalDAOs[index].Id,
                            ItemCode = Raw_Item_RepRemoteDAOs[j].ItemCode,
                            ItemName = Raw_Item_RepRemoteDAOs[j].ItemName
                        });
                    }

                    j++;

                    index++;
                }

                // Nếu Key của remote lớn hơn tức là dòng này của Local trong Remote
                // không tồn tại, nên ta sẽ thêm dòng vào DeleteList
                // đồng thời cộng 1 vào index
                else if (CompareMethod.Compare(Raw_Item_RepRemoteDAOs[j].ItemCode,
                                        Raw_Item_RepLocalDAOs[index].ItemCode) > 0)
                {
                    DeleteList.Add(new Raw_Item_RepDAO()
                    {
                        Id = Raw_Item_RepLocalDAOs[index].Id,
                        ItemCode = Raw_Item_RepLocalDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepLocalDAOs[index].ItemName
                    });

                    index++;
                }
            }

            // Nếu local đã chạy hết, index vẫn nhỏ hơn count của HashRemote
            // đồng thời là hai key của dòng cuối cùng trong hai bảng là BẰNG NHAU
            // thì ta tiến hành insert toàn bộ các dòng còn lại ở remote vào HashLocal
            if (index == Raw_Item_RepLocalDAOs.Count
                && Raw_Item_RepLocalDAOs.Last().ItemCode != Raw_Item_RepRemoteDAOs.Last().ItemCode)
            {
                while (index < Raw_Item_RepRemoteDAOs.Count)
                {
                    InsertList.Add(new Raw_Item_RepDAO()
                    {
                        ItemCode = Raw_Item_RepRemoteDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepRemoteDAOs[index].ItemName,
                    });

                    index++;
                }
            }

            // Nếu index < count của local tức là local còn thừa dữ liệu cũ
            // KHÔNG còn tồn tại trong Remote
            // Ta sẽ delete toàn bộ các dòng còn lại ở HashLocal
            else if (index < Raw_Item_RepLocalDAOs.Count)
            {
                while (index < Raw_Item_RepLocalDAOs.Count)
                {
                    DeleteList.Add(new Raw_Item_RepDAO()
                    {
                        Id = Raw_Item_RepLocalDAOs[index].Id,
                        ItemCode = Raw_Item_RepLocalDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepLocalDAOs[index].ItemName
                    });

                    index++;
                }
            }

            // Đến đây ta sẽ tiến hành BulkDelete cho DeleteList
            // và BulkMerge cho InsertList và UpdateList
            // đối với DataContext
            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }

        public async Task ItemTransform()
        {
            await Build_Dim_Item();
        }

        /* 
         * Tạo bảng Dim_Item
         * Ở dây ta cũng sẽ sử dụng thuật toán IncrementalLoad cho hàm tạo bảng Dim_Item
         * Các bước thực hiện tương tự với hàm IncrementalItemInit
         */
        private async Task<bool> Build_Dim_Item()
        {
            List<Raw_Item_RepDAO> Raw_Item_RepDAOs = await DataContext.Raw_Item_Rep
                .Where(x => !string.IsNullOrEmpty(x.ItemCode)).ToListAsync();

            List<Dim_ItemDAO> Dim_ItemDAOs = await DataContext.Dim_Item.ToListAsync();

            Raw_Item_RepDAOs = Raw_Item_RepDAOs.OrderBy(x => x.ItemCode).ToList();

            Dim_ItemDAOs = Dim_ItemDAOs.OrderBy(x => x.ItemCode).ToList();

            List<Dim_ItemDAO> InsertList = new List<Dim_ItemDAO>();

            List<Dim_ItemDAO> UpdateList = new List<Dim_ItemDAO>();

            List<Dim_ItemDAO> DeleteList = new List<Dim_ItemDAO>();

            int index = 0;

            for (int j = 0; j < Raw_Item_RepDAOs.Count && index < Dim_ItemDAOs.Count;)
            {
                if (CompareMethod.Compare(Raw_Item_RepDAOs[j].ItemCode, Dim_ItemDAOs[index].ItemCode) < 0)
                {
                    InsertList.Add(new Dim_ItemDAO()
                    {
                        ItemCode = Raw_Item_RepDAOs[j].ItemCode,
                        ItemName = Raw_Item_RepDAOs[j].ItemName
                    });

                    j++;
                }
                else if (CompareMethod.Compare(Raw_Item_RepDAOs[j].ItemCode, Dim_ItemDAOs[index].ItemCode) == 0)
                {
                    if (Raw_Item_RepDAOs[j].ItemName != Dim_ItemDAOs[index].ItemName)
                    {
                        UpdateList.Add(new Dim_ItemDAO()
                        {
                            ItemId = Dim_ItemDAOs[index].ItemId,
                            ItemCode = Dim_ItemDAOs[index].ItemCode,
                            ItemName = Raw_Item_RepDAOs[j].ItemName
                        });
                    }

                    j++;

                    index++;
                }
                else if (CompareMethod.Compare(Raw_Item_RepDAOs[j].ItemCode, Dim_ItemDAOs[index].ItemCode) > 0)
                {
                    DeleteList.Add(new Dim_ItemDAO()
                    {
                        ItemId = Dim_ItemDAOs[index].ItemId,
                        ItemCode = Dim_ItemDAOs[index].ItemCode,
                        ItemName = Dim_ItemDAOs[index].ItemName
                    });

                    index++;
                }
            }

            if (index == Dim_ItemDAOs.Count && Raw_Item_RepDAOs.Last().ItemCode != Dim_ItemDAOs.Last().ItemCode)
            {
                while (index < Raw_Item_RepDAOs.Count)
                {
                    InsertList.Add(new Dim_ItemDAO()
                    {
                        ItemCode = Raw_Item_RepDAOs[index].ItemCode,
                        ItemName = Raw_Item_RepDAOs[index].ItemName
                    });

                    index++;
                }
            }
            else if (index < Dim_ItemDAOs.Count)
            {
                while (index < Dim_ItemDAOs.Count)
                {
                    DeleteList.Add(new Dim_ItemDAO()
                    {
                        ItemId = Dim_ItemDAOs[index].ItemId,
                        ItemCode = Dim_ItemDAOs[index].ItemCode,
                        ItemName = Dim_ItemDAOs[index].ItemName
                    });

                    index++;
                }
            }

            await DataContext.BulkDeleteAsync(DeleteList);
            await DataContext.BulkMergeAsync(InsertList);
            await DataContext.BulkMergeAsync(UpdateList);

            return true;
        }
    }
}
