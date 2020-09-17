/* Receipt.cs
* This class includes data member that could be used by an automobile
* parts store. Items included as data members are customer name, address,
* phone, receipt number, item number purchased, description,
* unit price and quantity purchased.
*/

using System;
using System.Globalization;

namespace ReceiptApp
{
    class Receipt
    {

        // holy hell, let's use some auto properties here
        public string ReceiptNumber { get; set; }
        public string DateOfPurchase { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDesc { get; set; }
        public double UnitPrice { get; set; }
        public int QtyPurchased { get; set; }

        public Receipt()
        {
        }

        public Receipt(string rNum) => ReceiptNumber = rNum;

        public Receipt(string rNum, string cNum)
        {
            ReceiptNumber = rNum;
            CustomerNumber = cNum;
        }

        public Receipt(string rNum, string cNum, string cFName, string cLName, string cAddress, string cPhone)
        {
            ReceiptNumber = rNum;
            CustomerNumber = cNum;
            CustomerLastName = cLName;
            CustomerFirstName = cFName;
            CustomerAddress = cAddress;
            CustomerPhone = cPhone;
        }

        public Receipt(string rNum, string iNum, string iDesc, double uPrice, int qty)
        {
            ReceiptNumber = rNum;
            ItemNumber = iNum;
            ItemDesc = iDesc;
            UnitPrice = uPrice;
            QtyPurchased = qty;
        }

        public Receipt(string rNum, string cNum, string iNum, string iDesc, double uPrice, int qty)
        {
            ReceiptNumber = rNum;
            CustomerNumber = cNum;
            ItemNumber = iNum;
            ItemDesc = iDesc;
            UnitPrice = uPrice;
            QtyPurchased = qty;
        }

        public Receipt(string rNum, string purchaseDate, string cNum, string cFName, string cLName,
                       string cAddress, string cPhone, string iNum, string iDesc, double uPrice, int qty)
        {
            ReceiptNumber = rNum;
            DateOfPurchase = purchaseDate;
            CustomerNumber = cNum;
            CustomerFirstName = cFName;
            CustomerLastName = cLName;
            CustomerAddress = cAddress;
            CustomerPhone = cPhone;
            ItemNumber = iNum;
            ItemDesc = iDesc;
            UnitPrice = uPrice;
            QtyPurchased = qty;
        }



        public string ConvertUSDToEUR(double usd)
        {
            var euro = CultureInfo.GetCultureInfo("fr-FR");
            return string.Format(euro, "{0:C}", usd * 0.83);
        }

        public double CalculateTotalCost()
        {
            return UnitPrice * QtyPurchased;
        }

        public override string ToString()
        {
            return "Customer: " + CustomerFirstName + " " + CustomerLastName +
                   "\nPhone: " + CustomerPhone +
                   "\nTotal Purchases: " + CalculateTotalCost().ToString("C") +
                   " (" + ConvertUSDToEUR(CalculateTotalCost()) + ")";

        }
    }
}