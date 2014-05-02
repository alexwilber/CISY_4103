/*
 * 
 * Written by Alex Wilber
 * Date: 1/29/2014
 * This class gets and sets the Order Detail Variables.
 * It Puts them into the To String method so it can be printed out int the controller through the console view.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OrderDetail : IList
    {
        //Create Class Members
        public static int numOrderDetail = 0;
        public int orderID = 9999999;
        public int productID = 9999999;
        public int quantity = 9999999;
        public double unitPrice = 9999999;
        public double discount = 9999999;
        public static string totalCount()
        {
            return "Order Detail: " + numOrderDetail + "\n";
        }
        
        //Constructors Start Here
        public OrderDetail()
        {
            numOrderDetail++;
        }
        public OrderDetail(int anOrderID, int aProductID, int aQuantity, double aUnitPrice, double aDiscount)
            : this()
        {
            this.orderID = anOrderID;
            this.productID = aProductID;
            this.quantity = aQuantity;
            this.unitPrice = aUnitPrice;
            this.discount = aDiscount;

        }
        public OrderDetail(int anOrderID, int aProductID, int aQuantity, double aUnitPrice)
            : this(anOrderID, aProductID, aQuantity, aUnitPrice,999999)
        {

        }
        public OrderDetail(int anOrderID, int aProductID, int aQuantity)
            : this(anOrderID, aProductID, aQuantity, 999999,999999)
        {

        }
        public OrderDetail(int anOrderID, int aProductID)
            : this(anOrderID, aProductID, 999999, 999999, 999999)
        {

        }
        public OrderDetail(int anOrderID)
            : this(anOrderID, 999999, 999999, 999999, 999999)
        {

        }

        //Get/Set Methods
        public int OrderID
        {
            get
            {
                return this.orderID;
            }
        }
        public int ProductID
        {
            get
            {
                return this.productID;
            }
            set
            {
                this.productID = value;
            }
        }
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
        public double UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = value;
            }
        }
        public double Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }
        public override string ToString()
        {
            // This method is for printing out the current state of the object
            string aString = "";
            aString = aString + "Order ID = " + OrderID + "\n";
            aString = aString + "Product ID = " + ProductID + "\n";
            aString = aString + "Quantity = " + Quantity + "\n";
            aString = aString + "Unit Price = " + UnitPrice + "\n";
            aString = aString + "Discount = " + Discount + "\n";
            return aString;
        }
    }
}
