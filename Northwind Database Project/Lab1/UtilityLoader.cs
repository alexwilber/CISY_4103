/*
 * 
 * Written by Alex Wilber
 * Date: 4/11/2014
 * 
 * This class connects to a database through the OleDb package. It reads the informaion through a while loop and parses them through to the controller.
 * It handles the SQL statements and selects the appropriate information and adds them to a list, which is returned through the method and
 * ready to be called in the controller class.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Data.OleDb;

namespace Lab1
{
    public class UtilityLoader
    {
        OleDbConnection aConnection = new OleDbConnection();
        //singleton
        private static UtilityLoader anInstance = null;

        //Checks to see if there is only one instance running.
        public static UtilityLoader AnInstance
        {
            get
            {
                if (anInstance == null)
                {
                    anInstance = new UtilityLoader();
                }
                return anInstance;
            }
        }

        private UtilityLoader()
        {
            //Connects to a the northwind database
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Administrator\Downloads\Northwind.mdb";
        }

        public List<IList> GetCategories()
        {
            List<IList> categoryList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == System.Data.ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories;";
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the category List
                while (aReader.Read())
                {
                    int anID = aReader["CategoryID"] as int? ?? -1;
                    string aCategoryName = aReader["CategoryName"] as string ?? String.Empty;
                    string aDescription = aReader["Description"] as string ?? String.Empty;

                    Category aCategory = new Category(anID, aCategoryName, aDescription);
                    categoryList.Add(aCategory);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return categoryList;
        }



        public List<IList> GetEmployees()
        {
            List<IList> employeesList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();
            //SQL statement sent into the commandtext of the OleDbCommand.
            aCommand.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo FROM Employees";
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {

                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the employee List
                while (aReader.Read())
                {
                    string anEmployeeID = aReader["EmployeeID"] as string ?? String.Empty;
                    string aLastName = aReader["LastName"] as string ?? String.Empty;
                    string aFirstName = aReader["FirstName"] as string ?? String.Empty;
                    string aTitle = aReader["Title"] as string ?? String.Empty;
                    string aTitleOfCourtesy = aReader["TitleOfCourtesy"] as string ?? String.Empty;
                    string aBirthDate = aReader["BirthDate"] as string ?? String.Empty;
                    string aHireDate = aReader["HireDate"].ToString() as string ?? String.Empty;
                    string anAddress = aReader["Address"].ToString() as string ?? String.Empty;
                    string aCity = aReader["City"] as string ?? String.Empty;
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = aReader["Country"] as string ?? String.Empty;
                    string aHomePhone = aReader["HomePhone"] as string ?? String.Empty;
                    string anExtension = aReader["Extension"] as string ?? String.Empty;
                    string aNotes = aReader["Notes"] as string ?? String.Empty;
                    int isReportedTo = aReader["ReportsTo"] as int? ?? 0;

                    Employee anEmployee = new Employee(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, aNotes);
                    employeesList.Add(anEmployee);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return employeesList;
        }
        public List<IList> GetCustomers()
        {
            List<IList> customerList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers";
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information red into the customer list
                while (aReader.Read())
                {
                    string aCustomerID = aReader["CustomerID"] as string ?? String.Empty;
                    string aCompanyName = aReader["CompanyName"] as string ?? String.Empty;
                    string aContactName = aReader["ContactName"] as string ?? String.Empty;
                    string aContactTitle = aReader["ContactTitle"] as string ?? String.Empty;
                    string anAddress = aReader["Address"] as string ?? String.Empty;
                    string aCity = aReader["City"] as string ?? String.Empty;
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = aReader["Country"] as string ?? String.Empty;
                    string aPhone = aReader["Phone"] as string ?? String.Empty;
                    string aFax = aReader["Fax"] as string ?? String.Empty;

                    Customer aCustomer = new Customer(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);
                    customerList.Add(aCustomer);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return customerList;
        }
 
        public List<IList> GetOrders()
        {
            List<IList> ordersList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders";
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the order list
                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    string aCustomerID = aReader["CustomerID"] as string ?? String.Empty;
                    int anEmployeeID = aReader["EmployeeID"] as int? ?? -1;
                    string anOrderDate = aReader["OrderDate"] as string ?? String.Empty;
                    string aRequiredDate = aReader["RequiredDate"] as string ?? String.Empty;
                    string aShippedDate = aReader["ShippedDate"] as string ?? String.Empty;
                    int aShipVia = aReader["ShipVia"] as int? ?? -1;
                    double aFreight = (double)(decimal)aReader["Freight"];
                    string aShipName = aReader["ShipName"] as string ?? String.Empty;
                    string aShipAddress = aReader["ShipAddress"] as string ?? String.Empty;
                    string aShipCity = aReader["ShipCity"] as string ?? String.Empty;
                    string aShipRegion = aReader["ShipRegion"] as string ?? String.Empty;
                    string aShipPostalCode = aReader["ShipPostalCode"] as string ?? String.Empty;
                    string aShipCountry = aReader["ShipCountry"] as string ?? String.Empty;

                    Order anOrder = new Order(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                    ordersList.Add(anOrder);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return ordersList;
        }

        public List<IList> GetOrderDetails()
        {
            List<IList> orderDetailsList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the order details list
                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)((Nullable<Int16>)aReader["Quantity"] ?? 0);
                    double aDiscount = (double)((Nullable<Single>)aReader["Discount"] ?? 0);

                    OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aQuantity, aUnitPrice, aDiscount);
                    orderDetailsList.Add(anOrderDetail);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return orderDetailsList;
        }

        public List<IList> GetDetailsByOrder(string inputID)
        {
            List<IList> orderDetailsList = new List<IList>();

            OleDbCommand aCommand = aConnection.CreateCommand();
            //opens a connection to the northwind database
            aConnection.Open();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE OrderID = " + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the customer list
                while (aReader.Read())
                {
                    int anOrderID = aReader["OrderID"] as int? ?? -1;
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aQuantity = (int)((Nullable<Int16>)aReader["Quantity"] ?? 0);
                    double aDiscount = (double)((Nullable<Single>)aReader["Discount"] ?? 0);

                    OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aQuantity, aUnitPrice, aDiscount);
                    orderDetailsList.Add(anOrderDetail);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return orderDetailsList;
        }

        public List<IList> GetProducts()
        {
            List<IList> productsList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the products list
                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);

                    productsList.Add(aProduct);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return productsList;
        }

        public List<IList> GetProductByID(string anID)
        {
            List<IList> aList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE ProductID = " + anID;
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the products list
                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return aList;
        }

        public List<IList> GetProductsByCategory(string inputID)
        {
            List<IList> aList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE CategoryID = " + inputID;
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the categories list
                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return aList;
        }

        public List<IList> GetMinMax(string min, string max)
        {
            List<IList> aList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE UnitPrice BETWEEN " + min + " AND " + max; ;
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the products list
                while (aReader.Read())
                {
                    int aProductID = aReader["ProductID"] as int? ?? -1;
                    string aProductName = aReader["ProductName"] as string ?? String.Empty;
                    int aSupplierID = aReader["SupplierID"] as int? ?? -1;
                    int aCategoryID = aReader["CategoryID"] as int? ?? -1;
                    string aQuantityPerUnit = aReader["QuantityPerUnit"] as string ?? String.Empty;
                    double aUnitPrice = (double)(decimal)aReader["UnitPrice"];
                    int aUnitsInStock = (int)((Nullable<Int16>)aReader["UnitsInStock"] ?? 0);
                    int aUnitsOnOrder = (int)((Nullable<Int16>)aReader["UnitsOnOrder"] ?? 0);
                    int aReorderLevel = (int)((Nullable<Int16>)aReader["ReorderLevel"] ?? 0);
                    bool isDiscontinued = aReader["Discontinued"] as bool? ?? true;

                    Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, isDiscontinued);
                    aList.Add(aProduct);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return aList;
        }

        public List<IList> GetShippers()
        {
            List<IList> shippersList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers";
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the shippers list
                while (aReader.Read())
                {
                    int aShipperID = aReader["ShipperID"] as int? ?? -1;
                    string aCompanyName = aReader["CompanyName"] as string ?? String.Empty;
                    string aPhone = aReader["Phone"] as string ?? String.Empty;

                    Shipper aShipper = new Shipper(aShipperID, aCompanyName, aPhone);
                    shippersList.Add(aShipper);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return shippersList;
        }

        public List<IList> GetSuppliers()
        {
            List<IList> suppliersList = new List<IList>();
            //opens a connection to the northwind database
            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            if (aConnection.State == ConnectionState.Open)
            {
                aCommand.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
                OleDbDataReader aReader = aCommand.ExecuteReader();
                //Loop to read the Information and put the Information read into the suppliers list
                while (aReader.Read())
                {
                    int aSupplierID = (int)aReader["SupplierID"];
                    string aCompanyName = (string)aReader["CompanyName"];
                    string aContactName = (string)aReader["ContactName"];
                    string aContactTitle = (string)aReader["ContactTitle"];
                    string anAddress = (string)aReader["Address"];
                    string aCity = (string)aReader["City"];
                    string aRegion = aReader["Region"] as string ?? String.Empty;
                    string aPostalCode = aReader["PostalCode"] as string ?? String.Empty;
                    string aCountry = (string)aReader["Country"];
                    string aPhone = (string)aReader["Phone"];
                    string aFax = aReader["Fax"] as string ?? String.Empty;
                    string aHomePage = aReader["HomePage"] as string ?? String.Empty;

                    Supplier aSupplier = new Supplier(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                    suppliersList.Add(aSupplier);
                }
            }
            //closes the connection to the northwind database
            aConnection.Close();
            return suppliersList;
        }
    }
}