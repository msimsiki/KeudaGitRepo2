using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace T14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string journal = File.ReadAllText("C:\\Users\\simsiki\\source\\repos\\KeudaGitRepo2\\T14\\journal.txt");
            JournalTB.Text = journal;
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string journal = "";
            journal += JournalTB.Text;
            journal += "\t" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n\n";
            TextWriter text = new StreamWriter("C:\\Users\\simsiki\\source\\repos\\KeudaGitRepo2\\T14\\journal.txt");
            text.Write(journal);
            text.Close();
            Application.Exit();
        }
    }
}