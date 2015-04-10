using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitchellClaims
{
    public partial class ViewClaims : Form
    {
        List<MitchellClaimType> claims;
        public ViewClaims(List<MitchellClaimType> claims)
        {
            InitializeComponent();
            // Build it's own local version of the DB
            this.claims = new List<MitchellClaimType>();
            this.claims = claims;
            // Render the data in a DataGrid View
            dataGridView1.DataSource = claims;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Stub method
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Stub method
        }
    }
}
