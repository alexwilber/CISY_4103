/*
 * 
 * Written by Alex Wilber
 * Date: 2/14/2014
 * 
 * This class is the controller for the database. It contains methods that Get all of the lists of information from the UtilityXMLFileLoader
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class XMLController
    {
        //creates an XML file loader to be refrenced later.
        UtilityXMLFileLoader aLoader = UtilityXMLFileLoader.AnInstance;
        //Get methods to get the lists from the xmlfileloader class.
        public List<IList> GetCategories()
        {
            //creates a list of categories and sets it equal to the method getCategories from the file loader. 
            List<IList> categoryList = new List<IList>();
            categoryList = aLoader.GetCategories();

            return categoryList;
        }

        public List<IList> GetCustomers()
        {
            //creates a list of customers and sets it equal to the method getCustomers from the file loader. 
            List<IList> customerList = new List<IList>();
            customerList = aLoader.GetCustomers();

            return customerList;
        }

        public List<IList> GetEmployees()
        {
            //creates a list of employees and sets it equal to the method getEmployees from the file loader. 
            List<IList> employeeList = new List<IList>();
            employeeList = aLoader.GetEmployees();

            return employeeList;
        }

        public List<IList> GetOrders()
        {
            //creates a list of orders and sets it equal to the method getOrders from the file loader. 
            List<IList> ordersList = new List<IList>();
            ordersList = aLoader.GetOrders();

            return ordersList;
        }

        public List<IList> GetOrderDetails()
        {
            //creates a list of order details and sets it equal to the method getOrderDetails from the file loader. 
            List<IList> orderDetailsList = new List<IList>();
            orderDetailsList = aLoader.GetOrderDetails();

            return orderDetailsList;

        }
        //takes a paramater anID from the view and returns it through the xml file loader method get product by id
        public List<IList> GetProductByID(string anID)
        {
                return aLoader.GetProductByID(anID);
        }
        //takes a paramater aCategoryID from the view and returns it through the xml file loader method get category by id
        public List<IList> GetProductsByCategory(string aCategoryID)
        {
            return aLoader.GetProductsByCategory(aCategoryID);
        }

        public List<IList> GetProducts()
        {
            //creates a list of products and sets it equal to the method getProducts from the file loader. 
            List<IList> productsList = new List<IList>();
            productsList = aLoader.GetProducts();

            return productsList;
        }
        //Takes 2 parameters Min and Max and parses them through the method GetProductsM in the Xml file loader.
        public List<IList> GetMinMax(string min, string max)
        {
            List<IList> productsList = new List<IList>();
            productsList = aLoader.GetProductsM(min,max);

            return productsList;
        }
        public List<IList> GetShippers()
        {
            //creates a list of Shippers and sets it equal to the method getShippers from the file loader. 
            List<IList> shippersList = new List<IList>();
            shippersList = aLoader.GetShippers();

            return shippersList;
        }

        public List<IList> GetSuppliers()
        {
            //creates a list of suppliers and sets it equal to the method getSuppliers from the file loader. 
            List<IList> suppliersList = new List<IList>();
            suppliersList = aLoader.GetSuppliers();

            return suppliersList;
        }
        //Resets static variables in each respective table class. 
        public void ResetCounters()
        {
            Shipper.numShippers = 0;
            Supplier.numSuppliers = 0;
            Employee.numEmployees = 0;
            Product.numProducts = 0;
            OrderDetail.numOrderDetail = 0;
            Order.numOrders = 0;
            Customer.numCustomers = 0;
            Category.numCategories = 0;
        }
    }
}
