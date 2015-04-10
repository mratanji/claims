using System.Windows.Forms;
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.RichTextBox();
            this.startCalendar = new System.Windows.Forms.MonthCalendar();
            this.endCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // addClaimButton
            // 
            this.addClaimButton.Location = new System.Drawing.Point(257, 55);
            this.addClaimButton.Name = "addClaimButton";
            this.addClaimButton.Size = new System.Drawing.Size(107, 61);
            this.addClaimButton.TabIndex = 0;
            this.addClaimButton.Text = "Add Claim";
            this.addClaimButton.UseVisualStyleBackColor = true;
            this.addClaimButton.Click += new System.EventHandler(this.addClaimButton_Click);
            // 
            // viewClaimsButton
            // 
            this.viewClaimsButton.Location = new System.Drawing.Point(257, 423);
            this.viewClaimsButton.Name = "viewClaimsButton";
            this.viewClaimsButton.Size = new System.Drawing.Size(107, 60);
            this.viewClaimsButton.TabIndex = 1;
            this.viewClaimsButton.Text = "View Claims";
            this.viewClaimsButton.UseVisualStyleBackColor = true;
            this.viewClaimsButton.Click += new System.EventHandler(this.viewClaimsButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(90, 144);
            this.startTextBox.Multiline = true;
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(87, 52);
            this.startTextBox.TabIndex = 2;
            this.startTextBox.Text = "To view claims history, select a begin date";
            this.startTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(451, 144);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(87, 52);
            this.endTextBox.TabIndex = 3;
            this.endTextBox.Text = "Please also select an end date";
            // 
            // startCalendar
            // 
            this.startCalendar.Location = new System.Drawing.Point(18, 208);
            this.startCalendar.MaxDate = System.DateTime.Today;
            this.startCalendar.MaxSelectionCount = 1;
            this.startCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startCalendar.Name = "startCalendar";
            this.startCalendar.TabIndex = 4;
            this.startCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // endCalendar
            // 
            this.endCalendar.Location = new System.Drawing.Point(379, 208);
            this.endCalendar.MaxDate = System.DateTime.Today;
            this.endCalendar.MaxSelectionCount = 1;
            this.endCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endCalendar.Name = "endCalendar";
            this.endCalendar.TabIndex = 5;
            this.endCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 508);
            this.Controls.Add(this.endCalendar);
            this.Controls.Add(this.startCalendar);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.viewClaimsButton);
            this.Controls.Add(this.addClaimButton);
            this.Name = "Home";
            this.Text = "Mitchell Claims Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void monthCalendar1_DateChanged_1(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Make sure the user can only choose dates before the end date
            if (startCalendar.SelectionRange.Start > endCalendar.SelectionRange.Start)
            {
                MessageBox.Show("Please select a date before the end date");
                startCalendar.SelectionRange.Start = endCalendar.SelectionRange.Start;
            }
        }

        #endregion

        private System.Windows.Forms.Button addClaimButton;
        private System.Windows.Forms.Button viewClaimsButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.RichTextBox endTextBox;
        private System.Windows.Forms.MonthCalendar startCalendar;
        private System.Windows.Forms.MonthCalendar endCalendar;
    }
}

