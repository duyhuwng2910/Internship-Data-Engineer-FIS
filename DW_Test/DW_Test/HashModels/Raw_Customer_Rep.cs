using DW_Test.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;

namespace DW_Test.HashModels
{
    public partial class Raw_Customer_Rep : Raw_Customer_RepDAO
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
            key = CustomerCode + "_" + CustomerName;

            return key.GetHashCode().ToString();
        }

        public void SetKey(string key)
        {
            this.key = key;
        }

        public string value;

        public string GetValue()
        {
            value = CountryCode + "_"
                    + CountryName + "_"
                    + CountyCode + "_"
                    + CountyName + "_"
                    + SaleBranch + "_"
                    + SaleChannel + "_"
                    + SaleRoom;

            return value.GetHashCode().ToString();
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        public Raw_Customer_Rep update(Raw_Customer_Rep Remote)
        {
            var New_Raw_Customer_Rep = new Raw_Customer_Rep
            {
                CustomerCode = Remote.CustomerCode,
                CustomerName = Remote.CustomerName,
                CountryCode = Remote.CountryCode,
                CountryName = Remote.CountryName,
                CountyCode = Remote.CountyCode,
                CountyName = Remote.CountyName,
                SaleBranch = Remote.SaleBranch,
                SaleChannel = Remote.SaleChannel,
                SaleRoom = Remote.SaleRoom,
                key = Remote.key,
                value = Remote.value,
            };
            return New_Raw_Customer_Rep;
        }
    }
}
