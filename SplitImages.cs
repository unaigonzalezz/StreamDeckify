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
                // liberas los recursos de la capa de superposición
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
    }
}
