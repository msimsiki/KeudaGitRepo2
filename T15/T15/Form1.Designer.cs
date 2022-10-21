namespace T15
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
            this.components = new System.ComponentModel.Container();
            this.tLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.MsTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tLB
            // 
            this.tLB.AutoSize = true;
            this.tLB.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tLB.Location = new System.Drawing.Point(12, 9);
            this.tLB.Name = "tLB";
            this.tLB.Size = new System.Drawing.Size(473, 97);
            this.tLB.TabIndex = 0;
            this.tLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(12, 109);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(82, 36);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "START";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(206, 109);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(83, 36);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(407, 109);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(75, 36);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "RESET";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // MsTM
            // 
            this.MsTM.Enabled = true;
            this.MsTM.Tick += new System.EventHandler(this.MsTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 157);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.tLB);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 15";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tLB;
        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
        private System.Windows.Forms.Timer MsTM;
    }
}