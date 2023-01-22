using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {

        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Función para Rotar el cuadrado usando Sin y Cos Botón 1
        private Point RotatePoint(Point point, Point centro, double anguloRadianes)
        {
            // Math.Cos para usar Cos y Sin en C#
            double x = (Math.Cos(anguloRadianes) * (point.X - centro.X)) + (Math.Sin(anguloRadianes) * (point.Y - centro.Y)) + centro.X;
            double y = -(Math.Sin(anguloRadianes) * (point.X - centro.X)) + (Math.Cos(anguloRadianes) * (point.Y - centro.Y)) + centro.Y;

            // Se regresa el nuevo valor del punto
            return new Point((int)x, (int)y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear el ángulo de rotación, double por que se usa sin y cos
            double angulo = double.Parse(textBox1.Text);

            // Convertir el ángulo a radianes por que al parecer C# le gustan más los radianes, double por que se usa sin y cos
            double anguloRadianes = (Math.PI / 180) * angulo; 
 
            float hHeight = pictureBox1.Height / 2f;
            float hWidth = pictureBox1.Width / 2f;

            // Definir el centro del cuadrado
            Point centro = new Point((int)hWidth, (int)hHeight); 

            // Para borrar el cuadrado anterior: Se rellena todo el canvas de nuevo pero le da la ilusión de que se borró el cuadrado :)
            g.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Para dibujar las líneas amarillas que dan la referencia al origen
            g.DrawLine(Pens.Yellow, new Point(0, (int)centro.Y), new Point(pictureBox1.Width, (int)centro.Y));
            g.DrawLine(Pens.Yellow, new Point((int)centro.X, 0), new Point((int)centro.X, pictureBox1.Height));

            // Calcular el nuevo valor de las coordenadas para el cuadrado
            Point lineaRoja1 = RotatePoint(new Point((int)hWidth, (int)hHeight), centro, anguloRadianes); 
            Point lineaRoja2 = RotatePoint(new Point((int)(hWidth + 100), (int)hHeight), centro, anguloRadianes);
            Point lineaBlanca1 = RotatePoint(new Point((int)hWidth + 100, (int)hHeight), centro, anguloRadianes);
            Point lineaBlanca2 = RotatePoint(new Point((int)(hWidth + 100), (int)hHeight - 100), centro, anguloRadianes);
            Point lineaRoja3 = RotatePoint(new Point((int)hWidth, (int)hHeight), centro, anguloRadianes);
            Point lineaRoja4 = RotatePoint(new Point((int)(hWidth), (int)(hHeight - 100)), centro, anguloRadianes);
            Point lineaRoja5 = RotatePoint(new Point((int)hWidth, (int)(hHeight - 100)), centro, anguloRadianes);
            Point lineaRoja6 = RotatePoint(new Point((int)(hWidth + 100), (int)(hHeight - 100)), centro, anguloRadianes);

            // Dibujar el cuadrado en las nuevas coordenadas
            g.DrawLine(Pens.Red, lineaRoja1, lineaRoja2);
            g.DrawLine(Pens.White, lineaBlanca1, lineaBlanca2);
            g.DrawLine(Pens.Red, lineaRoja3, lineaRoja4);
            g.DrawLine(Pens.White, lineaRoja5, lineaRoja6);

            pictureBox1.Refresh();
        }

        // Función para Rotar el cuadrado usando Sin y Cos Botón 2
        private Point RotateSquare(Point point, Point centro, double anguloRadianes)
        {
            // Math. para usar Cos y Sin en C#
            double x = (Math.Cos(anguloRadianes) * (point.X - centro.X)) + (Math.Sin(anguloRadianes) * (point.Y - centro.Y)) + centro.X;
            double y = -(Math.Sin(anguloRadianes) * (point.X - centro.X)) + (Math.Cos(anguloRadianes) * (point.Y - centro.Y)) + centro.Y;

            // Se regresa el nuevo valor del punto, en este caso hay que restar y sumar para que el cuadrado no se mueva del centro
            return new Point((int)(x + centro.X - centro.X), (int)(y + centro.Y - centro.Y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point centro = new Point((int)(pictureBox1.Width / 2), (int)(pictureBox1.Height / 2));

            // Crear el ángulo de rotación, double por que se usa sin y cos
            double angulo = double.Parse(textBox1.Text);

            // Convertir el ángulo a radianes por que al parecer C# le gustan más los radianes, double por que se usa sin y cos
            double anguloRadianes = (Math.PI / 180) * angulo;

            // Para borrar el cuadrado anterior: Se rellena todo el canvas de nuevo pero le da la ilusión de que se borró el cuadrado :)
            g.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Para dibujar las líneas amarillas que dan la referencia al origen
            g.DrawLine(Pens.Yellow, new Point(0, (int)centro.Y), new Point(pictureBox1.Width, (int)centro.Y));
            g.DrawLine(Pens.Yellow, new Point((int)centro.X, 0), new Point((int)centro.X, pictureBox1.Height));

            // Calcular el nuevo valor de las coordenadas para el cuadrado, ya no es con 100 porque el cuadrado se queda en el lugar
            Point line1 = RotateSquare(new Point((int)centro.X - 50, (int)centro.Y - 50), centro, anguloRadianes);
            Point line2 = RotateSquare(new Point((int)(centro.X + 50), (int)centro.Y - 50), centro, anguloRadianes);
            Point line3 = RotateSquare(new Point((int)centro.X + 50, (int)(centro.Y + 50)), centro, anguloRadianes);
            Point line4 = RotateSquare(new Point((int)(centro.X - 50), (int)(centro.Y + 50)), centro, anguloRadianes);

            // Dibujar el cuadrado en las nuevas coordenadas
            g.DrawLine(Pens.White, line1, line2);
            g.DrawLine(Pens.White, line2, line3);
            g.DrawLine(Pens.Red, line3, line4);
            g.DrawLine(Pens.Red, line4, line1);

            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}