namespace digitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hourMinute_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinute.Text = DateTime.Now.ToString("HH:mm");
            secondsL.Text = DateTime.Now.ToString("ss");
            dayL.Text = DateTime.Now.ToString("MMM dd yyyy");
            weekL.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
