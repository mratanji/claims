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
    }
}
