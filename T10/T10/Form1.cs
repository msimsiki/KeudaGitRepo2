namespace T10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBT_Click(object sender, EventArgs e)
        {
            double weight = 0, height = 0;
            weight = Convert.ToDouble(WeightTB.Text);
            height = Convert.ToDouble(HeightTB.Text);
            double bmi = Math.Round(weight / (height * height), 2);
            if (bmi < 18.5)
            {
                BmiLB.Text = "Weight index: " + bmi;
                BmiLB.ForeColor = Color.Blue;
                BmiLB.Visible = true;
                ResultLB.Text = "Underweight!";
                ResultLB.ForeColor = Color.Blue;
                ResultLB.Visible = true;
            }
            else if (bmi < 25)
            {
                BmiLB.Text = "Weight index: " + bmi;
                BmiLB.ForeColor = Color.Green;
                BmiLB.Visible = true;
                ResultLB.Text = "Regular";
                ResultLB.ForeColor = Color.Green;
                ResultLB.Visible = true;
            }
            else if (bmi < 40)
            {
                BmiLB.Text = "Weight index: " + bmi;
                BmiLB.ForeColor = Color.Yellow;
                BmiLB.Visible = true;
                ResultLB.Text = "Overweight!";
                ResultLB.ForeColor = Color.Yellow;
                ResultLB.Visible = true;
            }
            else
            {
                BmiLB.Text = "Weight index: " + bmi;
                BmiLB.ForeColor = Color.Red;
                BmiLB.Visible = true;
                ResultLB.Text = "OBESE!";
                ResultLB.ForeColor = Color.Red;
                ResultLB.Visible = true;
            }

        }
    }
}