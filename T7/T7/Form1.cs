namespace T7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double loan, liquid, insurance, other, fuel, wash, maintenance, tires, km, costs;
            loan = Convert.ToDouble(LoanTB.Text);
            liquid = Convert.ToDouble(LiquidTB.Text);
            insurance = Convert.ToDouble(InsuranceTB.Text);
            other = Convert.ToDouble(OtherTB.Text);
            fuel = Convert.ToDouble(FuelTB.Text);
            wash = Convert.ToDouble(WashTB.Text);
            maintenance = Convert.ToDouble(MaintenanceTB.Text);
            tires = Convert.ToDouble(TiresTB.Text);
            km = Convert.ToDouble(KmCB.Text);
            costs = (loan + liquid + insurance + other + fuel + wash + maintenance + tires) / (km / 12);
            ResultLB.Text = "Cost per km: " + costs;
            ResultLB.Visible = true;
        }
    }
}