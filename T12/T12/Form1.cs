namespace T12
{
    public partial class Form1 : Form
    {
        string[] answers = new string[10];
        string[] rightAnswers = new string[] { "A", "B", "B", "C", "C", "C", "D", "D", "D", "D" };
        int questions = 0;
        int correctAnswers = 0;
        public Form1()
        {
            InitializeComponent();
            aRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            bRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            cRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            dRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (sender is RadioButton && questions < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                answers[questions] = radioButton.Text;
                questions++;
                qLB.Text = "Question " + (questions);

            }
            else
            {
                aLB.Text = "";
                aRB.Enabled = false;
                bRB.Enabled = false;
                cRB.Enabled = false;
                dRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (answers[j] == rightAnswers[j])
                    {
                        correctAnswers++;
                    }
                }
                aLB.Text = correctAnswers + "/10 Correct!";
                aLB.Visible = true;
            }
            ClearAnswers();
        }
        private void ClearAnswers()
        {
            if (aRB.Checked == true)
            {
                aRB.Checked = false;
                questions--;
            }
            if (bRB.Checked == true)
            {
                bRB.Checked = false;
                questions--;
            }
            if (cRB.Checked == true)
            {
                cRB.Checked = false;
                questions--;
            }
            if (dRB.Checked == true)
            {
                dRB.Checked = false;
                questions--;
            }
        }
    }
}