using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Library
{
    class Receipt
    {
        public Car Car { get; set; }
        public string ReceiptNumber { get; set; } //using uppercase in fields, sting to generate random numbers at the end
        public string SellerName { get; set; }
        public string SellerVatNumber { get; set; }
       // public string BuyerName { get; set; }
        public string ProductName { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; } //dateTime special type for dates
    }
}
