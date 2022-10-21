namespace T11
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
            this.Dice1PB = new System.Windows.Forms.PictureBox();
            this.Dice2PB = new System.Windows.Forms.PictureBox();
            this.RollBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice1PB
            // 
            this.Dice1PB.Image = global::T11.Properties.Resources.dice01;
            this.Dice1PB.Location = new System.Drawing.Point(26, 28);
            this.Dice1PB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dice1PB.Name = "Dice1PB";
            this.Dice1PB.Size = new System.Drawing.Size(103, 95);
            this.Dice1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice1PB.TabIndex = 0;
            this.Dice1PB.TabStop = false;
            // 
            // Dice2PB
            // 
            this.Dice2PB.Image = global::T11.Properties.Resources.dice01;
            this.Dice2PB.Location = new System.Drawing.Point(186, 28);
            this.Dice2PB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dice2PB.Name = "Dice2PB";
            this.Dice2PB.Size = new System.Drawing.Size(101, 95);
            this.Dice2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dice2PB.TabIndex = 1;
            this.Dice2PB.TabStop = false;
            // 
            // RollBT
            // 
            this.RollBT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollBT.Location = new System.Drawing.Point(26, 152);
            this.RollBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RollBT.Name = "RollBT";
            this.RollBT.Size = new System.Drawing.Size(261, 61);
            this.RollBT.TabIndex = 2;
            this.RollBT.Text = "ROLL THE DICES";
            this.RollBT.UseVisualStyleBackColor = true;
            this.RollBT.Click += new System.EventHandler(this.RollBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 241);
            this.Controls.Add(this.RollBT);
            this.Controls.Add(this.Dice2PB);
            this.Controls.Add(this.Dice1PB);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 11";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Dice1PB;
        private PictureBox Dice2PB;
        private Button RollBT;
    }
}