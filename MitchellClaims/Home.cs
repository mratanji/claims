using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;



namespace MitchellClaims
{
    public partial class Home : Form
    {
        Claims claimsDB;
        public Home()
        {
            // Already have compiled a library version of the XML schema        
            InitializeComponent();
            // Initialize the DB
            claimsDB = new Claims();
        }

        private void addClaimButton_Click(object sender, EventArgs e)
        {
            claimsDB.addClaimFromFile("create-claim.xml");
        }

        private void viewClaimsButton_Click(object sender, EventArgs e)
        {
            // On button click, pull the date from the calendar boxes and look through the hashset for 
            // any claims that fall in the range. If they do, add to a new List and have that List
            // passed as a variable to a new form window that will render the data.

            DateTime start = startCalendar.SelectionRange.Start;   // From the calendars
            DateTime end = endCalendar.SelectionRange.Start;
            //Console.WriteLine(start.ToString() + end.ToString());
            List<MitchellClaimType> selected = claimsDB.getClaimsByDate(start, end);   // The list of all the claims that fit the description
            
            if (selected.Count == 0)    // In the case there werre no claims found
                MessageBox.Show("No claims found for that period of time, try annother date?");
            else
            {
                ViewClaims view = new ViewClaims(selected);
                view.Show();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Make sure the user can only choose dates before the end date
            if (startCalendar.SelectionRange.Start > endCalendar.SelectionRange.Start)
            {
                MessageBox.Show("Please select a date before the end date");
                startCalendar.SelectionRange.Start = endCalendar.SelectionRange.Start;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Stub Method
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Make sure the user can only choose dates after the begin date
            if (endCalendar.SelectionRange.Start < startCalendar.SelectionRange.Start)
            {
                MessageBox.Show("Please select a date after the start date");
                endCalendar.SelectionRange.Start = System.DateTime.Today;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Stub Method
        }
    }
}
