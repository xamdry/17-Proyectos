namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player1.URL = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player1.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor ingresa una URL de YouTube o streaming",
                    "URL requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir URLs de YouTube al formato compatible con WMP
            if (url.Contains("youtube.com") || url.Contains("youtu.be"))
            {
                MessageBox.Show("Para YouTube, usa el formato: https://www.youtube.com/watch?v=VIDEO_ID\n\n" +
                    "Nota: Windows Media Player tiene soporte limitado para YouTube.\n" +
                    "Considera usar URLs directas de archivos de audio (MP3, WAV, etc.) o streaming.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                Player1.URL = url;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la URL: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
