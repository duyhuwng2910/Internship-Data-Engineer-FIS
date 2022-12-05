using DW_Test.DWEModels;
using DW_Test.Models;
using System;

namespace DW_Test.HashModels
{
    public class Raw_Product_Group
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Loai_MHang_KH { get; set; }
        public string Nhomchinh_KH { get; set; }
        public string NhomC1 { get; set; }
        public string NhomC2 { get; set; }
        public string NhomC3 { get; set; }
        public string Nhom_LEDSMRT1 { get; set; }
        public string Nhom_SMARTDONLE { get; set; }
        public DateTime? M_StartDate { get; set; }
        public DateTime? M_EndDate { get; set; }
        public DateTime? GTGT_StartDate { get; set; }
        public DateTime? GTGT_EndDate { get; set; }

        public string Key;

        public string getKey()
        {
            Key = ItemCode;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string getValue()
        {
            Value = ItemName + "_"
                    + Loai_MHang_KH + "_"
                    + Nhomchinh_KH + "_"
                    + NhomC1 + "_"
                    + NhomC2 + "_"
                    + NhomC3 + "_"
                    + Nhom_LEDSMRT1 + "_"
                    + Nhom_SMARTDONLE;

            return Value.GetHashCode().ToString();
        }

        public Raw_Product_Group(Raw_Product_GroupDAO remote)
        {
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            Loai_MHang_KH = remote.Loai_MHang_KH;
            Nhomchinh_KH = remote.Nhomchinh_KH;
            NhomC1 = remote.NhomC1;
            NhomC2 = remote.NhomC2;
            NhomC3 = remote.NhomC3;
            Nhom_LEDSMRT1 = remote.Nhom_LEDSMRT1;
            Nhom_SMARTDONLE = remote.Nhom_SMARTDONLE;
        }

        public Raw_Product_Group(Raw_ProductGroupDAO remote)
        {
            ItemCode = remote.ItemCode;
            ItemName = remote.ItemName;
            Loai_MHang_KH = remote.Loai_MHang_KH;
            Nhomchinh_KH = remote.NhomChinh_KH;
            NhomC1 = remote.NhomC1;
            NhomC2 = remote.NhomC2;
            NhomC3 = remote.NhomC3;
            Nhom_LEDSMRT1 = remote.Nhom_LEDSMRT1;
            Nhom_SMARTDONLE = remote.Nhom_SMRTDONLEHT;
        }
    }
}
