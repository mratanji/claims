using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MitchellClaims
{
    public class Claims
    {
        private HashSet<MitchellClaimType> claimsDB;

        public Claims()
        {
            claimsDB = new HashSet<MitchellClaimType>();
        }

        // Method which will read in a properly formatted claim from an XML file and add
        // the corresponding data to the DB
        // Known issue at the momment would be the case if the file has multiple claims in it.
        // As of now, the file path is hardcoded. Also, the data from the file is not verified against the xsd 
        // schema file.
        public Boolean addClaimFromFile(String fileName)
        {
            Boolean result = false;
            XmlSerializer ser = new XmlSerializer(typeof(MitchellClaimType));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            MitchellClaimType newClaim = ser.Deserialize(fs) as MitchellClaimType;
            if (newClaim != null)
            {
                result = claimsDB.Add(newClaim);
                if (!result)
                {
                    MessageBox.Show("Claim already exists in the Database!");
                }
                else MessageBox.Show("Claim was succesfully added!");
            }
            // Remember to close the file!
            fs.Close();
            return result;
        }

        // Simply returns a list version of the claim
        public List<MitchellClaimType> toList()
        {
            return claimsDB.ToList<MitchellClaimType>();
        }

        public int Size()
        {
            return claimsDB.Count;
        }

        // Helper function for when you want to search for a claim by date
        // Returns a List of <MitchellClaimType> objects which fall into the specified date range
        public List<MitchellClaimType> getClaimsByDate(DateTime start, DateTime end)
        {
            List<MitchellClaimType> selected = new List<MitchellClaimType>();   // The list of all the claims that fit the description
            List<MitchellClaimType> claims = claimsDB.ToList();     // Need a conversion to make life easier when dealing with the two data structures
            for (int i = 0; i < claimsDB.Count; i++)
            {          
                if (start <= claims[i].LossDate && end >= claims[i].LossDate)
                    selected.Add(claims[i]);
            }
            return selected;
        }
    }
}
