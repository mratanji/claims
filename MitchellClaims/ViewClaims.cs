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
            this.claims = new List<MitchellClaimType>();
            if (this.claims == null) { System.Console.WriteLine("Null was encountered"); }
            else
            {
                this.claims = claims;
                dataGridView1.DataSource = claims;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
