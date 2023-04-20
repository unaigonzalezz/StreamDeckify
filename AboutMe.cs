using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDeckify
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();

            //Custom font Montserrat 
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Montserrat.Length;
            byte[] fontdata = Properties.Resources.Montserrat;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(33, 164, 241);
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://unaigonzalez.es/",
                UseShellExecute = true
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }
    }
}
