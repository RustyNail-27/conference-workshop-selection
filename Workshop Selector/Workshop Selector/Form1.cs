/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 3
* Due Date:  Feb. 1, 2015
*
* Program Purpose:  Create an application that lets the user select a workshop from one ListBox and
a location from another ListBox. When the user clicks a button, the application
should calculate and display the registration cost, the lodging cost, and the total
cost.
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

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        private decimal regFee = 0m;
        private decimal lodgeFee = 0m;
        private decimal totalFee = 0m;
        private int days = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            string workshop;
            string location;

            if(workshopListBox.SelectedIndex != -1)
            {
                workshop = workshopListBox.SelectedItem.ToString();

                switch(workshop)
                {
                    case "Handling Stress":
                        regFee = 1000.0m;
                        days = 3;
                        break;
                    case "Time Management":
                        regFee = 800.0m;
                        days = 3;
                        break;
                    case "Supervision Skills":
                        regFee = 1500.0m;
                        days = 3;
                        break;
                    case "Negotiation":
                        regFee = 1300.0m;
                        days = 5;
                        break;
                    case "How to Interview":
                        regFee = 500.0m;
                        days = 1;
                        break;
                }
            }
            else
            {
                // No workshop selected
                MessageBox.Show("Select a workshop.");
            }

            if (locationListBox.SelectedIndex != -1)
            {
                location = locationListBox.SelectedItem.ToString();

                switch (location)
                {
                    case "Austin":
                        lodgeFee = 150.0m;
                        break;
                    case "Chicago":
                        lodgeFee = 225.0m;
                        break;
                    case "Dallas":
                        lodgeFee = 175.0m;
                        break;
                    case "Orlando":
                        lodgeFee = 300.0m;
                        break;
                    case "Phoenix":
                        lodgeFee = 175.0m;
                        break;
                    case "Raleigh":
                        lodgeFee = 150.0m;
                        break;
                }
            }
            else
            {
                // No location selected
                MessageBox.Show("Select a location.");
            }

            calcDaysLabel.Text = days.ToString();

            calcRegistrationLabel.Text = regFee.ToString("c");

            calcLodgingLabel.Text = (days * lodgeFee).ToString("c");

            calcTotalLabel.Text = ((days * lodgeFee) + regFee).ToString("c");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
