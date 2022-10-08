namespace T5
{
    public partial class Form1 : Form
    {
        List<int> line = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void NewNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (NewNoTB.Text == "-999")
                {
                    ResultLB.Text = "";
                    int[] table = line.ToArray();
                    Array.Sort(table);
                    foreach(var member in table)
                    {
                        ResultLB.Text += member + " ";
                    }
                    ResultLB.Visible = true;
                }
                else
                {
                    line.Add(Int32.Parse(NewNoTB.Text));
                    NewNoTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                ClearForm();
            }
        }
        private void ClearForm()
        {
            NewNoTB.Text = "";
        }
    }
}