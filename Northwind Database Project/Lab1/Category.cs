/*
 * 
 * Written by Alex Wilber
 * Date: 1/29/2014
 * This class gets and sets the Category Variables.
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
    class Category : IList
    {
        //Create Class Members
        public static int numCategories = 0;
        private int categoryID = 0;
        private string categoryName = "N/A";
        private string description = "N/A";
        public static string totalCount()
        {
            return "Categories: " + numCategories + "\n";
        }
        
        //Constructors Start Here
        public Category()
        {

            //any initialization code would go here
            numCategories++;
        }
        // This is a constructer and only runs once when an object is first created
        public Category(int anID, string aCategoryName, string aDescription)
            : this()
        {
            this.categoryID = anID;
            this.categoryName = aCategoryName;
            this.description = aDescription;
        }
        public Category(int anID, string aCategoryName)
            : this(anID, aCategoryName, "N/A")
        {

        }
        public Category(int anID)
            : this(anID, "N/A", "N/A")
        {

        }

        //Get/Set Methods
        public int CategoryID
        {
            get
            {
                return this.categoryID;
            }
        }
        public string CategoryName
        {
            get
            {
                return this.categoryName;
            }
            set
            {
                this.categoryName = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        public override string ToString()
        {
            // This method is for printing out the current state of the object
            string aString = "";
            aString = aString + "Category Id = " + CategoryID + "\n";
            aString = aString + "Category Name = " + CategoryName + "\n";
            aString = aString + "Description = " + Description + "\n";
            return aString;
        }
    }
}
