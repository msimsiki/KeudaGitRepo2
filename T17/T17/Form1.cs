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

namespace T17
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontFormatDialog;
        public Form1()
        {
            InitializeComponent();
        }
        private void NewFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(rTB.Text))
                {
                    MessageBox.Show("You must save first!");
                }
                else
                {
                    rTB.Text = string.Empty;
                    Text = "Noname";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not created! " + ex);
            }
        }
        private void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not opened! " + ex);
            }
        }
        private void SaveFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(rTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text File (*.txt) | *.txt | Rich Text File (*.rtf) | *.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, rTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not saved! " + ex);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}