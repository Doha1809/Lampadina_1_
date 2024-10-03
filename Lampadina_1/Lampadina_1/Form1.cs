using System.Drawing;


namespace Lampadina_1
{
    public partial class Form1 : Form
    {
        private Image originalImage; // Variabile per salvare l'immagine originale
        private int movementstep = 30;
        public Form1()
        {
            InitializeComponent();
            originalImage = pictureBox1.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //bitmap è una variabile di tipo Bitmap(una classe) che serve per contenree l'immagine con permessi di accesso e di modifica 
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                ChangeImageColor(bitmap, Color.Yellow); // Cambia il colore con il colore desiderato
                pictureBox1.Image = bitmap;
            }
        }

        private void ChangeImageColor(Bitmap bitmap, Color newColor)
        {
            for (int x = 0; x < bitmap.Width - 115; x++)
            {
                for (int y = 0; y < bitmap.Height - 115; y++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    // Cambia il colore del pixel
                    if (originalColor.A > 0) // Solo per i pixel visibili
                    {
                        bitmap.SetPixel(x, y, newColor);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = movementstep;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = movementstep;
        }
    }
}

