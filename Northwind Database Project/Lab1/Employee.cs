/*
 * 
 * Written by Alex Wilber
 * Date: 2/01/2014
 * This class gets and sets the Employee Variables.
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
    class Employee : IList
    {
        //Create Class Members
        public static int numEmployees = 0;
        private string employeeID = "N/A";
        private int reportsTo = -9;
        private string lastName = "N/A";
        private string firstName = "N/A";
        private string title = "N/A";
        private string titleOfCourtesy = "N/A";
        private string birthDate = "N/A";
        private string hireDate = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string region;
        private string postalCode = "N/A";
        private string country = "N/A";
        private string homePhone = "N/A";
        private string extension = "N/A";
        private string notes = "N/A";
        public static string totalCount()
        {
            return "Employees: " + numEmployees + "\n";
        }
        
        //Constructors Start Here
        public Employee()
        {
            numEmployees++;
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress,string aCity, string aRegion,string aPostalCode, string aCountry, string aHomePhone, string anExtension, string aNote)
            :this()
        {
            this.employeeID = anEmployeeID;
            this.reportsTo = isReportedTo;
            this.lastName = aLastName;
            this.firstName = aFirstName;
            this.title = aTitle;
            this.titleOfCourtesy = aTitleOfCourtesy;
            this.birthDate = aBirthDate;
            this.hireDate = aHireDate;
            this.address = anAddress;
            this.city = aCity;
            this.region = aRegion;
            this.postalCode = aPostalCode;
            this.country = aCountry;
            this.homePhone = aHomePhone;
            this.extension = anExtension;
            this.notes = aNote;
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress,string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string anExtension)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress,aCity, aRegion, aPostalCode, aCountry, aHomePhone, anExtension, "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress,aCity, aRegion, aPostalCode, aCountry, aHomePhone, "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress,string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress,aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress,string aCity, string aRegion, string aPostalCode)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress,aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress,string aCity, string aRegion)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress, aCity, aRegion, "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress, string aCity)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, anAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string anAddress)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, aTitleOfCourtesy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, aTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName, string aTitle)
            : this(anEmployeeID, isReportedTo, aLastName, aFirstName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName, string aFirstName)
            : this(anEmployeeID, isReportedTo, aLastName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo, string aLastName)
            : this(anEmployeeID, isReportedTo, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID, int isReportedTo)
            : this(anEmployeeID, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }
        public Employee(string anEmployeeID)
            : this(anEmployeeID, 999999, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {
        }


        //Get/Set Methods
        public string EmployeeID
        {
            get
            {
                return this.employeeID;
            }
        }
        public int ReportsTo
        {
            get
            {
                return this.reportsTo;
            }
            set
            {
                this.reportsTo = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string TitleOfCourtesy
        {
            get
            {
                return this.titleOfCourtesy;
            }
            set
            {
                this.titleOfCourtesy = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }
        public string HireDate
        {
            get
            {
                return this.hireDate;
            }
            set
            {
                this.hireDate = value;
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
        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                this.homePhone = value;
            }
        }
        public string Extension
        {
            get
            {
                return this.extension;
            }
            set
            {
                this.extension = value;
            }
        }
        public string Notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }
        public override string ToString()
        {
            // This methods is for printing out the current state of the object
            string aString = "";
            aString = aString + "Employee ID = " + EmployeeID + "\n";
            aString = aString + "Reports To = " + ReportsTo + "\n";
            aString = aString + "First Name = " + FirstName + "\n";
            aString = aString + "Last Name = " + LastName + "\n";
            aString = aString + "Title = " + Title + "\n";
            aString = aString + "Title Of Courtesy = " + TitleOfCourtesy + "\n";
            aString = aString + "Birth Date = " + BirthDate + "\n";
            aString = aString + "Hire Date = " + HireDate + "\n";
            aString = aString + "Address City = " + Address + "\n";
            aString = aString + "City = " + City + "\n";
            aString = aString + "Region = " + Region + "\n";
            aString = aString + "Postal Code = " + PostalCode + "\n";
            aString = aString + "Country = " + Country + "\n";
            aString = aString + "Home Phone = " + HomePhone + "\n";
            aString = aString + "Extension = " + Extension + "\n";
            aString = aString + "Notes = " + Notes + "\n";
            return aString;
        }
    }
}
