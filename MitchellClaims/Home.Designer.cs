namespace MitchellClaims
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addClaimButton = new System.Windows.Forms.Button();
            this.viewClaimsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addClaimButton
            // 
            this.addClaimButton.Location = new System.Drawing.Point(98, 58);
            this.addClaimButton.Name = "addClaimButton";
            this.addClaimButton.Size = new System.Drawing.Size(75, 23);
            this.addClaimButton.TabIndex = 0;
            this.addClaimButton.Text = "Add Claim";
            this.addClaimButton.UseVisualStyleBackColor = true;
            this.addClaimButton.Click += new System.EventHandler(this.addClaimButton_Click);
            // 
            // viewClaimsButton
            // 
            this.viewClaimsButton.Location = new System.Drawing.Point(98, 111);
            this.viewClaimsButton.Name = "viewClaimsButton";
            this.viewClaimsButton.Size = new System.Drawing.Size(75, 23);
            this.viewClaimsButton.TabIndex = 1;
            this.viewClaimsButton.Text = "View Claims";
            this.viewClaimsButton.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.viewClaimsButton);
            this.Controls.Add(this.addClaimButton);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClaimButton;
        private System.Windows.Forms.Button viewClaimsButton;
    }
}

