namespace T14
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
            this.JournalTB = new System.Windows.Forms.TextBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JournalTB
            // 
            this.JournalTB.Location = new System.Drawing.Point(17, 18);
            this.JournalTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JournalTB.Multiline = true;
            this.JournalTB.Name = "JournalTB";
            this.JournalTB.Size = new System.Drawing.Size(677, 259);
            this.JournalTB.TabIndex = 0;
            // 
            // SaveBT
            // 
            this.SaveBT.Location = new System.Drawing.Point(17, 287);
            this.SaveBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(677, 35);
            this.SaveBT.TabIndex = 1;
            this.SaveBT.Text = "SAVE";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 335);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.JournalTB);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox JournalTB;
        private Button SaveBT;
    }
}