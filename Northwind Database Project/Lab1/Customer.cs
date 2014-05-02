/*
 * 
 * Written by Alex Wilber
 * Date: 1/29/2014
 * This class gets and sets the Customer Variables.
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
    class Customer : IList
    {
        //Create Class Members
        public static int numCustomers = 0;
        private string customerID = "N/A";
        private string companyName = "N/A";
        private string contactName = "N/A";
        private string contactTitle = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string region = "N/A";
        private string postalCode = "N/A";
        private string country = "N/A";
        private string phone = "N/A";
        private string fax = "N/A";
        public static string totalCount()
        {
            return "Customers: " + numCustomers + "\n";
        }
        
        //Constructors Start Here
        public Customer()
        {
            numCustomers++;
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress,string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
            :this()
        {
            this.customerID = aCustomerID;
            this.companyName = aCompanyName;
            this.contactName = aContactName;
            this.contactTitle = aContactTitle;
            this.address = anAddress;
            this.city = aCity;
            this.region = aRegion;
            this.postalCode = aPostalCode;
            this.country = aCountry;
            this.phone = aPhone;
            this.fax = aFax;
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress,string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone)
            : this( aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress,aCity, aRegion, aPostalCode, aCountry, aPhone, "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A")
        { 
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress,aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress,aCity, aRegion, "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, anAddress,"N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName, string aContactTitle, string anAddress)
            : this(aCustomerID, aCompanyName, aContactName, aContactTitle, "N/A","N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName, string aContactName)
            : this(aCustomerID, aCompanyName, aContactName,"N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID, string aCompanyName)
            : this(aCustomerID, aCompanyName, "N/A","N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Customer(string aCustomerID)
            : this(aCustomerID,"N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }

        //Get/Set Methods
        public string CustomerID
        {
            get
            {
                return this.customerID;
            }
        }
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }
        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                this.contactName = value;
            }
        }
        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }
            set
            {
                this.contactTitle = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                this.region = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                this.postalCode = value;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }
        public override string ToString()
        {
            // This methods is for printing out the current state of the object
            string aString = "";
            aString = aString + "Customer ID = " + CustomerID + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Contact Name = " + ContactName + "\n";
            aString = aString + "Contact Title = " + ContactTitle + "\n";
            aString = aString + "Address = " + Address + "\n";
            aString = aString + "City = " + City + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            aString = aString + "Fax = " + Fax + "\n";
            return aString;
        }
    }
}
