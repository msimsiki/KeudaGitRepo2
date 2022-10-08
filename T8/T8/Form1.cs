namespace T8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBT_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            string answer = "";
            if(NoTB.Text.Length > 3)
            {
                n1 = Convert.ToInt32(NoTB.Text.Substring(0, 1));
                n2 = Convert.ToInt32(NoTB.Text.Substring(1, 1));
                n3 = Convert.ToInt32(NoTB.Text.Substring(2, 1));
                n4 = Convert.ToInt32(NoTB.Text.Substring(3, 1));
                if(n1 % 3 == 0)
                {
                    answer += "MMM";
                }
                else if(n1 % 2 == 0)
                {
                    answer += "MM";
                }
                else if (n1 % 1 == 0)
                {
                    answer += "M";
                }
                else
                {
                    answer += "";
                }
                answer += hundreds(n2, answer);
                answer += tens(n3, answer);
                answer += ones(n4, answer);
            }
            else if(NoTB.Text.Length > 2)
            {
                n2 = Convert.ToInt32(NoTB.Text.Substring(0, 1));
                n3 = Convert.ToInt32(NoTB.Text.Substring(1, 1));
                n4 = Convert.ToInt32(NoTB.Text.Substring(2, 1));
                answer += hundreds(n2, answer);
                answer += tens(n3, answer);
                answer += ones(n4, answer);
            }
            else if (NoTB.Text.Length > 1)
            {
                n3 = Convert.ToInt32(NoTB.Text.Substring(0, 1));
                n4 = Convert.ToInt32(NoTB.Text.Substring(1, 1));
                answer += tens(n3, answer);
                answer += ones(n4, answer);
            }
            else if (NoTB.Text.Length > 0)
            {
                n4 = Convert.ToInt32(NoTB.Text.Substring(0, 1));
                answer += ones(n4, answer);
            }
            ResultLB.Text = answer;
            ResultLB.Visible = true;
        }
        private string hundreds(int n2, string answer)
        {
            if(n2 % 9 == 0 && n2 != 0)
            {
                return "CM";
            }
            else if (n2 % 8 == 0 && n2 != 0)
            {
                return "DCCC";
            }
            else if (n2 % 7 == 0 && n2 != 0)
            {
                return "DCC";
            }
            else if (n2 % 6 == 0 && n2 != 0)
            {
                return "DC";
            }
            else if (n2 % 5 == 0 && n2 != 0)
            {
                return "D";
            }
            else if (n2 % 4 == 0 && n2 != 0)
            {
                return "CD";
            }
            else if (n2 % 3 == 0 && n2 != 0)
            {
                return "CCC";
            }
            else if (n2 % 2 == 0 && n2 != 0)
            {
                return "CC";
            }
            else if (n2 % 1 == 0 && n2 != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }
        private string tens(int n3, string answer)
        {
            if (n3 % 9 == 0 && n3 != 0)
            {
                return "XC";
            }
            else if (n3 % 8 == 0 && n3 != 0)
            {
                return "LXXX";
            }
            else if (n3 % 7 == 0 && n3 != 0)
            {
                return "LXX";
            }
            else if (n3 % 6 == 0 && n3 != 0)
            {
                return "LX";
            }
            else if (n3 % 5 == 0 && n3 != 0)
            {
                return "L";
            }
            else if (n3 % 4 == 0 && n3 != 0)
            {
                return "XL";
            }
            else if (n3 % 3 == 0 && n3 != 0)
            {
                return "XXX";
            }
            else if (n3 % 2 == 0 && n3 != 0)
            {
                return "XX";
            }
            else if (n3 % 1 == 0 && n3 != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
        private string ones(int n4, string answer)
        {
            if (n4 % 9 == 0 && n4 != 0)
            {
                return "IX";
            }
            else if (n4 % 8 == 0 && n4 != 0)
            {
                return "VIII";
            }
            else if (n4 % 7 == 0 && n4 != 0)
            {
                return "VII";
            }
            else if (n4 % 6 == 0 && n4 != 0)
            {
                return "VI";
            }
            else if (n4 % 5 == 0 && n4 != 0)
            {
                return "V";
            }
            else if (n4 % 4 == 0 && n4 != 0)
            {
                return "IV";
            }
            else if (n4 % 3 == 0 && n4 != 0)
            {
                return "III";
            }
            else if (n4 % 2 == 0 && n4 != 0)
            {
                return "II";
            }
            else if (n4 % 1 == 0 && n4 != 0)
            {
                return "I";
            }
            else
            {
                return "";
            }
        }
    }
}