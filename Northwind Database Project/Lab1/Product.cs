/*
 * 
 * Written by Alex Wilber
 * Date: 1/29/2014
 * This class gets and sets the Product Variables.
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
    class Product : IList
    {
        //Create Class Members 
        public static int numProducts = 0;
        private int productID = -1;
        private string productName = "N/A";
        private int supplierID = -1;
        private int categoryID = -1;
        private string quantityPerUnit = "N/A";
        private double unitPrice = 9999999.99;
        private int unitsInStock = 0;
        private int unitsOnOrder = 0;
        private int reorderLevel = 0;
        private bool discontinued = true;
        public static string totalCount()
        {
            return "Products: " + numProducts + "\n";
        }
        //Constructors Start Here
        public Product()
        {
           //initialization goes here
           numProducts++;
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder, int aReorderLevel, bool isDiscontinued)
            : this()
        {
            this.productID = aProductID; //read-only field
            this.ProductName = aProductName;
            this.supplierID = aSupplierID; //read-only field
            this.categoryID = aCategoryID; //read-only field
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aNumInStock;
            this.UnitsOnOrder = aNumOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = isDiscontinued;
        }
         public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder, int aReorderLevel)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, aNumOnOrder, aReorderLevel, true) 
        { 
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock, int aNumOnOrder)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, aNumOnOrder, 0, true)
        {
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice, int aNumInStock)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aNumInStock, 0, 0, true)
        {
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit, double aUnitPrice)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, 0, 0, 0, true)
        {
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID, string aQuantityPerUnit)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, 9999999.99, 0, 0, 0, true)
        {
        }

        public Product(int aProductID, string aProductName, int aSupplierID, int aCategoryID)
            : this(aProductID, aProductName, aSupplierID, aCategoryID, "N/A", 9999999.99, 0, 0, 0, true)
        {
        }

        public Product(int aProductID, string aProductName, int aSupplierID)
            : this(aProductID, aProductName, aSupplierID, -1, "N/A", 9999999.99, 0, 0, 0, true)
        {
        }

        public Product(int aProductID, string aProductName)
            : this(aProductID, aProductName, -1, -1, "N/A", 9999999.99, 0, 0, 0, true)
        {
        }

        public Product(int aProductID)
            : this(aProductID, "N/A", -1, -1, "N/A", 9999999.99, 0, 0, 0, true)
        {
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
        //Get/Set Methods
        public string ProductName
        {
            get
            {
                return this.productName; 
            }
            set
            {
                this.productName = value;
            }
        }
        public string QuantityPerUnit
        {
            get
            {
                return this.quantityPerUnit;
            }
            set
            {
                this.quantityPerUnit = value;
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
        public int SupplierID
        {
            get
            {
                return this.supplierID;
            }
            set
            {
                this.supplierID = value;
            }
        }
        public int CategoryID
        {
            get
            {
                return this.categoryID;
            }
        }
        public int UnitsInStock
        {
            get
            {
                return this.unitsInStock;
            }
            set
            {
                this.unitsInStock = value;
            }
        }
        public int UnitsOnOrder
        {
            get
            {
                return this.unitsOnOrder;
            }
            set
            {
                this.unitsOnOrder = value;
            }
        }
        public int ReorderLevel
        {
            get
            {
                return this.reorderLevel;
            }
            set
            {
                this.reorderLevel = value;
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
        public bool Discontinued
        {
            get
            {
                return this.discontinued;
            }
            set
            {
                this.discontinued = value;
            }
        }
        public override string ToString()
        {
            // This method is for printing out the current state of the object
            string aString = "";
            aString = aString + "Product Name = " + ProductName + "\n";
            aString = aString + "Quantity Per Unit = " + QuantityPerUnit + "\n";
            aString = aString + "Product ID = " + ProductID + "\n";
            aString = aString + "Supplier ID = " + SupplierID + "\n";
            aString = aString + "Category Id = " + CategoryID + "\n";
            aString = aString + "Units In Stock = " + UnitsInStock + "\n";
            aString = aString + "Units On Order = " + UnitsOnOrder + "\n";
            aString = aString + "Re-Order Level = " + ReorderLevel + "\n";
            aString = aString + "UnitPrice = " + UnitPrice + "\n";
            aString = aString + "Discontinued = " + Discontinued + "\n";

            return aString;
        }
    }
}
