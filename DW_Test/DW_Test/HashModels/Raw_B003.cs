using System;

namespace DW_Test.HashModels
{
    public partial class Raw_B003
    {
        public long Id { get; set; }
        public string DocEntry { get; set; }
        public string BPLName { get; set; }
        public string LineNum { get; set; }
        public string ItemCode { get; set; }
        public string Ten_HH { get; set; }
        public string U_KM { get; set; }
        public string Donvitinh { get; set; }
        public decimal Soluong_gui { get; set; }
        public decimal? Luongxuat { get; set; }
        public decimal? Conton { get; set; }
        public decimal? DonGiaHoaDon { get; set; }
        public decimal? ThanhTien { get; set; }
        public decimal? Thuesuat { get; set; }
        public DateTime? NgayHoaDon { get; set; }
        public string KhoaHD { get; set; }
        public string SoHD { get; set; }
        public string Seri { get; set; }
        public string Kho { get; set; }
        public string U_Code { get; set; }
        public string U_Description_vn { get; set; }
        public string Ma_KH { get; set; }
        public string TenKH { get; set; }
        public string TenKHLe { get; set; }
        public string PhongBH { get; set; }
        public string Thukho { get; set; }
        public string XN { get; set; }
        public string Loai_NX { get; set; }
        public string BP { get; set; }

        public string Key;

        public string GetKey()
        {
            Key = ItemCode + "_" + U_Code;

            return Key.GetHashCode().ToString();
        }

        public string Value;

        public string GetValue()
        {
            Value = DocEntry + "_" +
                    BPLName + "_" +
                    LineNum + "_" +
                    Ten_HH + "_" +
                    U_KM + "_" +
                    Donvitinh + "_" +
                    Soluong_gui + "_" +
                    Luongxuat + "_" +
                    Conton + "_" +
                    DonGiaHoaDon + "_" +
                    ThanhTien + "_" +
                    Thuesuat + "_" +
                    KhoaHD + "_" +
                    SoHD + "_" +
                    Seri + "_" +
                    Kho + "_" +
                    U_Description_vn + "_" +
                    Ma_KH + "_" +
                    TenKH + "_" +
                    TenKHLe + "_" +
                    PhongBH + "_" +
                    Thukho + "_" +
                    XN + "_" +
                    Loai_NX + "_" +
                    BP;

            return Value.GetHashCode().ToString();
        }

        public Raw_B003(DWEModels.Raw_B003DAO remote)
        {
            Id = remote.Id;
            DocEntry = remote.DocEntry;
            BPLName = remote.BPLName;
            LineNum = remote.LineNum;
            ItemCode = remote.ItemCode;
            Ten_HH = remote.Ten_HH;
            U_KM = remote.U_KM;
            Donvitinh = remote.Donvitinh;
            Soluong_gui = remote.Soluong_gui;
            Luongxuat = remote.Luongxuat;
            Conton = remote.Conton;
            DonGiaHoaDon = remote.DonGiaHoaDon;
            ThanhTien = remote.ThanhTien;
            Thuesuat = remote.Thuesuat;
            NgayHoaDon = remote.NgayHoaDon;
            KhoaHD = remote.KhoaHD;
            SoHD = remote.SoHD;
            Seri = remote.Seri;
            Kho = remote.Kho;
            U_Code = remote.U_Code;
            U_Description_vn = remote.U_Description_vn;
            Ma_KH = remote.Ma_KH;
            TenKH = remote.TenKH;
            TenKHLe = remote.TenKHLe;
            PhongBH = remote.PhongBH;
            Thukho = remote.Thukho;
            XN = remote.XN;
            Loai_NX = remote.Loai_NX;
            BP = remote.BP;
            GetKey();
            GetValue();
        }

        public Raw_B003(Models.Raw_B003DAO remote)
        {
            Id = remote.Id;
            DocEntry = remote.DocEntry;
            BPLName = remote.BPLName;
            LineNum = remote.LineNum;
            ItemCode = remote.ItemCode;
            Ten_HH = remote.Ten_HH;
            U_KM = remote.U_KM;
            Donvitinh = remote.Donvitinh;
            Soluong_gui = remote.Soluong_gui;
            Luongxuat = remote.Luongxuat;
            Conton = remote.Conton;
            DonGiaHoaDon = remote.DonGiaHoaDon;
            ThanhTien = remote.ThanhTien;
            Thuesuat = remote.Thuesuat;
            NgayHoaDon = remote.NgayHoaDon;
            KhoaHD = remote.KhoaHD;
            SoHD = remote.SoHD;
            Seri = remote.Seri;
            Kho = remote.Kho;
            U_Code = remote.U_Code;
            U_Description_vn = remote.U_Description_vn;
            Ma_KH = remote.Ma_KH;
            TenKH = remote.TenKH;
            TenKHLe = remote.TenKHLe;
            PhongBH = remote.PhongBH;
            Thukho = remote.Thukho;
            XN = remote.XN;
            Loai_NX = remote.Loai_NX;
            BP = remote.BP;
            GetKey();
            GetValue();
        }
    }
}
