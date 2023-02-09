using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting
{
    public class Player
    {
        public Line line;
        public PointF Pos, LookAt; // main lookAt
        public PointF[] looksR, looksL;
        public List<PointF> looks;

        public Player(PointF pos, PointF lookAt)
        {
            this.Pos = pos;
            this.LookAt = lookAt;

            int tot = 150;
            looksR = new PointF[tot];
            looksL = new PointF[tot];
            looks = new List<PointF>();
            line = new Line(pos, lookAt);
            UpdateRotations();
        }

        public void UpdateRotations()
        {
            float val;
            val = .15f;
            looks.Clear();
            looksR[0] = Util.Instance.Rotate(Pos, LookAt, val);
            for (int i = 1; i < looksR.Length; i++)
            {
                looksR[i] = Util.Instance.Rotate(Pos, looksR[i - 1], val);
            }
            looksL[looksL.Length - 1] = Util.Instance.Rotate(Pos, LookAt, -val);
            for (int i = looksL.Length - 1; i > 0; i--)
            {
                looksL[i - 1] = Util.Instance.Rotate(Pos, looksL[i], -val);
            }
            looks.AddRange(looksL);
            looks.AddRange(looksR);
        }
    }
}