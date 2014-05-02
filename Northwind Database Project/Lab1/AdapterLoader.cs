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
    public class AdapterLoader
    {
        private static OleDbConnection aConnection = new OleDbConnection();
        private DataSet aDataSet = new DataSet();
        private static OleDbCommand aCommand = aConnection.CreateCommand();
        private OleDbDataAdapter anAdapter = new OleDbDataAdapter(aCommand);
        public AdapterLoader()
        {
            aConnection.Open();
            string productSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products;";
            string orderSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders;";
            string orderDetailsSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details];";
            string supplierSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Supplier;";
            string shipperSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers;";
            string customerSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers;";
            string employeeSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo FROM Employees;";
            string categorySQL = "SELECT CategoryID, CategoryName, Description FROM Categories;";
            aCommand.CommandText = productSQL;
            anAdapter.Fill(aDataSet, "MyProducts");
            aCommand.CommandText = orderSQL;
            anAdapter.Fill(aDataSet, "MyOrders");
            aCommand.CommandText = orderDetailsSQL;
            anAdapter.Fill(aDataSet, "MyOrderDetails");
            aCommand.CommandText = supplierSQL;
            anAdapter.Fill(aDataSet, "MySuppliers");
            aCommand.CommandText = shipperSQL;
            anAdapter.Fill(aDataSet, "MyShippers");
            aCommand.CommandText = customerSQL;
            anAdapter.Fill(aDataSet, "MyCustomers");
            aCommand.CommandText = employeeSQL;
            anAdapter.Fill(aDataSet, "MyEmployees");
            aCommand.CommandText = categorySQL;
            anAdapter.Fill(aDataSet, "MyCategories");
            aConnection.Close();
        }
        public void GetProducts()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyProducts"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyProducts"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetOrders()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyOrders"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyOrders"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetOrderDetails()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyOrderDetails"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyOrderDetails"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetShippers()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyShippers"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyShippers"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetSuppliers()
        {
            foreach (DataRow aRow in aDataSet.Tables["MySuppliers"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MySuppliers"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetCustomers()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyCustomers"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyCustomers"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetEmployees()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyEmployees"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyEmployees"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
        public void GetCategories()
        {
            foreach (DataRow aRow in aDataSet.Tables["MyCategories"].Rows)
            {
                foreach (DataColumn aColumn in aDataSet.Tables["MyCategories"].Columns)
                {
                    Console.Write(aColumn.ColumnName.ToString() + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
