using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.Drawing.Imaging;

namespace StreamDeckify
{
    public partial class SplitImages : Form
    {
        public Image imageOverlay;
        public Image imageBackground;
        public Image selectedFile;
        public SplitImages()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.Title = "Open image";
            string selectedFile = System.IO.Path.GetFileName(openFileDialog1.FileName); ;
            label4.Text = selectedFile;

            int streamWidth = 310;
            int streamHeight = 185;
            int streamGap1 = 30;
            int streamGap2 = 30;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckMini.png");
                    streamWidth = 250;
                    streamHeight = 175;
                    streamGap1 = 60;
                    streamGap2 = 75;

                    break;
                case 1:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeck.png");
                    streamWidth = 330;
                    streamHeight = 175;
                    streamGap1 = 30;
                    streamGap2 = 55;
                    break;
                case 2:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckPlus.png");
                    streamWidth = 240;
                    streamHeight = 170;
                    streamGap1 = 65;
                    streamGap2 = 30;
                    break;
                case 3:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckXL.png");
                    streamWidth = 330;
                    streamHeight = 175;
                    streamGap1 = 30;
                    streamGap2 = 45;
                    break;

            }


            Image imageBackground = Image.FromFile(openFileDialog1.FileName);


            int overlayX = imageBackground.Width; // la posición X de la capa de superposición en la imagen final
            int overlayY = imageBackground.Height; // la posición Y de la capa de superposición en la imagen final

            Image img = new Bitmap(380, 273); // creas la imagen final con el tamaño de la capa de superposición
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(imageBackground, streamGap1, streamGap2, streamWidth, streamHeight);// dibujas la imagen de fondo en la posición correcta según la capa de superposición
                gr.DrawImage(imageOverlay, 0, 0, 380, 273); // dibujas la capa de superposición en la posición (0, 0)
                gr.Flush(); // para asegurarte de que los cambios se han aplicado correctamente
                imageOverlay.Dispose(); // liberas los recursos de la capa de superposición
            }
            pictureBox3.Image = img;
            pictureBox3.Refresh();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image imageOverlay;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckMini.png");
                    pictureBox3.Image = imageOverlay;
                    pictureBox3.Refresh();
                    break;
                case 1:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeck.png");
                    pictureBox3.Image = imageOverlay;
                    pictureBox3.Refresh();
                    break;
                case 2:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckPlus.png");
                    pictureBox3.Image = imageOverlay;
                    pictureBox3.Refresh();
                    break;
                case 3:
                    imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeckXL.png");
                    pictureBox3.Image = imageOverlay;
                    pictureBox3.Refresh();
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int streamWidth = 0;
            int streamHeight = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0: // StreamDeck Mini: 216px 144px
                    streamWidth = 216;
                    streamHeight = 144;
                    break;
                case 1: // StreamDeck MK2: 360px 216px
                    streamWidth = 360;
                    streamHeight = 216;
                    break;
                case 2: // StreamDeck +: 360px 144px
                    streamWidth = 360;
                    streamHeight = 144;
                    break;
                case 3: // StreamDeck XL: 768px 384px
                    streamWidth = 768;
                    streamHeight = 384;
                    break;

            }


   
            string gifPath = openFileDialog1.FileName;
            Image gifImage = Image.FromFile(gifPath);
            FrameDimension dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            int framesCount = gifImage.GetFrameCount(dimension);

            // Itera por cada fotograma del GIF
            for (int frameIndex = 0; frameIndex < framesCount; frameIndex++)
            {
                // Selecciona el fotograma actual
                gifImage.SelectActiveFrame(dimension, frameIndex);

                // Divide el fotograma en 15 partes de 72 pixeles cada una
                int partWidth = 72;
                int partHeight = gifImage.Height;
                int x = 0;
                int y = 0;
                for (int partIndex = 0; partIndex < 15; partIndex++)
                {
                    // Crea un nuevo bitmap para la parte actual
                    Bitmap partBitmap = new Bitmap(partWidth, partHeight);

                    // Copia los pixeles correspondientes a la parte actual
                    for (int i = 0; i < partWidth; i++)
                    {
                        for (int j = 0; j < partHeight; j++)
                        {
                            Color pixelColor = ((Bitmap)gifImage).GetPixel(x + i, y + j);
                            partBitmap.SetPixel(i, j, pixelColor);
                        }
                    }

                    // Guarda la parte actual como un GIF independiente
                    string partPath = $"{gifPath}_part{partIndex + 1}_frame{frameIndex + 1}.gif";
                    partBitmap.Save(partPath, ImageFormat.Gif);

                    // Incrementa la posición horizontal para la siguiente parte
                    x += partWidth;
                }

                // Reinicia la posición horizontal y incrementa la posición vertical para la siguiente fila de partes
                x = 0;
                y += partHeight;
            }


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            saveFileDialog1.Title = "Guardar imagen";
            string selectedFile = System.IO.Path.GetFileName(saveFileDialog1.FileName); ;

            // Check if the OpenFileDialog has a file name
            if (openFileDialog1.FileName != "")
            {
                // Set the initial directory and file name for the SaveFileDialog
                saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }

            // Show the SaveFileDialog to the user
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Redimensiona la imagen original
                Image imagenOriginal = Image.FromFile(openFileDialog1.FileName);
                Image imagenRedimensionada = imagenOriginal.GetThumbnailImage(streamWidth, streamHeight, null, IntPtr.Zero);
                imagenRedimensionada.Save(saveFileDialog1.FileName);
                label6.Text = "Done! Your new wallwaper is on: \n" + saveFileDialog1.FileName;
            }
        }
    }
}
