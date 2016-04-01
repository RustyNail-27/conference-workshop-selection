namespace Workshop_Selector
{
    partial class Form1
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
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.calcTotalLabel = new System.Windows.Forms.Label();
            this.calcLodgingLabel = new System.Windows.Forms.Label();
            this.calcRegistrationLabel = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.daysLabel = new System.Windows.Forms.Label();
            this.calcDaysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(12, 27);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(101, 82);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(119, 27);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 82);
            this.locationListBox.TabIndex = 1;
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(9, 11);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(56, 13);
            this.workshopLabel.TabIndex = 2;
            this.workshopLabel.Text = "Workshop";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(116, 11);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(79, 219);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Location = new System.Drawing.Point(65, 187);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(48, 13);
            this.lodgingLabel.TabIndex = 5;
            this.lodgingLabel.Text = "Lodging:";
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Location = new System.Drawing.Point(47, 155);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(66, 13);
            this.registrationLabel.TabIndex = 6;
            this.registrationLabel.Text = "Registration:";
            // 
            // calcTotalLabel
            // 
            this.calcTotalLabel.BackColor = System.Drawing.SystemColors.Info;
            this.calcTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcTotalLabel.Location = new System.Drawing.Point(119, 214);
            this.calcTotalLabel.Name = "calcTotalLabel";
            this.calcTotalLabel.Size = new System.Drawing.Size(71, 23);
            this.calcTotalLabel.TabIndex = 7;
            this.calcTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcLodgingLabel
            // 
            this.calcLodgingLabel.BackColor = System.Drawing.SystemColors.Info;
            this.calcLodgingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcLodgingLabel.Location = new System.Drawing.Point(119, 182);
            this.calcLodgingLabel.Name = "calcLodgingLabel";
            this.calcLodgingLabel.Size = new System.Drawing.Size(71, 23);
            this.calcLodgingLabel.TabIndex = 8;
            this.calcLodgingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcRegistrationLabel
            // 
            this.calcRegistrationLabel.BackColor = System.Drawing.SystemColors.Info;
            this.calcRegistrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcRegistrationLabel.Location = new System.Drawing.Point(119, 150);
            this.calcRegistrationLabel.Name = "calcRegistrationLabel";
            this.calcRegistrationLabel.Size = new System.Drawing.Size(71, 23);
            this.calcRegistrationLabel.TabIndex = 9;
            this.calcRegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(38, 256);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(75, 40);
            this.costButton.TabIndex = 10;
            this.costButton.Text = "Calculate Cost";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(144, 256);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(29, 122);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(84, 13);
            this.daysLabel.TabIndex = 12;
            this.daysLabel.Text = "Number of days:";
            // 
            // calcDaysLabel
            // 
            this.calcDaysLabel.BackColor = System.Drawing.SystemColors.Info;
            this.calcDaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcDaysLabel.Location = new System.Drawing.Point(119, 117);
            this.calcDaysLabel.Name = "calcDaysLabel";
            this.calcDaysLabel.Size = new System.Drawing.Size(71, 23);
            this.calcDaysLabel.TabIndex = 13;
            this.calcDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 308);
            this.Controls.Add(this.calcDaysLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.calcRegistrationLabel);
            this.Controls.Add(this.calcLodgingLabel);
            this.Controls.Add(this.calcTotalLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workshopListBox);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label calcTotalLabel;
        private System.Windows.Forms.Label calcLodgingLabel;
        private System.Windows.Forms.Label calcRegistrationLabel;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label calcDaysLabel;
    }
}

