using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace T15
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

        private void MsTM_Tick(object sender, EventArgs e)
        {
            tLB.Text = String.Format("{0:hh\\:mm\\:ss\\:ff}", stopwatch.Elapsed);
        }
    }
}