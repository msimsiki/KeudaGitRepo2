namespace T2
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
            this.TitleLB = new System.Windows.Forms.Label();
            this.ResultLB = new System.Windows.Forms.Label();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.ResultBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLB.Location = new System.Drawing.Point(24, 29);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(127, 26);
            this.TitleLB.TabIndex = 0;
            this.TitleLB.Text = "Enter a word:";
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLB.Location = new System.Drawing.Point(24, 169);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(48, 26);
            this.ResultLB.TabIndex = 1;
            this.ResultLB.Text = "xxxx";
            this.ResultLB.Visible = false;
            // 
            // MessageTB
            // 
            this.MessageTB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageTB.Location = new System.Drawing.Point(24, 69);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(391, 33);
            this.MessageTB.TabIndex = 2;
            // 
            // ResultBT
            // 
            this.ResultBT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBT.Location = new System.Drawing.Point(24, 122);
            this.ResultBT.Name = "ResultBT";
            this.ResultBT.Size = new System.Drawing.Size(126, 33);
            this.ResultBT.TabIndex = 3;
            this.ResultBT.Text = "Show Result";
            this.ResultBT.UseVisualStyleBackColor = true;
            this.ResultBT.Click += new System.EventHandler(this.ResultBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(456, 245);
            this.Controls.Add(this.ResultBT);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.TitleLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLB;
        private Label ResultLB;
        private TextBox MessageTB;
        private Button ResultBT;
    }
}