namespace ScreenSaver
{
    public partial class FScreenSaer : Form
    {

        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }
        public FScreenSaer()
        {
            InitializeComponent();
        }

        private void FScreenSaer_KeyUp(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void FScreenSaer_Load(object sender, EventArgs e)
        {
            //enlista todas las imagenes en la carpeta Pics
            string[] images = System.IO.Directory.GetFiles("Pics");
            //loop para crear una instancia de Bitmap por cada imagen
            foreach (string img in images)
            {
                //crear instancia de Bitmap 
                BGImages.Add(new Bitmap(img));
            }
            //busca por cada item en la lista BGImages si es menos a 50 agrega una nueva instancia de BritPic a la lista BritPics hasta tener 50
            for (int i = 0; i < 100; ++i)
            {
                BritPic mp = new BritPic();
                //asigna un numero de imagen aleatorio 
                mp.PicNum = i % BGImages.Count;
                //asigna una posicion aleatoria 
                mp.X = rand.Next(0, this.Width);
                mp.Y = rand.Next(0, this.Height);
                //mp.Speed = rand.Next(100, 300) / 100.0f;
                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void FScreenSaer_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            //dibuja la imagen en la posicion X y Y
            {
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);
                bp.X -= 2;
                //si la imagen sale de la pantalla por la izquierda, la reposiciona a la derecha
                if (bp.X < -250)
                {
                    bp.X = Width + rand.Next(20, 100);
                }
            }
        }
    }
}
