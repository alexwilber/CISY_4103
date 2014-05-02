/*
 * 
 * Written by Alex Wilber
 * Date: 1/29/2014
 * This class gets and sets the Shipper Variables.
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
    class Shipper : IList
    {
        //Create Class Members
        public static int numShippers = 0;
        private int shipperID = -9999;
        private string companyName = "N/A";
        private string phone = "N/A";
        public static string totalCount()
        {
            return "Shippers: " + numShippers + "\n";
        }
        
        //Constructors Start Here
        public Shipper()
        {
            //any initialization code would go here
            numShippers++;
        }
        // This is a constructer and only runs once when an object is first created
        public Shipper(int aShipperID, string aCompanyName, string aPhone)
            : this()
        {
            this.shipperID = aShipperID;
            this.companyName = aCompanyName;
            this.phone = aPhone;
        }
        public Shipper(int aShipperID, string aCompanyName)
            : this(aShipperID, aCompanyName, "N/A")
        {

        }
        public Shipper(int aShipperID)
            : this(aShipperID, "N/A", "N/A")
        {

        }

        //Get/Set Methods
        public int ShipperID
        {
            get
            {
                return this.shipperID;
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
        public override string ToString()
        {
            // This method is for printing out the current state of the object
            string aString = "";
            aString = aString + "Shipper ID = " + ShipperID + "\n";
            aString = aString + "Company Name = " + CompanyName + "\n";
            aString = aString + "Phone = " + Phone + "\n";
            return aString;
        }
    }
}
