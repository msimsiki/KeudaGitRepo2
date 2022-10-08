namespace T6
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
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.UserIdLB = new System.Windows.Forms.Label();
            this.UserPwLB = new System.Windows.Forms.Label();
            this.UserIdTB = new System.Windows.Forms.TextBox();
            this.UserPwTB = new System.Windows.Forms.TextBox();
            this.SignInBT = new System.Windows.Forms.Button();
            this.InvalidLB = new System.Windows.Forms.Label();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.WelcomeLB = new System.Windows.Forms.Label();
            this.SignInPanel.SuspendLayout();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SignInPanel.Controls.Add(this.InvalidLB);
            this.SignInPanel.Controls.Add(this.SignInBT);
            this.SignInPanel.Controls.Add(this.UserPwTB);
            this.SignInPanel.Controls.Add(this.UserIdTB);
            this.SignInPanel.Controls.Add(this.UserPwLB);
            this.SignInPanel.Controls.Add(this.UserIdLB);
            this.SignInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignInPanel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignInPanel.ForeColor = System.Drawing.Color.Gold;
            this.SignInPanel.Location = new System.Drawing.Point(0, 0);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(377, 151);
            this.SignInPanel.TabIndex = 0;
            // 
            // UserIdLB
            // 
            this.UserIdLB.AutoSize = true;
            this.UserIdLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserIdLB.Location = new System.Drawing.Point(21, 23);
            this.UserIdLB.Name = "UserIdLB";
            this.UserIdLB.Size = new System.Drawing.Size(27, 23);
            this.UserIdLB.TabIndex = 0;
            this.UserIdLB.Text = "ID";
            // 
            // UserPwLB
            // 
            this.UserPwLB.AutoSize = true;
            this.UserPwLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserPwLB.Location = new System.Drawing.Point(21, 65);
            this.UserPwLB.Name = "UserPwLB";
            this.UserPwLB.Size = new System.Drawing.Size(37, 23);
            this.UserPwLB.TabIndex = 1;
            this.UserPwLB.Text = "PW";
            // 
            // UserIdTB
            // 
            this.UserIdTB.Location = new System.Drawing.Point(103, 20);
            this.UserIdTB.Name = "UserIdTB";
            this.UserIdTB.Size = new System.Drawing.Size(160, 31);
            this.UserIdTB.TabIndex = 2;
            // 
            // UserPwTB
            // 
            this.UserPwTB.Location = new System.Drawing.Point(103, 62);
            this.UserPwTB.Name = "UserPwTB";
            this.UserPwTB.Size = new System.Drawing.Size(160, 31);
            this.UserPwTB.TabIndex = 3;
            // 
            // SignInBT
            // 
            this.SignInBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignInBT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignInBT.ForeColor = System.Drawing.Color.Black;
            this.SignInBT.Location = new System.Drawing.Point(284, 20);
            this.SignInBT.Name = "SignInBT";
            this.SignInBT.Size = new System.Drawing.Size(75, 73);
            this.SignInBT.TabIndex = 4;
            this.SignInBT.Text = "SIGN IN";
            this.SignInBT.UseVisualStyleBackColor = true;
            this.SignInBT.Click += new System.EventHandler(this.SignInBT_Click);
            // 
            // InvalidLB
            // 
            this.InvalidLB.AutoSize = true;
            this.InvalidLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InvalidLB.ForeColor = System.Drawing.Color.Red;
            this.InvalidLB.Location = new System.Drawing.Point(115, 107);
            this.InvalidLB.Name = "InvalidLB";
            this.InvalidLB.Size = new System.Drawing.Size(81, 23);
            this.InvalidLB.TabIndex = 5;
            this.InvalidLB.Text = "Message";
            this.InvalidLB.Visible = false;
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.DarkRed;
            this.WelcomePanel.Controls.Add(this.WelcomeLB);
            this.WelcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomePanel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomePanel.ForeColor = System.Drawing.Color.Snow;
            this.WelcomePanel.Location = new System.Drawing.Point(0, 0);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(377, 151);
            this.WelcomePanel.TabIndex = 1;
            this.WelcomePanel.Visible = false;
            // 
            // WelcomeLB
            // 
            this.WelcomeLB.AutoSize = true;
            this.WelcomeLB.Location = new System.Drawing.Point(71, 42);
            this.WelcomeLB.Name = "WelcomeLB";
            this.WelcomeLB.Size = new System.Drawing.Size(233, 59);
            this.WelcomeLB.TabIndex = 0;
            this.WelcomeLB.Text = "WELCOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 151);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.SignInPanel);
            this.Name = "Form1";
            this.Text = "Harjoitus 6";
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SignInPanel;
        private Button SignInBT;
        private TextBox UserPwTB;
        private TextBox UserIdTB;
        private Label UserPwLB;
        private Label UserIdLB;
        private Label InvalidLB;
        private Panel WelcomePanel;
        private Label WelcomeLB;
    }
}