namespace T16
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
            this.MinsCB = new System.Windows.Forms.ComboBox();
            this.SecsCB = new System.Windows.Forms.ComboBox();
            this.MinsLB = new System.Windows.Forms.Label();
            this.SecsLB = new System.Windows.Forms.Label();
            this.tLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.MsTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinsCB
            // 
            this.MinsCB.FormattingEnabled = true;
            this.MinsCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinsCB.Location = new System.Drawing.Point(12, 45);
            this.MinsCB.Name = "MinsCB";
            this.MinsCB.Size = new System.Drawing.Size(73, 31);
            this.MinsCB.TabIndex = 0;
            // 
            // SecsCB
            // 
            this.SecsCB.FormattingEnabled = true;
            this.SecsCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.SecsCB.Location = new System.Drawing.Point(159, 45);
            this.SecsCB.Name = "SecsCB";
            this.SecsCB.Size = new System.Drawing.Size(74, 31);
            this.SecsCB.TabIndex = 1;
            // 
            // MinsLB
            // 
            this.MinsLB.AutoSize = true;
            this.MinsLB.Location = new System.Drawing.Point(12, 9);
            this.MinsLB.Name = "MinsLB";
            this.MinsLB.Size = new System.Drawing.Size(73, 23);
            this.MinsLB.TabIndex = 2;
            this.MinsLB.Text = "Minutes";
            // 
            // SecsLB
            // 
            this.SecsLB.AutoSize = true;
            this.SecsLB.Location = new System.Drawing.Point(159, 9);
            this.SecsLB.Name = "SecsLB";
            this.SecsLB.Size = new System.Drawing.Size(74, 23);
            this.SecsLB.TabIndex = 3;
            this.SecsLB.Text = "Seconds";
            // 
            // tLB
            // 
            this.tLB.AutoSize = true;
            this.tLB.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tLB.Location = new System.Drawing.Point(51, 79);
            this.tLB.Name = "tLB";
            this.tLB.Size = new System.Drawing.Size(134, 59);
            this.tLB.TabIndex = 4;
            this.tLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(12, 141);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(87, 37);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "START";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(141, 141);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(92, 37);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
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
            this.ClientSize = new System.Drawing.Size(244, 189);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.tLB);
            this.Controls.Add(this.SecsLB);
            this.Controls.Add(this.MinsLB);
            this.Controls.Add(this.SecsCB);
            this.Controls.Add(this.MinsCB);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 16";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox MinsCB;
        private ComboBox SecsCB;
        private Label MinsLB;
        private Label SecsLB;
        private Label tLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer MsTM;
    }
}