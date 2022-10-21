namespace T13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            rLB.Text = "";
            rLB.Visible = false;
            string[] boys = File.ReadAllLines("C:\\Users\\Simsiki\\source\\repos\\KeudaGitRepo2\\T13\\boys.txt");
            string[] girls = File.ReadAllLines("C:\\Users\\Simsiki\\source\\repos\\KeudaGitRepo2\\T13\\girls.txt");
            string name = CheckTB.Text;
            int countb = 1, countg = 1;
            foreach (string x in boys)
            {
                if (name == x)
                {
                    rLB.Text = "The name " + countb + ". popular boys names from 2020.";
                    rLB.Visible = true;
                }
                countb++;
            }
            foreach (string y in girls)
            {
                if (name == y)
                {
                    rLB.Text = "The name " + countg + ". popular girls names from 2020.";
                    rLB.Visible = true;
                }
                countg++;
            }
            if (rLB.Visible == false)
            {
                rLB.Text = "Entered name could not find in the popular names of 2020 list.";
                rLB.Visible = true;
            }
        }
    }
}