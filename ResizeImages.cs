using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// StreamDeck Mini: 216px 144px
// StreamDeck MK2: 360px 216px
// StreamDeck +: 360px 144px
// StreamDeck XL: 768px 384px

namespace StreamDeckify
{
    public partial class ResizeImages : Form
    {
        public Image imageOverlay;
        public Image imageBackground;
        public Image selectedFile;
        public ResizeImages()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        public void browse_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
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

        private void ResizeImages_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}

