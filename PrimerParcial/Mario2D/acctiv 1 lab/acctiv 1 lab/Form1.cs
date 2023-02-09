using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acctiv_1_lab
{
    public partial class MAIN_FORM : Form

    {
        //global
        int motion1 = 2;
        int motion2 = 4;
        int motion3 = 8;
        //int motion4 = 16;

        int width = 688;

        int l1_X1, l1_X2, l2_X1, l2_X2, l3_X1, l3_X2;

        Bitmap layer0, layer1, layer2, layer3;
        bool right, hold = true;

        static Graphics g;

        public MAIN_FORM()
        {
            InitializeComponent();

            layer0 = Resource1.L1_1_;
            layer1 = Resource1.L1_1_;
            layer2 = Resource1.L2_1_;
            layer3 = Resource1.L3_1_;

            l1_X1 = l2_X1 = l3_X1 = 0;
            l1_X2 = l2_X2 = l3_X2 = width;

            player.Image = Resource1.Mhold;
        }

        private void TIMER_tick(object sender, EventArgs e)
        {
            if (right)
                BackgroundMove();
        }

        private void MAIN_FORM_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyData == Keys.Right & hold)
            {
                right = true;
                hold = false;
                player.Image = Resource1.running_1_;
            }
        }

        private void MAIN_FORM_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.KeyData == Keys.Right & !hold)
            {
                right = false;
                hold = true;
                player.Image = Resource1.Mhold;
            }
        }

        private void MAIN_FORM_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImage(layer0, 0, 0, layer1.Width, this.Height - 50);

            g.DrawImage(layer1, l1_X1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer1, l1_X2, 0, layer1.Width, this.Height - 50);

            g.DrawImage(layer2, l2_X1, 0, layer1.Width, this.Height - 150);
            g.DrawImage(layer2, l2_X2, 0, layer1.Width, this.Height - 150);

            g.DrawImage(layer3, l3_X1, 0, layer1.Width, this.Height - 50);
            g.DrawImage(layer3, l3_X2, 0, layer1.Width, this.Height - 50);


        }

        private void BackgroundMove()
        {
            //agarra una imagen y la pega a si misma para que se repita (como cilindro)

            if (l1_X1 < -width) { l1_X1 = width - motion1; }
            l1_X1 -= motion1; l1_X2 -= motion1;
            if (l1_X2 <-width) { l1_X2 = width- motion1; }

            if (l2_X1 < -width) { l2_X1 = width - motion1; }
            l2_X1 -= motion2; l2_X2 -= motion2;
            if (l2_X2 < -width) { l2_X2 = width - motion2; }

            if (l3_X1 < -width) { l3_X1 = width - motion3; }
            l3_X1 -= motion3; l3_X2 -= motion3;
            if (l3_X2 < -width) { l3_X2 = width - motion3; }

            Invalidate();
        }
    }
}
