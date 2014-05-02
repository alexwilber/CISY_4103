/*
 * 
 * Written by Alex Wilber
 * Date: 4/11/2014
 * 
 * This class is the controller for the database. It contains methods that Get all of the lists of information from the UtilityLoader
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //Creates an interface that extends all of the classes that contain methods to get/set information. ex: Shippers, Category ect..
    public interface IList
    {
    }
    public class DatabaseController
    {
        //creates a database loader to be refrenced later.
        UtilityLoader aOleDBLoader = UtilityLoader.AnInstance;

        //Start for get methods for the tables from the UtilityLoader which loads from the database.
        public List<IList> GetCategories()
        {
            return aOleDBLoader.GetCategories();
        }

        public List<IList> GetCustomers()
        {
            return aOleDBLoader.GetCustomers();
        }

        public List<IList> GetEmployees()
        {
            return aOleDBLoader.GetEmployees();
        }

        public List<IList> GetOrders()
        {
            return aOleDBLoader.GetOrders();
        }

        public List<IList> GetOrderDetails()
        {
            return aOleDBLoader.GetOrderDetails();
        }

        public List<IList> GetDetailsByOrder(string inputID)
        {
            return aOleDBLoader.GetDetailsByOrder(inputID);
        }

        public List<IList> GetProducts()
        {
            return aOleDBLoader.GetProducts();
        }

        public List<IList> GetProductByID(string anID)
        {
            return aOleDBLoader.GetProductByID(anID);
        }

        public List<IList> GetProductsByCategory(string anID)
        {
            return aOleDBLoader.GetProductsByCategory(anID);
        }

        public List<IList> GetMinMax(string min, string max)
        {
            return aOleDBLoader.GetMinMax(min, max);
        }

        public List<IList> GetShippers()
        {
            return aOleDBLoader.GetShippers();
        }

        public List<IList> GetSuppliers()
        {
            return aOleDBLoader.GetSuppliers();
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
