using System;
using System.Windows.Forms;
using System.Drawing;

namespace notePad
{
    public partial calss Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    private void Form2Load(object sender, EventArgs e)
        {
            this.Text = "About Notepad";
            this.Size = new Size(300, 200);
            Label label = new Label();
            label.Text = "Notepad Application\nVersion 1.0\n© 2024 Your Company";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            this.Controls.Add(label);
    }
}
}
