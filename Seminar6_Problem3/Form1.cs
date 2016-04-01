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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Seminar6_Problem3
{
    
    public partial class Form1 : Form
    {
        private Vacation[] vacations = new Vacation[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile()
        {
            int i=0;

            try
            {
                //to read file
                StreamReader inputFile;
                //to hold a line from the file
                string line;

                

                //create delimiter array
                char[] delim = { ',' };

                //open the vacations.txt file
                inputFile = File.OpenText("vacations.txt");

                //read the lines from file
                while (!inputFile.EndOfStream && i < vacations.Length)
                {
                    //create an instance of the Vacation
                   // Vacation trip = new Vacation();

                    //read a line from file
                    line = inputFile.ReadLine();

                    //tokenize the line
                    string[] tokens = line.Split(delim);

                    //store the tokens in the trip object
                    string loc = tokens[0];
                    int lng = int.Parse(tokens[1]);
                    decimal price = decimal.Parse(tokens[2]);

                    //create a new Vacation object at index
                    vacations[i] = new Vacation(loc,lng,price); 
                   
                    i++;
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayLocations()
        {
            
            for (int i = 0; i < vacations.Length; i++)
            {
                locationListBox.Items.Add(vacations[i].Location);
            }
            
            /*
            foreach (Vacation trip in vacations)
            {
                locationListBox.Items.Add(trip.Location);
            }
             * */
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read the vacations.txt file
            ReadFile();

            //display locations
            DisplayLocations();
        }
    }
}
