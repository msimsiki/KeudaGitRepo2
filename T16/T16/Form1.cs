using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T16
{
    public partial class Form1 : Form
    {
        private int alltime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinsCB.Items.Add(i.ToString());
                SecsCB.Items.Add(i.ToString());
            }
            MinsCB.SelectedIndex = 0;
            SecsCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int mins = int.Parse(MinsCB.SelectedItem.ToString());
            int secs = int.Parse(SecsCB.SelectedItem.ToString());
            alltime = (mins * 60) + secs;
            MsTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            alltime = 0;
            MsTM.Enabled = false;
            tLB.Text = "00:00";
        }

        private void MsTM_Tick(object sender, EventArgs e)
        {
            if (alltime > 0)
            {
                alltime--;
                int mins = alltime / 60;
                int secs = alltime - (mins * 60);
                tLB.Text = mins + ":" + secs;
            }
            else
            {
                MsTM.Stop();
                MessageBox.Show("Time has ended!");
            }
        }
    }
}