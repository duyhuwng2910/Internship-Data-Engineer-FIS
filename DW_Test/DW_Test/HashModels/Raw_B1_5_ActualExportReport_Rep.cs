using System;

namespace DW_Test.HashModels
{
    public class Raw_B1_5_ActualExportReport_Rep
    {
        public long Id { get; set; }
        public string Ma_HH { get; set; }
        public string Ten_HH { get; set; }
        public string Donvitinh { get; set; }
        public string XN { get; set; }
        public string Loai_NX { get; set; }
        public string SoHD { get; set; }
        public string Seri { get; set; }
        public string KhoaHD { get; set; }
        public DateTime? Ngay_xuat { get; set; }
        public DateTime? thoidiem { get; set; }
        public long? Soluong { get; set; }
        public long? DonGia { get; set; }
        public long? ThanhTien { get; set; }
        public string coso { get; set; }
        public string Ma_KH { get; set; }
        public string Khach_hang { get; set; }
        public string Huy { get; set; }
        public long? DocEntry { get; set; }
        public long? TT { get; set; }

        public string Key;
        public string getKey()
        {
            Key = Ma_HH + "_"
                 + SoHD + "_"
                 + Seri + "_"
                 + KhoaHD + "_";

            return Key;
        }

        public string Value;
        public string getValue()
        {
            Value = Ten_HH + "_"
                    + Donvitinh + "_"
                    + XN + "_"
                    + Loai_NX + "_"
                    + Soluong + "_"
                    + DonGia + "_"
                    + ThanhTien + "_"
                    + coso + "_"
                    + Ma_KH + "_"
                    + Khach_hang + "_"
                    + Huy + "_"
                    + DocEntry + "_"
                    + TT + "_";

            return Value;
        }

        public Raw_B1_5_ActualExportReport_Rep(Models.Raw_B1_5_ActualExportReport_RepDAO Local)
        {
            Id = Local.Id;
            Ma_HH = Local.Ma_HH;
            Ten_HH = Local.Ten_HH;
            Donvitinh = Local.Donvitinh;
            XN = Local.XN;
            Loai_NX = Local.Loai_NX;
            SoHD = Local.SoHD;
            Seri = Local.Seri;
            KhoaHD = Local.KhoaHD;
            Ngay_xuat = Local.Ngay_xuat;
            thoidiem = Local.thoidiem;
            Soluong = Local.Soluong;
            DonGia = Local.DonGia;
            ThanhTien = Local.ThanhTien;
            coso = Local.coso;
            Ma_KH = Local.Ma_HH;
            Khach_hang = Local.Khach_hang;
            Huy = Local.Huy;
            DocEntry = Local.DocEntry;
            TT = Local.TT;
            getKey();
            getValue();
        }

        public Raw_B1_5_ActualExportReport_Rep(DWEModels.Raw_B1_5_ActualExportReport_RepDAO Remote)
        {
            Id = Remote.Id;
            Ma_HH = Remote.Ma_HH;
            Ten_HH = Remote.Ten_HH;
            Donvitinh = Remote.Donvitinh;
            XN = Remote.XN;
            Loai_NX = Remote.Loai_NX;
            SoHD = Remote.SoHD;
            Seri = Remote.Seri;
            KhoaHD = Remote.KhoaHD;
            Ngay_xuat = Remote.Ngay_xuat;
            thoidiem = Remote.thoidiem;
            Soluong = Remote.Soluong;
            DonGia = Remote.DonGia;
            ThanhTien = Remote.ThanhTien;
            coso = Remote.coso;
            Ma_KH = Remote.Ma_HH;
            Khach_hang = Remote.Khach_hang;
            Huy = Remote.Huy;
            DocEntry = Remote.DocEntry;
            TT = Remote.TT;
            getKey();
            getValue();
        }
    }
}
