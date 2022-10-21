namespace T11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RollBT_Click(object sender, EventArgs e)
        {
            drawDice(Dice1PB);
            drawDice(Dice2PB);
        }
        private void drawDice(PictureBox DiceBox)
        {
            Random chance = new Random();
            int dice = chance.Next(1, 7);
            switch (dice)
            {
                case 1:
                    DiceBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    DiceBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    DiceBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    DiceBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    DiceBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    DiceBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}