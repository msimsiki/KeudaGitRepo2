namespace T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime born = dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            double difference = Math.Round((now - born).TotalDays);
            YearLB.Text = Math.Ceiling(difference / 365.25) + " Years";
            MonthLB.Text = Math.Ceiling(difference * 12 / 365.25) + " Months";
            DayLB.Text = Math.Ceiling(difference) + " Days";
            HourLB.Text = Math.Round((now - born).TotalHours).ToString() + " Hours"; 
            MinuteLB.Text = Math.Round((now - born).TotalMinutes).ToString() + " Minutes";
            SecondLB.Text= Math.Round((now - born).TotalSeconds).ToString() + " Seconds";
            YearLB.Visible = true;
            MonthLB.Visible = true;
            DayLB.Visible=true;
            HourLB.Visible=true;
            MinuteLB.Visible =true;
            SecondLB.Visible=true;
        }
    }
}