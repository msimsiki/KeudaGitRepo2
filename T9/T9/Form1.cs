namespace T9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBT_Click(object sender, EventArgs e)
        {
            double result;
            double degree = Convert.ToDouble(DegreeTB.Text);
            if (CelsiusRB.Checked)
            {
                result = degree * 1.8 + 32;
                ResultLB.Text = degree + " Fahrenheit " + result + " Celsius";
                ResultLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                result = (degree - 32) / 1.8;
                ResultLB.Text = degree + " Celcius " + result + " Fahrenheit";
                ResultLB.Visible = true;
            }
            else
            {
                ResultLB.Text = "Choose one of the units or enter the correct degree!";
                ResultLB.Visible = true;
            }
        }
    }
}