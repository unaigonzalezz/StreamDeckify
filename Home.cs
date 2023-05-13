using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StreamDeckify
{
    public partial class StreamDeckify : Form
    {
        public StreamDeckify()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            AboutMe settingsForm = new AboutMe();
            settingsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResizeImages resizeForm = new ResizeImages();
            resizeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SplitImages splitForm = new SplitImages();
            splitForm.Show();
        }
    }
}