namespace T14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string journal = File.ReadAllText("C:\\Users\\simsiki\\source\\repos\\KeudaGitRepo2\\T14\\journal.txt");
            journal += JournalTB.Text;
            journal += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\simsiki\\source\\repos\\KeudaGitRepo2\\T14\\journal.txt");
            text.Write(journal);
            text.Close();
            Application.Exit();
        }
    }
}