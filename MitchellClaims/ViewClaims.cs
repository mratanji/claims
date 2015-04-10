﻿using System;
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
        private List<MitchellClaimType> claims = new List<MitchellClaimType>();
        public ViewClaims(List<MitchellClaimType> claims)
        {
            if (this.claims == null) { System.Console.WriteLine("Null was encountered"); }
            else
            {
            this.claims = claims;
            dataGridView1.DataSource = claims;
            InitializeComponent();
            }
        }


    }
}
