using Microsoft.VisualBasic.Devices;

namespace mathsQuizz
{
    public partial class Form1 : Form
    {


        Random randomizer = new Random();

        int addnum1;
        int addnum2;
        int minusnum1;
        int minusnum2;
        int multnum1;
        int multnum2;
        int divnum1;
        int divnum2;

        int clock = 30;

        public void StartQuiz()
        {
            // Addition problem
            addnum1 = randomizer.Next(51);
            addnum2 = randomizer.Next(51);
            plusLeftLabel.Text = addnum1.ToString();
            plusRightLabel.Text = addnum2.ToString();
            sum.Value = 0;

            minusnum1 = randomizer.Next(1, 101);
            minusnum2 = randomizer.Next(1, minusnum1);
            minusLeftLabel.Text = minusnum1.ToString();
            minusRightLabel.Text = minusnum2.ToString();
            diference.Value = 0;


            multnum1 = randomizer.Next(2, 11);
            multnum2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multnum1.ToString();
            timesRightLabel.Text = multnum2.ToString();
            product.Value = 0;

            divnum2 = randomizer.Next(2, 11);
            int tempQuotient = randomizer.Next(2, 11);
            divnum1 = divnum2 * tempQuotient;
            dividedLeftLabel.Text = divnum1.ToString();
            dividedRightLabel.Text = divnum2.ToString();
            quotient.Value = 0;

            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckTheAnswer()
        {
            if ((addnum1 + addnum2 == sum.Value)
                && (minusnum1 - minusnum2 == diference.Value)
                && (multnum1 * multnum2 == product.Value)
                && (divnum1 / divnum2 == quotient.Value))
                return true;
            else
                return false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void stratBtt_Click(object sender, EventArgs e)
        {
            StartQuiz();
            stratBtt.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                clock = clock - 1;
                timeLabel.Text = clock + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addnum1 + addnum2;
                diference.Value = minusnum1 - minusnum2;
                product.Value = multnum1 * multnum2;
                quotient.Value = divnum1 / divnum2;
                stratBtt.Enabled = true;
            }
        }

        private void timaLeft_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
