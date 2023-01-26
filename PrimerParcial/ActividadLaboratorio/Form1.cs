using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadLaboratorio
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g; 

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(250, 250);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            DrawMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawMap()
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            for (int x = 0; x < Mapa.map0.GetLength(0); x++)
            {
                for (int y = 0; y < Mapa.map0.GetLength(1); y++)
                {
                    if (Mapa.map0[y, x] != 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(139, 0, 0)), x * 10, y * 10, 10, 10);
                    }
                    if (Mapa.map0[y, x] == 8)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(50, 150, 200)), x * 10, y * 10, 10, 10);
                    }
                    if (Mapa.map0[y, x] == 9)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(13, 181, 13)), x * 10, y * 10, 10, 10);
                    }
                    else
                    {
                        g.DrawRectangle(Pens.Gray, x * 10, y * 10, 10, 10);
                    }
                        
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
