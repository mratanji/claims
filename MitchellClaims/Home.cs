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
            List<MitchellClaimType> newClaim = ser.Deserialize(fs) as List<MitchellClaimType>;
            if (newClaim != null)
            {
                // To keep track of how new entries are added
                List<string> failed = new List<string>();
                Boolean success = false;
                int numAdded = 0;
                int numFailed = 0;

                // Loop through and add all the new claims
                for (int i = 0; i < newClaim.Count; i++)
                {
                    success = claimsDB.Add(newClaim[i]);
                    //Console.WriteLine("Claim #" + newClaim.ClaimNumber +" add status: " + result);
                    //Console.WriteLine("Size of hashset: " + claimsDB.Count);
                    //Console.WriteLine("hashcode: " + newClaim.GetHashCode());
                    if (success)
                    {
                        numAdded++;
                        Console.WriteLine("Added");
                    }
                    else
                    {
                        numFailed++;
                        failed.Add(newClaim[i].ClaimNumber);
                    }
                    // For safety reasons, reset success to false
                    success = false;
                }
                // Report the adding!
                //MessageBox.Show(numAdded + " new claims added, " + numFailed + " claims failed.");
                // Save the claim ID's for later
            }
            // Remember to close the file!
            fs.Close();
        }
    }
}
