namespace T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string text = MessageTB.Text;
            ResultLB.Text = text;
            ResultLB.Visible = true;
        }

        private void ResultBT_Click(object sender, EventArgs e)
        {
            string text = MessageTB.Text;
            ResultLB.Text = text;
            ResultLB.Visible = true;
        }
    }
}