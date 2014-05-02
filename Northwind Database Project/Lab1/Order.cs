/*
 * 
 * Written by Alex Wilber
 * Date: 2/01/2014
 * This class gets and sets the Order Variables.
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
    class Order : IList
    {
        //Create Class Members
        public static int numOrders = -9;
        private int orderID = -9;
        private string customerID = "N/A";
        private int employeeID = -9;
        private int shipVia = -9;
        private double freight = -9;
        private string orderDate = "N/A";
        private string requiredDate = "N/A";
        private string shippedDate = "N/A";
        private string shipName = "N/A";
        private string shipAddress = "N/A";
        private string shipCity = "N/A";
        private string shipRegion = "N/A";
        private string shipPostalCode = "N/A";
        private string shipCountry = "N/A";
        public static string totalCount()
        {
            return "Orders: " + numOrders + "\n";
        }
        
        //Constructors Start Here
        public Order()
        {
            numOrders++;
        }
        public Order(int anOrderID, string aCustomerID,int anEmployeeID,int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName, string aShipAddress, string aShipCity,string aShipRegion,string aShipPostalCode,string aShipCountry)
            : this()
        {
            this.orderID = anOrderID;
            this.customerID = aCustomerID;
            this.employeeID = anEmployeeID;
            this.shipVia = aShipVia;
            this.freight = aFreight;
            this.orderDate = anOrderDate;
            this.requiredDate = aRequiredDate;
            this.shippedDate = aShippedDate;
            this.shipName = aShipName;
            this.shipAddress = aShipAddress;
            this.shipCity = aShipCity;
            this.shipRegion = aShipRegion;
            this.shipPostalCode = aShipPostalCode;
            this.shipCountry = aShipCountry;
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName, string aShipAddress, string aShipCity, string aShipRegion)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, aShipCity, aShipRegion, "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName, string aShipAddress, string aShipCity)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, aShipCity, "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName, string aShipAddress)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate, string aShipName)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate, string aShippedDate)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate, string aRequiredDate)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight, string anOrderDate)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia, double aFreight)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID, int aShipVia)
            : this(anOrderID, aCustomerID, anEmployeeID, aShipVia, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID, int anEmployeeID)
            : this(anOrderID, aCustomerID, anEmployeeID, 999999, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID, string aCustomerID)
            : this(anOrderID, aCustomerID, 9999999, 999999, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Order(int anOrderID)
            : this(anOrderID, "N/A", -9, 999999, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
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
        public string CustomerID
        {
            get
            {
                return this.customerID;
            }
            set
            {
                this.customerID = value;
            }
        }
        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }
            set
            {
                this.employeeID = value;
            }
        }
        public int ShipVia
        {
            get
            {
                return this.shipVia;
            }
            set
            {
                this.shipVia = value;
            }
        }
        public double Freight
        {
            get
            {
                return this.freight;
            }
            set
            {
                this.freight = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                this.orderDate = value;
            }
        }
        public string RequiredDate
        {
            get
            {
                return this.requiredDate;
            }
            set
            {
                this.requiredDate = value;
            }
        }
        public string ShippedDate
        {
            get
            {
                return this.shippedDate;
            }
            set
            {
                this.shippedDate = value;
            }
        }
        public string ShipName
        {
            get
            {
                return this.shipName;
            }
            set
            {
                this.shipName = value;
            }
        }
        public string ShipAddress
        {
            get
            {
                return this.shipAddress;
            }
            set
            {
                this.shipAddress = value;
            }
        }
        public string ShipCity
        {
            get
            {
                return this.shipCity;
            }
            set
            {
                this.shipCity = value;
            }
        }
        public string ShipRegion
        {
            get
            {
                return this.shipRegion;
            }
            set
            {
                this.shipRegion = value;
            }
        }
        public string ShipPostalCode
        {
            get
            {
                return this.shipPostalCode;
            }
            set
            {
                this.shipPostalCode = value;
            }
        }
        public string ShipCountry
        {
            get
            {
                return this.shipCountry;
            }
            set
            {
                this.shipCountry = value;
            }
        }
        public override string ToString()
        {
            // This method is for printing out the current state of the object
            string aString = "";
            aString = aString + "Order ID = " + OrderID + "\n";
            aString = aString + "Customer ID = " + CustomerID + "\n";
            aString = aString + "Employee ID = " + EmployeeID + "\n";
            aString = aString + "Ship Via = " + ShipVia + "\n";
            aString = aString + "Freight = " + Freight + "\n";
            aString = aString + "Order Date = " + OrderDate + "\n";
            aString = aString + "Required Date = " + RequiredDate + "\n";
            aString = aString + "Shipped Date = " + ShippedDate + "\n";
            aString = aString + "Ship Name = " + ShipName + "\n";
            aString = aString + "Ship Address = " + ShipAddress + "\n";
            aString = aString + "Ship City = " + ShipCity + "\n";
            aString = aString + "Ship Region = " + ShipRegion + "\n";
            aString = aString + "Ship Postal Code = " + ShipPostalCode + "\n";
            aString = aString + "Ship Country = " + ShipCountry + "\n";
            return aString;
        }
    }
}
