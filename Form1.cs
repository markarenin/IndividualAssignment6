namespace IndividualAssignment6
{
    public partial class Form1 : Form
    {
        public int computer_choice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void start_game()
        {
            computer_choice = new Random().Next(1, 3);
        }

        public void check(int user_choid)
        {
            String text;
            if (user_choid == 1 && computer_choice == 2)
            {
                text = "Computer choise: Scissors\nUser choise: Rock\nRock smashes scissors\nYou won";
            } else if (user_choid == 2 && computer_choice == 3)
            {
                text = "Computer choise: Paper\nUser choise: Scissors\nScissors cuts paper\nYou won";
            } else if (user_choid == 3 && computer_choice == 1)
            {
                text = "Computer choise: Rock\nUser choise: Paper\nPaper wraps rock\nYou won";
            } else if (computer_choice == 1 && user_choid == 2)
            {
                text = "Computer choise: Rock\nUser choise: Scissors\nRock smashes scissors\nThe computer won";
            }
            else if (computer_choice == 2 && user_choid == 3)
            {
                text = "Computer choise: Scissors\nUser choise: Paper\nScissors cuts paper\nThe computer won";
            } else if (computer_choice == 3 && user_choid == 1)
            {
                text = "Computer choise: Paper\nUser choise: Rock\nPaper wraps rock\nThe computer won";
            } else {
                switch (user_choid)
                {
                    case 1:
                        text = "Computer and User selected: Rock\n You have to play again";
                        break;
                    case 2:
                        text = "Computer and User selected: Scissors\n You have to play again";
                        break;
                    case 3:
                        text = "Computer and User selected: Paper\n You have to play again";
                        break;
                    default:
                        text = "";
                        break;
                }
            }
            MessageBox.Show(text);
            start_game();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int choise = Convert.ToInt32(btn.Tag);
            check(choise);
        }
    }
}