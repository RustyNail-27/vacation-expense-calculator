/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 7
* Due Date:  Mar.24, 2015
*
* Program Purpose: application that reads a file
 * containing information about vacations. It reads
 * the information from the file and stores it into an
 * array of vacation objects. Creates a list of possible
 * destinations, and can show the length of trip
 * and cost.  Allow user to add other possible
 * vacations on a second form.
*
****/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6_Problem3
{
    class Vacation
    {
        private string location;
        private int length;
        private decimal cost;

        public Vacation()
        {
            location = "";
            length = 0;
            cost = 0;
        }

        public Vacation(string loc,int lng,decimal price)
        {
            location = loc;
            length = lng;
            cost = price;
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

    }
}
