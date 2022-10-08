namespace T1
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
            this.TextLB = new System.Windows.Forms.Label();
            this.ChangeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLB
            // 
            this.TextLB.AutoSize = true;
            this.TextLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextLB.Location = new System.Drawing.Point(45, 23);
            this.TextLB.Name = "TextLB";
            this.TextLB.Size = new System.Drawing.Size(46, 26);
            this.TextLB.TabIndex = 0;
            this.TextLB.Text = "Text";
            // 
            // ChangeBT
            // 
            this.ChangeBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChangeBT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeBT.Location = new System.Drawing.Point(47, 65);
            this.ChangeBT.Name = "ChangeBT";
            this.ChangeBT.Size = new System.Drawing.Size(119, 36);
            this.ChangeBT.TabIndex = 1;
            this.ChangeBT.Text = "Change Text";
            this.ChangeBT.UseVisualStyleBackColor = true;
            this.ChangeBT.Click += new System.EventHandler(this.ChangeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.Controls.Add(this.ChangeBT);
            this.Controls.Add(this.TextLB);
            this.Name = "Form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TextLB;
        private Button ChangeBT;
    }
}