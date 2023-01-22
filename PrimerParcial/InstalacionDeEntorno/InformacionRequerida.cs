using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalacionDeEntorno
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(TextBox.Text);
            PictureBox.Image = bmp;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(bmp).DrawLine(Pens.Yellow, 0, 0, 150, 150);
            PictureBox.Refresh();
        }
    }
}