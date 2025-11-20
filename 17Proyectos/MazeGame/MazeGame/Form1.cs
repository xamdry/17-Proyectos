namespace MazeGame
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer player;
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundMusic();
            MoveToStart();
        }
        private void InitializeBackgroundMusic()
        {
            player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Musica\7Rings.mp3";
            player.settings.setMode("loop", true); // Loop infinito
            player.settings.volume = 50; // Volumen al 50%
            player.controls.play();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            player.controls.stop();
            MessageBox.Show("Congratulations! You completed the maze!");
            Close();
        }
        private void MoveToStart()
        {
            // Move the cursor back to the start label
            Point startPoint = panel1.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
