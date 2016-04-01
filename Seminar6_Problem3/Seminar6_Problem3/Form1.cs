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
    
    public partial class MainForm : Form
    {
        private Vacation[] vacations = new Vacation[20];
        private int count = 0;

        public MainForm()
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
                    vacations[i] = new Vacation(); 

                    //read a line from file
                    line = inputFile.ReadLine();

                    //tokenize the line
                    string[] tokens = line.Split(delim);

                    vacations[i].Location = tokens[0];
                    vacations[i].Length = int.Parse(tokens[1]);
                    vacations[i].Cost = decimal.Parse(tokens[2]);
                   
                    i++;
                }

                inputFile.Close();
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
                if (vacations[i] != null)
                {
                    locationListBox.Items.Add(vacations[i].Location);
                    
                }
            }

            count = locationListBox.Items.Count;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read the vacations.txt file
            ReadFile();

            //display locations
            DisplayLocations();
        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lengthTextBox.Text = (vacations[locationListBox.SelectedIndex].Length) +" days";

            costTextBox.Text = vacations[locationListBox.SelectedIndex].Cost.ToString("c");
        }

        private void addVacationButton_Click(object sender, EventArgs e)
        {
            if (count >= vacations.Length)
            {
                MessageBox.Show("The list of vacations is at capacity");
            }
            else
            {
                AddVacation addVac = new AddVacation();

                DialogResult res = addVac.ShowDialog();

                if (res == DialogResult.OK)
                {
                    vacations[count] = new Vacation();
                    vacations[count].Location = addVac.NewLocation;
                    vacations[count].Length = int.Parse(addVac.NewLength);
                    vacations[count].Cost = decimal.Parse(addVac.NewCost);

                    locationListBox.Items.Clear();

                    DisplayLocations();
                    
                    StreamWriter outputFile = new StreamWriter("vacations.txt", true);

                    outputFile.WriteLine();

                    outputFile.Write(addVac.NewLocation + "," + addVac.NewLength + "," + addVac.NewCost);

                    outputFile.Close();
                    
                    count++;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
