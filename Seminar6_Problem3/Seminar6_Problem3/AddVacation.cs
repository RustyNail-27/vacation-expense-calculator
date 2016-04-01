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
    public partial class AddVacation : Form
    {
        public AddVacation()
        {
            InitializeComponent();
        }

        private void newCostLabel_Click(object sender, EventArgs e)
        {

        }

        public string NewLocation
        {
            get
            {
                return newLocationTextBox.Text;
            }
        }

        public string NewLength
        {
            get
            {
                return newLengthTextBox.Text;
            }
        }

        public string NewCost
        {
            get
            {
                return newCostTextBox.Text;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal cost;
            int length;
            
            if (decimal.TryParse(newCostTextBox.Text, out cost))
            {
                if (int.TryParse(newLengthTextBox.Text, out length))
                {
                    /*
                    StreamWriter outputFile;

                    outputFile = File.AppendText("vacations.txt");

                    outputFile.WriteLine(newLocationTextBox.Text + "," + newLengthTextBox.Text + "," + newCostTextBox.Text);

                    outputFile.Close();
                     */
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("length must be an interger number");
            }
            else
                MessageBox.Show("cost must be a decimal number");    
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
