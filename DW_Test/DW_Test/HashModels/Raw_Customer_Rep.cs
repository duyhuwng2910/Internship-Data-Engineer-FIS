using DW_Test.Models;

namespace DW_Test.HashModels
{
    public partial class Raw_Customer_Rep
    {
        public long Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
        public string SaleBranch { get; set; }
        public string SaleChannel { get; set; }
        public string SaleRoom { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public string key;

        public string GetKey()
        {
            key = CustomerCode;

            return key.GetHashCode().ToString();
        }

        public string value;

        public string GetValue()
        {
            value = CustomerName + "_"
                    + CountryCode + "_"
                    + CountryName + "_"
                    + CountyCode + "_"
                    + CountyName + "_"
                    + SaleBranch + "_"
                    + SaleChannel + "_"
                    + SaleRoom;

            return value.GetHashCode().ToString();
        }


        public Raw_Customer_Rep(Raw_Customer_RepDAO Raw_Customer_RepDAO)
        {
            Id = Raw_Customer_RepDAO.Id;
            CustomerCode = Raw_Customer_RepDAO.CustomerCode;
            CustomerName = Raw_Customer_RepDAO.CustomerName;
            CountyCode = Raw_Customer_RepDAO.CountyCode;
            CountyName = Raw_Customer_RepDAO.CountyName;
            SaleBranch = Raw_Customer_RepDAO.SaleBranch;
            SaleChannel = Raw_Customer_RepDAO.SaleChannel;
            SaleRoom = Raw_Customer_RepDAO.SaleRoom;
            CountryCode = Raw_Customer_RepDAO.CountryCode;
            CountryName = Raw_Customer_RepDAO.CountryName;
            GetKey();
            GetValue();
        }

        public Raw_Customer_Rep(DWEModels.Raw_Customer_RepDAO Raw_Customer_RepDAO)
        {
            Id = Raw_Customer_RepDAO.Id;
            CustomerCode = Raw_Customer_RepDAO.CustomerCode;
            CustomerName = Raw_Customer_RepDAO.CustomerName;
            CountyCode = Raw_Customer_RepDAO.CountyCode;
            CountyName = Raw_Customer_RepDAO.CountyName;
            SaleBranch = Raw_Customer_RepDAO.SaleBranch;
            SaleChannel = Raw_Customer_RepDAO.SaleChannel;
            SaleRoom = Raw_Customer_RepDAO.SaleRoom;
            CountryCode = Raw_Customer_RepDAO.CountryCode;
            CountryName = Raw_Customer_RepDAO.CountryName;
            GetKey();
            GetValue();
        }
    }
}
