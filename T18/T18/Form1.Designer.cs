namespace T18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SchoolCB = new System.Windows.Forms.ComboBox();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostcodeLB = new System.Windows.Forms.Label();
            this.CityLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.PositionLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.MobileLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose school";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose person";
            // 
            // SchoolCB
            // 
            this.SchoolCB.FormattingEnabled = true;
            this.SchoolCB.Location = new System.Drawing.Point(28, 67);
            this.SchoolCB.Name = "SchoolCB";
            this.SchoolCB.Size = new System.Drawing.Size(215, 27);
            this.SchoolCB.TabIndex = 0;
            this.SchoolCB.SelectedIndexChanged += new System.EventHandler(this.SchoolCB_SelectedIndexChanged);
            this.SchoolCB.TextChanged += new System.EventHandler(this.SchoolCB_SelectedIndexChanged);
            // 
            // PersonCB
            // 
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Location = new System.Drawing.Point(391, 67);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(215, 27);
            this.PersonCB.TabIndex = 0;
            this.PersonCB.SelectedIndexChanged += new System.EventHandler(this.PersonCB_TextChanged);
            this.PersonCB.TextChanged += new System.EventHandler(this.PersonCB_TextChanged);
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Location = new System.Drawing.Point(28, 120);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(61, 19);
            this.AddressLB.TabIndex = 4;
            this.AddressLB.Text = "Address";
            // 
            // PostcodeLB
            // 
            this.PostcodeLB.AutoSize = true;
            this.PostcodeLB.Location = new System.Drawing.Point(28, 165);
            this.PostcodeLB.Name = "PostcodeLB";
            this.PostcodeLB.Size = new System.Drawing.Size(68, 19);
            this.PostcodeLB.TabIndex = 5;
            this.PostcodeLB.Text = "Postcode";
            // 
            // CityLB
            // 
            this.CityLB.AutoSize = true;
            this.CityLB.Location = new System.Drawing.Point(28, 210);
            this.CityLB.Name = "CityLB";
            this.CityLB.Size = new System.Drawing.Size(34, 19);
            this.CityLB.TabIndex = 6;
            this.CityLB.Text = "City";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Location = new System.Drawing.Point(28, 255);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(49, 19);
            this.PhoneLB.TabIndex = 7;
            this.PhoneLB.Text = "Phone";
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(391, 120);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(38, 19);
            this.TitleLB.TabIndex = 8;
            this.TitleLB.Text = "Title";
            // 
            // PositionLB
            // 
            this.PositionLB.AutoSize = true;
            this.PositionLB.Location = new System.Drawing.Point(391, 165);
            this.PositionLB.Name = "PositionLB";
            this.PositionLB.Size = new System.Drawing.Size(61, 19);
            this.PositionLB.TabIndex = 9;
            this.PositionLB.Text = "Position";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(391, 210);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(45, 19);
            this.EmailLB.TabIndex = 10;
            this.EmailLB.Text = "Email";
            // 
            // MobileLB
            // 
            this.MobileLB.AutoSize = true;
            this.MobileLB.Location = new System.Drawing.Point(391, 255);
            this.MobileLB.Name = "MobileLB";
            this.MobileLB.Size = new System.Drawing.Size(54, 19);
            this.MobileLB.TabIndex = 11;
            this.MobileLB.Text = "Mobile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 301);
            this.Controls.Add(this.MobileLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.PositionLB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.CityLB);
            this.Controls.Add(this.PostcodeLB);
            this.Controls.Add(this.AddressLB);
            this.Controls.Add(this.PersonCB);
            this.Controls.Add(this.SchoolCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox SchoolCB;
        private ComboBox PersonCB;
        private Label AddressLB;
        private Label PostcodeLB;
        private Label CityLB;
        private Label PhoneLB;
        private Label TitleLB;
        private Label PositionLB;
        private Label EmailLB;
        private Label MobileLB;
    }
}