using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDeckify
{
    public partial class ResizeImages : Form
    {
        private Image imageBackground;
        private Image selectedFile;
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

        public void browse_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.Title = "Open image";
            string selectedFile = System.IO.Path.GetFileName(openFileDialog1.FileName); ;
            label4.Text = selectedFile;



            Image imageBackground = Image.FromFile(openFileDialog1.FileName);
            Image imageOverlay = Image.FromFile("C:\\Users\\unaii\\Desktop\\StreamDeckify\\StreamDeck.png");

            int overlayX = imageBackground.Width; // la posición X de la capa de superposición en la imagen final
            int overlayY = imageBackground.Height; // la posición Y de la capa de superposición en la imagen final

            Image img = new Bitmap(380, 273); // creas la imagen final con el tamaño de la capa de superposición
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(imageBackground, 30, 30, 310, 200);// dibujas la imagen de fondo en la posición correcta según la capa de superposición
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

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            saveFileDialog1.Title = "Guardar imagen";
            string selectedFile = System.IO.Path.GetFileName(openFileDialog1.FileName); ;
            label6.Text = "Done! Your new wallwaper is on: \n" + openFileDialog1.FileName;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = new FileStream(selectedFile, FileMode.Create))
                {
                    imageBackground.Save(stream, ImageFormat.Jpeg);
                }
                MessageBox.Show("Imagen guardada correctamente.");
            }
        }

        private void ResizeImages_Load(object sender, EventArgs e)
        {

        }
    }
}

