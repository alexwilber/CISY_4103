/*
 * 
 * Written by Alex Wilber
 * Date: 2/14/2014
 * 
 * This is a class that loads information from XML files, parses through them and adds the information to a list for each table. Each list is returned in a method which
 * is accessed in the controller. Each file is loaded from the directory that contains the XML files for each table. 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    public class UtilityXMLFileLoader
    {
        //Load XML from files
        private XDocument aCategoryFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Categories.xml");
        private XDocument aCustomerFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Customers.xml");
        private XDocument anEmployeeFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Employees.xml");
        private XDocument anOrderFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Orders.xml");
        private XDocument anOrderDetailFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\OrderDetails.xml");
        private XDocument aProductsFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Products.xml");
        private XDocument aShippersFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Shippers.xml");
        private XDocument aSuppliersFile = XDocument.Load(@"C:\Users\Administrator\Documents\xmlfiles\Suppliers.xml");
        private static UtilityXMLFileLoader anInstance = null;
        public static UtilityXMLFileLoader AnInstance
        {
            get
            {
                if (anInstance == null)
                {
                    //Call private constructor.
                    anInstance = new UtilityXMLFileLoader();
                }
                return anInstance;
            }
        }

        
        
        public List<IList> GetCategories() {

            int anID;
            string aCategoryName;
            string aDescription;
            List<IList> categoryList = new List<IList>();

            //Linq statement for selecting the row of categorys.
            IEnumerable<XElement> rows = from row in aCategoryFile.Descendants("Category")
                                         select row;

            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions.
                anID = (int?)aRow.Attribute("CategoryID") ?? 99999999;
                aCategoryName = (string)aRow.Attribute("CategoryName") ?? "N/A";
                aDescription = (string)aRow.Attribute("Description") ?? "N/A";
                //sends information to the constuctor and adds it to the list.
                Category aCategory = new Category(anID, aCategoryName, aDescription);
                categoryList.Add(aCategory);
            }
            return categoryList;
        }
        //
        public List<IList> GetCustomers()
        {
            string aCustomerID;
            string aCompanyName;
            string aContactName;
            string aContactTitle;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aPhone;
            string aFax;
            List<IList> customerList = new List<IList>();
            //Linq statement for selecting the row of customers.
            IEnumerable<XElement> rows = from row in aCustomerFile.Descendants("Customer")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aCustomerID = (string)aRow.Attribute("CustomerID") ?? "N/A";
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aContactName = (string)aRow.Attribute("ContactName") ?? "N/A";
                aContactTitle = (string)aRow.Attribute("ContactTitle") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";
                aFax = (string)aRow.Attribute("Fax") ?? "N/A";
                //sends information to the constuctor and adds it to the list.
                Customer aCustomer = new Customer(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);
                customerList.Add(aCustomer);
            }

            return customerList;
        }

        public List<IList> GetEmployees()
        {
            string anEmployeeID;
            string aLastName;
            string aFirstName;
            string aTitle;
            string aTitleOfCourtesy;
            string aBirthDate;
            string aHireDate;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aHomePhone;
            string anExtension;
            string aNotes;
            int isReportedTo;

            List<IList> employeesList = new List<IList>();
            //Linq statement for selecting the row of employees.
            IEnumerable<XElement> rows = from row in anEmployeeFile.Descendants("Employee")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                anEmployeeID = (string)aRow.Attribute("EmployeeID") ?? "N/A";
                aLastName = (string)aRow.Attribute("LastName") ?? "N/A";
                aFirstName = (string)aRow.Attribute("FirstName") ?? "N/A";
                aTitle = (string)aRow.Attribute("Title") ?? "N/A";
                aTitleOfCourtesy = (string)aRow.Attribute("TitleOfCourtesy") ?? "N/A";
                aBirthDate = (string)aRow.Attribute("BirthDate") ?? "N/A";
                aHireDate = (string)aRow.Attribute("HireDate") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aHomePhone = (string)aRow.Attribute("HomePhone") ?? "N/A";
                anExtension = (string)aRow.Attribute("Extension") ?? "N/A";
                aNotes = (string)aRow.Attribute("Notes") ?? "N/A";
                isReportedTo = (int?)aRow.Attribute("ReportsTo") ?? 99999999;
                //sends information to the constuctor and adds it to the list.
                Employee anEmployee = new Employee(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress,aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension,aNotes );
                employeesList.Add(anEmployee);
            }

            return employeesList;
        }

        public List<IList> GetOrders()
        {
            int anOrderID;
            string aCustomerID;
            int anEmployeeID;
            string anOrderDate;
            string aRequiredDate;
            string aShippedDate;
            int aShipVia;
            double aFreight;
            string aShipName;
            string aShipAddress;
            string aShipCity;
            string aShipRegion;
            string aShipPostalCode;
            string aShipCountry;

            List<IList> ordersList = new List<IList>();
            //Linq statement for selecting the row of Orders.
            IEnumerable<XElement> rows = from row in anOrderFile.Descendants("Order")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                anOrderID = (int?)aRow.Attribute("OrderID") ?? 99999999;
                aCustomerID = (string)aRow.Attribute("CustomerID") ?? "N/A";
                anEmployeeID = (int?)aRow.Attribute("EmployeeID") ?? 99999999;
                anOrderDate = (string)aRow.Attribute("OrderDate") ?? "N/A";
                aRequiredDate = (string)aRow.Attribute("RequiredDate") ?? "N/A";
                aShippedDate = (string)aRow.Attribute("ShippedDate") ?? "N/A";
                aShipVia = (int?)aRow.Attribute("ShipVia") ?? 99999999;
                aFreight = (double?)aRow.Attribute("Freight") ?? 999999.99;
                aShipName = (string)aRow.Attribute("ShipName") ?? "N/A";
                aShipAddress = (string)aRow.Attribute("ShipAddress") ?? "N/A";
                aShipCity = (string)aRow.Attribute("ShipCity") ?? "N/A";
                aShipRegion = (string)aRow.Attribute("ShipRegion") ?? "N/A";
                aShipPostalCode = (string)aRow.Attribute("ShipPostalCode") ?? "N/A";
                aShipCountry = (string)aRow.Attribute("ShipCountry") ?? "N/A";
                //sends information to the constuctor and adds it to the list.
                Order anOrder = new Order(anOrderID, aCustomerID, anEmployeeID, aShipVia, aFreight, anOrderDate, aRequiredDate, aShippedDate, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);
                ordersList.Add(anOrder);
            }

            return ordersList;
        }

        public List<IList> GetOrderDetails()
        {
            int anOrderID;
            int aProductID;
            double aUnitPrice;
            int aQuantity;
            double aDiscount;

            List<IList> orderDetailsList = new List<IList>();
            //Linq statement for selecting the row of Order Details
            IEnumerable<XElement> rows = from row in anOrderDetailFile.Descendants("OrderDetail")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                anOrderID = (int?)aRow.Attribute("OrderID") ?? 99999999;
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aQuantity = (int?)aRow.Attribute("Quantity") ?? 0;
                aDiscount = (double?)aRow.Attribute("Discount") ?? 0.00;
                //sends information to the constuctor and adds it to the list.
                OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aQuantity, aUnitPrice, aDiscount);
                orderDetailsList.Add(anOrderDetail);
            }

            return orderDetailsList;
        }

        public List<IList> GetProducts()
        {
            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            List<IList> productsList = new List<IList>();
            //Linq statement for selecting the row of Products
            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? 99999999;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? 99999999;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;
                //sends information to the constuctor and adds it to the list.
                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                productsList.Add(aProduct);
            }

            return productsList;
        }
        public List<IList> GetProductsM(string min, string max)
        {
            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;

            List<IList> productsList = new List<IList>();
            //Linq statement for selecting the row of products and the where statement is for selecting the min and the max
            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where Convert.ToDouble(row.Attribute("UnitPrice").Value) >= Convert.ToDouble(min) &&
                                         Convert.ToDouble(row.Attribute("UnitPrice").Value) <= Convert.ToDouble(max)
                                         orderby Convert.ToDouble(row.Attribute("UnitPrice").Value)
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? 99999999;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? 99999999;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;
                //sends information to the constuctor and adds it to the list.
                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                productsList.Add(aProduct);
            }

            return productsList;
        }
        public List<IList> GetShippers()
        {
            int aShipperID;
            string aCompanyName;
            string aPhone;

            List<IList> shippersList = new List<IList>();
            //Linq statement for selecting the row of shippers.
            IEnumerable<XElement> rows = from row in aShippersFile.Descendants("Shipper")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aShipperID = (int?)aRow.Attribute("ShipperID") ?? 99999999;
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";
                //sends information to the constuctor and adds it to the list.
                Shipper aShipper = new Shipper(aShipperID, aCompanyName, aPhone);
                shippersList.Add(aShipper);
            }

            return shippersList;
        }

        public List<IList> GetSuppliers()
        {
            int aSupplierID;
            string aCompanyName;
            string aContactName;
            string aContactTitle;
            string anAddress;
            string aCity;
            string aRegion;
            string aPostalCode;
            string aCountry;
            string aPhone;
            string aFax;
            string aHomePage;

            List<IList> suppliersList = new List<IList>();
            //Linq statement for selecting the row of suppliers.
            IEnumerable<XElement> rows = from row in aSuppliersFile.Descendants("Supplier")
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? 99999999;
                aCompanyName = (string)aRow.Attribute("CompanyName") ?? "N/A";
                aContactName = (string)aRow.Attribute("ContactName") ?? "N/A";
                aContactTitle = (string)aRow.Attribute("ContactTitle") ?? "N/A";
                anAddress = (string)aRow.Attribute("Address") ?? "N/A";
                aCity = (string)aRow.Attribute("City") ?? "N/A";
                aRegion = (string)aRow.Attribute("Region") ?? "N/A";
                aPostalCode = (string)aRow.Attribute("PostalCode") ?? "N/A";
                aCountry = (string)aRow.Attribute("Country") ?? "N/A";
                aPhone = (string)aRow.Attribute("Phone") ?? "N/A";
                aFax = (string)aRow.Attribute("Fax") ?? "N/A";
                aHomePage = (string)aRow.Attribute("HomePage") ?? "N/A";
                //sends information to the constuctor and adds it to the list.
                Supplier aSupplier = new Supplier(aSupplierID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);
                suppliersList.Add(aSupplier);
            }

            return suppliersList;
        }

        public List<IList> GetProductByID(string anID) {
            List<IList> aList = new List<IList>();

            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;
            //Linq statement for selecting the row of Prodcucts and a where statement to select the product id of that product.
            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                            where row.Attribute("ProductID").Value.Equals(anID)
                                            select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? 99999999;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? 99999999;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;
                //sends information to the constuctor and adds it to the list.
                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }

            return aList;
        }

        public List<IList> GetProductsByCategory(string inputID)
        {
            List<IList> aList = new List<IList>();

            int aProductID;
            string aProductName;
            int aSupplierID;
            int aCategoryID;
            string aQuantityPerUnit;
            double aUnitPrice;
            int aUnitsInStock;
            int aUnitsOnOrder;
            int aReorderLevel;
            bool aDiscontinued;
            //Linq statement for selecting the row of categorys and selecting the categoryid of that category.
            IEnumerable<XElement> rows = from row in aProductsFile.Descendants("Product")
                                         where row.Attribute("CategoryID").Value.Equals(inputID)
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aProductName = (string)aRow.Attribute("ProductName") ?? "N/A";
                aSupplierID = (int?)aRow.Attribute("SupplierID") ?? 99999999;
                aCategoryID = (int?)aRow.Attribute("CategoryID") ?? 99999999;
                aQuantityPerUnit = (string)aRow.Attribute("QuantityPerUnit") ?? "N/A";
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aUnitsInStock = (int?)aRow.Attribute("UnitsInStock") ?? 0;
                aUnitsOnOrder = (int?)aRow.Attribute("UnitsOnOrder") ?? 0;
                aReorderLevel = (int?)aRow.Attribute("ReorderLevel") ?? 0;
                aDiscontinued = (bool?)aRow.Attribute("Discontinued") ?? true;
                //sends information to the constuctor and adds it to the list.
                Product aProduct = new Product(aProductID, aProductName, aSupplierID, aCategoryID, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, aDiscontinued);
                aList.Add(aProduct);
            }

            return aList;
        }

        public List<IList> GetDetailsByOrder(string inputID)
        {
            int anOrderID;
            int aProductID;
            double aUnitPrice;
            int aQuantity;
            double aDiscount;

            List<IList> orderDetailsList = new List<IList>();
            //Linq statement for selecting the row of orders by their orderid.
            IEnumerable<XElement> rows = from row in anOrderDetailFile.Descendants("OrderDetail")
                                         where row.Attribute("OrderID").Value.Equals(inputID)
                                         select row;
            //For each of the rows pass it to the constructor and append to the list.
            foreach (var aRow in rows)
            {
                //stores values and if it can't handles null exceptions
                anOrderID = (int?)aRow.Attribute("OrderID") ?? 99999999;
                aProductID = (int?)aRow.Attribute("ProductID") ?? 99999999;
                aUnitPrice = (double?)aRow.Attribute("UnitPrice") ?? 999999.99;
                aQuantity = (int?)aRow.Attribute("Quantity") ?? 0;
                aDiscount = (double?)aRow.Attribute("Discount") ?? 0.00;
                //sends information to the constuctor and adds it to the list.
                OrderDetail anOrderDetail = new OrderDetail(anOrderID, aProductID, aQuantity, aUnitPrice, aDiscount);
                orderDetailsList.Add(anOrderDetail);
            }

            return orderDetailsList;
        }


    }
}
