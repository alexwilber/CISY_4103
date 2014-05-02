/*
 * 
 * Written by Alex Wilber
 * Date: 2/14/2014
 * 
 * Handles errors that the user may create.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Error : IList
    {
        public override string ToString()
        {
            // This methods is for printing out the current state of the object
            return "The input was not valid.";
        }
    }
}
