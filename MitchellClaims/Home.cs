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
        public HashSet<MitchellClaimType> claimsDB = new HashSet<MitchellClaimType>();

        public Home()
        {
            // Already have compiled a library version of the XML schema        
            InitializeComponent();
        }

        private void addClaimButton_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(MitchellClaimType));
            FileStream fs = new FileStream("create-claim.xml", FileMode.Open);
            MitchellClaimType newClaim = ser.Deserialize(fs) as MitchellClaimType;
            if (newClaim != null)
            {
                bool result = claimsDB.Add(newClaim);
                //Console.WriteLine("Claim #" + newClaim.ClaimNumber +" add status: " + result);
                //Console.WriteLine("Size of hashset: " + claimsDB.Count);
                //Console.WriteLine("hashcode: " + newClaim.GetHashCode());
                if (!result) { MessageBox.Show("Claim already exists in the Database!"); }
                else MessageBox.Show("Claim was succesfully added!");
            }
            // Remember to close the file!
            fs.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Not needed 
        }

        private void viewClaimsButton_Click(object sender, EventArgs e)
        {
            // On button click, pull the date from the calendar boxes and look through the hashset for 
            // any claims that fall in the range. If they do, add to a new List and have that List
            // passed as a variable to a new form window that will render the data.

            DateTime start = monthCalendar1.SelectionRange.Start;
            DateTime end = monthCalendar2.SelectionRange.Start;
            List<MitchellClaimType> selected = new List<MitchellClaimType>();
            List<MitchellClaimType> claims = claimsDB.ToList();
            for (int i = 0; i < claimsDB.Count; i++)
            {
                if (claims[i].LossDate >= start && claims[i].LossDate <= end) selected.Add(claims[i]);
            }
            if (selected.Count == 0)
            {
                MessageBox.Show("No claims found for that period of time, try annother date?");
            }
            else
            {
                ViewClaims view = new ViewClaims(selected);
                view.Show();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // not needed
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
        
        }
    }
}
