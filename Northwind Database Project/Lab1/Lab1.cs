/*
 * 
 * Written by Alex Wilber
 * Date: 2/14/2014
 * 
 * Location of the main method. Where the program starts to run.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Lab1
    {
        public static void Main()
        {
            //Creates a new controller object and parses it through the view.
            DatabaseController aController = new DatabaseController();
            ConsoleView aView = new ConsoleView(aController);
        }
    }
}
