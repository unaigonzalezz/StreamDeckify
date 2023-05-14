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
            string selectedFile = System.IO.Path.GetFileName(openFileDialog1.FileName); 
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

            string imagePath = openFileDialog1.FileName;

            if (!File.Exists(imagePath))
            {
                Console.WriteLine("La imagen no existe.");
                return;
            }

            // Mostrar el cuadro de diálogo del selector de carpetas
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Seleccione la carpeta de destino:";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("No se seleccionó una carpeta de destino.");
                return;
            }

            string outputDirectory = folderBrowserDialog1.SelectedPath;

            try
            {
                using (var image = new MagickImage(imagePath))
                {
                    // Redimensionar la imagen a 360x216 píxeles
                    image.Resize(360, 216);

                    // Dividir la imagen en 15 GIFs de 72x72 píxeles cada uno
                    int x = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        int y = 0;
                        for (int j = 0; j < 5; j++)
                        {
                            var crop = new MagickGeometry(x, y, 72, 72);
                            using (var croppedImage = image.Clone())
                            {
                                croppedImage.Crop(crop);
                                croppedImage.Write(Path.Combine(outputDirectory, $"boton_{i}_{j}.gif"));
                            }
                            y += 72;
                        }
                        x += 72;
                    }
                }

                Console.WriteLine("La imagen se ha dividido correctamente.");
            }
            catch (MagickException ex)
            {
                Console.WriteLine($"Error al dividir la imagen: {ex.Message}");
            }
        }

        }
    }

