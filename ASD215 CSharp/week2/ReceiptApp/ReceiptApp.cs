/* ReceiptApp.cs
* This class tests the Receipt class
* by constructing objects, testing properties
* and methods.
*/

using System;
using static System.Console;
using System.Globalization;

namespace ReceiptApp
{
    class ReceiptApp
    {
        static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            Receipt firstReceiptObject = new Receipt
            {
                ReceiptNumber = AskForStringInput("Receipt Number"),
                CustomerNumber = AskForStringInput("Customer Number"),
                CustomerFirstName = AskForStringInput("Customer First Name"),
                CustomerLastName = AskForStringInput("Customer Last Name"),
                CustomerPhone = AskForStringInput("Customer Phone"),
                CustomerAddress = AskForStringInput("Customer Address"),
                ItemNumber = AskForStringInput("Item Number Purchased"),
                ItemDesc = AskForStringInput("Description of the Part"),
                UnitPrice = AskForUnitPrice(),
                QtyPurchased = AskForQtyPurchased()
            };

            Clear();
            WriteLine("\tFirst Test");
            WriteLine(firstReceiptObject.ToString());

            Receipt secondReceiptObject = new Receipt("XYC-2345")
            {
                DateOfPurchase = "09/25/2013",
                CustomerFirstName = "David",
                CustomerLastName = "Zeller",
                CustomerNumber = "001237",
                CustomerAddress = "14 Parks Blvd",
                CustomerPhone = "762-123-4412",
                ItemNumber = "4XZ23-7",
                ItemDesc = "Wiper blade",
                UnitPrice = 9.50,
                QtyPurchased = 2
            };

            WriteLine("\n\n\tSecond Test");
            WriteLine("Receipt Number: " + secondReceiptObject.ReceiptNumber + " - Date: " + secondReceiptObject.DateOfPurchase);
            WriteLine("Description of Part: " + secondReceiptObject.ItemDesc);
            WriteLine("Item Number: " + secondReceiptObject.ItemNumber + "\nQuantity Purchased: " + secondReceiptObject.QtyPurchased +
                      "\nTotal Cost: {0} ({1})", secondReceiptObject.CalculateTotalCost().ToString("c"), secondReceiptObject.ConvertUSDToEUR(secondReceiptObject.CalculateTotalCost()));

            Receipt thirdReceiptObject = new Receipt("TY-5432", "0004567")
            {
                CustomerFirstName = "Anna",
                CustomerLastName = "Leigh",
                UnitPrice = 7.22,
                QtyPurchased = 3
            };

            WriteLine("\n\n\tThird Test");
            WriteLine(thirdReceiptObject);

            Receipt lastReceiptObject = new Receipt(
                "XYC-2349",
                "11/05/2013",
                "001238",
                "Elizabeth",
                "Smith",
                "1247 Fenelon Falls Rd",
                "343-12-9876",
                "XQ-1267",
                "Brake Fluid",
                14.78,
                5);

            WriteLine("\n\n\tLast Test");
            WriteLine("Item Description: " + lastReceiptObject.ItemDesc +
            "\nItem Number: " + lastReceiptObject.ItemNumber +
            "\nQty Purchased: " + lastReceiptObject.QtyPurchased +
            "\nUnit Price: " + lastReceiptObject.UnitPrice.ToString("f2") +
            "\nTotal Cost: " + lastReceiptObject.CalculateTotalCost().ToString("C") +
            " (" + lastReceiptObject.ConvertUSDToEUR(lastReceiptObject.CalculateTotalCost()) + ")");

            ReadKey();
        }

        static double AskForUnitPrice()
        {
            string inValue;
            double theUnitPrice;
            Write("Enter Unit Price: ");
            inValue = ReadLine();
            theUnitPrice = double.Parse(inValue);
            return theUnitPrice;
        }

        static string AskForStringInput(string whatData)
        {
            string inValue;
            Write("Please enter {0}: ", whatData);
            inValue = ReadLine();
            return inValue;
        }

        static int AskForQtyPurchased()
        {
            string inValue;
            Write("Enter Quantity Purchased: ");
            inValue = ReadLine();
            return int.Parse(inValue);
        }
    }
}