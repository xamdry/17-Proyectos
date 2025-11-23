using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace images_Upload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my_images);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_images.Image_Uploads' table. You can move, or remove it, as needed.
            this.image_UploadsTableAdapter.Fill(this.my_images.Image_Uploads);

        }

        private void imgpathLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            DialogResult dr = openFd.ShowDialog();
            imgPictureBox.Image = Image.FromFile(openFd.FileName);
            imgpathLabel1.Text = openFd.FileName;
        }
    }
}
