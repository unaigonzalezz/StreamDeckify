using System.Windows.Forms;

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
            MessageBox.Show("Funciona! :)");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}