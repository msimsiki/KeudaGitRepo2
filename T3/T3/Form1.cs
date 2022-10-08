namespace T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            try
            {
                float n1 = float.Parse(NOneTB.Text);
                float n2 = float.Parse(NTwoTB.Text);
                float answer = 0;
                string mark = CalcCB.Text;
                switch (mark)
                {
                    case "+":
                        answer = n1 + n2;
                        break;
                    case "-":
                        answer = n1 - n2;
                        break;
                    case "*":
                        answer = n1 * n2;
                        break;
                    case "/":
                        answer = n1 / n2;
                        break;
                }
                AnswerLB.Text = answer.ToString();
                AnswerLB.Visible = true;
            }
            catch
            {
                AnswerLB.Text = "Error!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CalcBT_Click(object sender, EventArgs e)
        {
            try
            {
                float n1 = float.Parse(NOneTB.Text);
                float n2 = float.Parse(NTwoTB.Text);
                float answer = 0;
                string mark = CalcCB.Text;
                switch (mark)
                {
                    case "+":
                        answer = n1 + n2;
                        break;
                    case "-":
                        answer = n1 - n2;
                        break;
                    case "*":
                        answer = n1 * n2;
                        break;
                    case "/":
                        answer = n1 / n2;
                        break;
                }
                AnswerLB.Text = answer.ToString();
                AnswerLB.Visible = true;
            }
            catch
            {
                AnswerLB.Text = "Error!";
            }
        }
    }
}