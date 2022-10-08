namespace T6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            if(UserIdTB.Text == "Mustafa" && UserPwTB.Text == "admin")
            {
                SignInPanel.Visible = false;
                WelcomePanel.Visible = true;
            }
            else
            {
                InvalidLB.Text = "Invalid ID or PW";
                InvalidLB.Visible = true;
            }
        }
    }
}