using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase_20_febrero
{
   
    public class Canvas
    {
        public Bitmap bitmap;
        public float Width, Height;
        public byte[] bits;
        Graphics g;
        int pixelFormatSize, stride;
        public Canvas(Size size)
        {
            Init(size.Width, size.Height);
        }

        public void DrawPixel(int x, int y, Color c)
        {
            int res = (int)((x * pixelFormatSize) + (y * stride));

            bits[res + 0] = c.B;// (byte)Blue;
            bits[res + 1] = c.G;// (byte)Green;
            bits[res + 2] = c.R;// (byte)Red;
            bits[res + 3] = c.A;// (byte)Alpha;
        }

        private void Init(int width, int height)
        {
            PixelFormat format;
            GCHandle handle;
            IntPtr bitPtr;
            int padding;

            format = PixelFormat.Format32bppArgb;
            Width = width;
            Height = height;
            pixelFormatSize = Image.GetPixelFormatSize(format) / 8; //8 bits = 1 byte
            stride = width * pixelFormatSize;                       //total pixels (width) times ARGB(4)
            padding = (stride % 4);                                 //PADD = move every pixel in bytes
            stride  += padding == 0 ? 0 : 4 - padding;              //4 byte multiple Alpha, Red, Green Blue
            bits = new byte[stride * height];                       //total 
            handle = GCHandle.Alloc(bits, GCHandleType.Pinned);
            bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bits, 0);
            bitmap = new Bitmap(width, height, stride, format, bitPtr);

            g = Graphics.FromImage(bitmap);
            
        }

        public void FastClear()
        {
            unsafe
            {
                BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(bitmap.PixelFormat) / 8;
                int heightIntPixels = bitmap.Height;
                int widthInBytes = bitmap.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0,heightIntPixels, y =>
                {
                    byte* bits = PtrFirstPixel + (y * bitmapData.Stride);
                    for(int x =0; x < widthInBytes; x = x+ bytesPerPixel)
                    {
                        bits[x + 0] = 0;
                        bits[x + 1] = 0;
                        bits[x + 2] = 0;
                        bits[x + 3] = 0;
                    }
                });
                bitmap.UnlockBits(bitmapData);

            }
        }

        public void DrawLine(Point p1, Point p2, Color c)
        {
            g.DrawLine(new Pen(c), p1,p2);
        }

    }
}
