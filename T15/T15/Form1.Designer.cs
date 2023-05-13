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
            components = new System.ComponentModel.Container();
            tLB = new Label();
            StartBT = new Button();
            StopBT = new Button();
            ResetBT = new Button();
            MsTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // tLB
            // 
            tLB.AutoSize = true;
            tLB.Font = new Font("Calibri", 50F, FontStyle.Regular, GraphicsUnit.Point);
            tLB.Location = new Point(12, 9);
            tLB.Name = "tLB";
            tLB.Size = new Size(360, 82);
            tLB.TabIndex = 0;
            tLB.Text = "00:00:00.00";
            // 
            // StartBT
            // 
            StartBT.Location = new Point(12, 109);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(82, 36);
            StartBT.TabIndex = 1;
            StartBT.Text = "START";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(154, 109);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(83, 36);
            StopBT.TabIndex = 2;
            StopBT.Text = "PAUSE";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Location = new Point(297, 109);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(75, 36);
            ResetBT.TabIndex = 3;
            ResetBT.Text = "RESET";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // MsTM
            // 
            MsTM.Enabled = true;
            MsTM.Tick += MsTM_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 157);
            Controls.Add(ResetBT);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(tLB);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Harjoitus 15";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tLB;
        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
        private System.Windows.Forms.Timer MsTM;
    }
}