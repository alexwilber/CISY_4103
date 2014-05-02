/*
 * 
 * Written by Alex Wilber
 * Date: 2/14/2014
 * 
 * Handles all of the ways the programs information prints out.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ConsoleView
    {
        private DatabaseController aController;
        //Constructor
        private ConsoleView()
        {
            //any initiliazation code goes here.
        }
        //Constructor that takes a paramater of aController from the controller.
        public ConsoleView(DatabaseController aController)
            : this()
        {
            this.aController = aController;
            //Prints out options for the user.
            this.PrintsOut();
        }

       //Old unused method that prinds out all of the tables
        /*public void PrintMenu()
        {
            Console.WriteLine("Press");
            Console.ReadLine();
            this.Print(this.aController.GetCategories());
            this.Print(this.aController.GetCustomers());
            this.Print(this.aController.GetOrderDetails());
            this.Print(this.aController.GetEmployees());
            this.Print(this.aController.GetOrders());
            this.Print(this.aController.GetProducts());
            this.Print(this.aController.GetShippers());
            this.Print(this.aController.GetSuppliers());
        }*/
        //Print method that takes a string; writes and reads it to the screen
        public void Print(string aString)
        {

            Console.WriteLine(aString);
            Console.ReadLine();
        }
        //Print method that takes a list as a paramater and for each of the lists prints out the current state of the object, ToString
        public void Print(List<IList> aList)
        {
            //for each of the lists, print out the tostring of that list.
            foreach (IList aListable in aList)
            {
                Console.WriteLine(aListable.ToString());
            }
            Console.ReadLine();
        }
        public void PrintsOut()
        {
            //Prompt for the user.
            Console.WriteLine("Type a number to print out the information.\n");
            Console.WriteLine("0. Print out all");
            Console.WriteLine("1. Categories");
            Console.WriteLine("2. Customers");
            Console.WriteLine("3. Order Details");
            Console.WriteLine("4. Employees");
            Console.WriteLine("5. Orders");
            Console.WriteLine("6. Products");
            Console.WriteLine("7. Shippers");
            Console.WriteLine("8. Suppliers");
            Console.WriteLine("9. Get Product by ID");
            Console.WriteLine("10. Get Product by Unit Price");
            Console.WriteLine("11. Get Product by Category ID");
            Console.WriteLine("12. Totals of all tables");
            //reset the static counters so they do not double.
            this.aController.ResetCounters();
            //take the users input and put it into select
            this.Select(Console.ReadLine());

        }
        //Selects the table/tables to print out based on what the user inputs as their choice.
        public void Select(string input)
        {
            //switch statement for printing out table/tables and for the min/max method.
            switch (input)
            {
                case "0":
                    //prints out all of the tables.
                    this.Print(this.aController.GetCategories());
                    this.Print(this.aController.GetCustomers());
                    this.Print(this.aController.GetOrderDetails());
                    this.Print(this.aController.GetEmployees());
                    this.Print(this.aController.GetOrders());
                    this.Print(this.aController.GetProducts());
                    this.Print(this.aController.GetShippers());
                    this.Print(this.aController.GetSuppliers());
                    break;
                case "1":
                    //prints out categories
                    this.Print(this.aController.GetCategories());
                    break;
                case "2":
                    //prints out customers
                    this.Print(this.aController.GetCustomers());
                    break;
                case "3":
                    //prints out order details
                    this.Print(this.aController.GetOrderDetails());
                    break;
                case "4":
                    //prints out employees
                    this.Print(this.aController.GetEmployees());
                    break;
                case "5":
                    //prints out orders
                    this.Print(this.aController.GetOrders());
                    break;
                case "6":
                    //prints out products
                    this.Print(this.aController.GetProducts());
                    break;
                case "7":
                    //prints out shippers
                    this.Print(this.aController.GetShippers());
                    break;
                case "8":
                    //prints out suppliers
                    this.Print(this.aController.GetSuppliers());
                    break;
                case "9":
                    //asks for the user to type an Id and then takes the input and parses it through the getproductbyid method.
                    Console.WriteLine("Type an ID");
                    this.Print(this.aController.GetProductByID(Console.ReadLine()));
                    break;
                case "10":
                    //ask the use to enter a min, then a max
                    Console.WriteLine("Enter a Min");
                    string min = Console.ReadLine();
                    Console.WriteLine("Enter a Max");
                    string max = Console.ReadLine();
                    //send the values of the min and max the user inputs to the controller.
                    this.Print(this.aController.GetMinMax(min, max));
                    break;
                case "11":
                    //The user enters an Id and it is read by the getproductsbycategory method
                    Console.WriteLine("Enter a Category ID");
                    this.Print(this.aController.GetProductsByCategory(Console.ReadLine()));
                    break;
                case "12":
                    //This case is for the static counters.
                    //Loads tables so the method totalCount will count.
                    this.aController.GetCategories();
                    this.aController.GetCustomers();
                    this.aController.GetOrderDetails();
                    this.aController.GetEmployees();
                    this.aController.GetOrders();
                    this.aController.GetProducts();
                    this.aController.GetShippers();
                    this.aController.GetSuppliers();
                    //prints out the total count of each table.
                    Console.WriteLine(Category.totalCount());
                    Console.WriteLine(Customer.totalCount());
                    Console.WriteLine(OrderDetail.totalCount());
                    Console.WriteLine(Employee.totalCount());
                    Console.WriteLine(Order.totalCount());
                    Console.WriteLine(Product.totalCount());
                    Console.WriteLine(Shipper.totalCount());
                    Console.WriteLine(Supplier.totalCount());
                    Console.ReadLine();
                    //this is reset in the PrintsOut() method so it does not double.
                    break;
                default:
                    //clears console and asks the user to provide valid input
                    Console.Clear();
                    Console.WriteLine("Please enter a vaild value (0-12)");
                    break;
            }
            //calls the prints out method again.
            this.PrintsOut();
        }
    }
}
