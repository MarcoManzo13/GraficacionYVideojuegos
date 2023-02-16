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

        // Función para Rotar el cuadrado usando Sin y Cos (Botón 1 y 3)
        private Point RotatePoint(Point point, Point centro, double anguloRadianes)
        {
            // Math.Cos para usar Cos y Sin en C#
            double x = (Math.Cos(anguloRadianes) * (point.X - centro.X)) + (Math.Sin(anguloRadianes) * (point.Y - centro.Y)) + centro.X;
            double y = -(Math.Sin(anguloRadianes) * (point.X - centro.X)) + (Math.Cos(anguloRadianes) * (point.Y - centro.Y)) + centro.Y;

            // Se regresa el nuevo valor del punto
            return new Point((int)x, (int)y);
        }

        // Función para Rotar el cuadrado usando Sin y Cos (Botón 2)
        private Point RotateSquare(Point point, Point centro, double anguloRadianes)
        {
            // Math. para usar Cos y Sin en C#
            double x = (Math.Cos(anguloRadianes) * (point.X - centro.X)) + (Math.Sin(anguloRadianes) * (point.Y - centro.Y)) + centro.X;
            double y = -(Math.Sin(anguloRadianes) * (point.X - centro.X)) + (Math.Cos(anguloRadianes) * (point.Y - centro.Y)) + centro.Y;

            // Se regresa el nuevo valor del punto, en este caso hay que restar y sumar para que el cuadrado no se mueva del centro
            return new Point((int)(x + centro.X - centro.X), (int)(y + centro.Y - centro.Y));
        }

        // Botón que toma el ángulo proporcionado por un texto y crea y rota un cuadrado teniendo como pivote el origen 0,0 en el centro de la pantalla.
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear el ángulo de rotación, double por que se usa sin y cos y PI
            double angulo = double.Parse(textBox1.Text);

            // Convertir el ángulo a radianes por que al parecer C# le gustan más los radianes, double por que se usa sin y cos y PI
            double anguloRadianes = (Math.PI / 180) * angulo;

            // Calcular la mitad del pcitureBox1
            float hHeight = pictureBox1.Height / 2f;
            float hWidth = pictureBox1.Width / 2f;

            // Definir el centro del cuadrado
            Point centro = new Point((int)hWidth, (int)hHeight); 

            // Para borrar el cuadrado anterior: Se rellena todo el canvas de nuevo pero le da la ilusión de que se borró el cuadrado :)
            g.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Para dibujar las líneas amarillas que dan la referencia al origen (Descubrí que se pueden crear los puntos dentro del DrawLine)
            g.DrawLine(Pens.Yellow, new Point(0, (int)hHeight), new Point(pictureBox1.Width, (int)hHeight));
            g.DrawLine(Pens.Yellow, new Point((int)hWidth, 0), new Point((int)hWidth, pictureBox1.Height));

            // Calcular el nuevo valor de las coordenadas para los puntos del cuadrado
            Point lineaRoja1 = RotatePoint(new Point((int)hWidth, (int)hHeight), centro, anguloRadianes); 
            Point lineaRoja2 = RotatePoint(new Point((int)(hWidth + 100), (int)hHeight), centro, anguloRadianes);

            Point lineaRoja3 = RotatePoint(new Point((int)hWidth, (int)hHeight), centro, anguloRadianes);
            Point lineaRoja4 = RotatePoint(new Point((int)(hWidth), (int)(hHeight - 100)), centro, anguloRadianes);

            Point lineaBlanca1 = RotatePoint(new Point((int)hWidth + 100, (int)hHeight), centro, anguloRadianes);
            Point lineaBlanca2 = RotatePoint(new Point((int)(hWidth + 100), (int)hHeight - 100), centro, anguloRadianes);

            Point lineaBlanca3 = RotatePoint(new Point((int)hWidth, (int)(hHeight - 100)), centro, anguloRadianes);
            Point lineaBlanca4 = RotatePoint(new Point((int)(hWidth + 100), (int)(hHeight - 100)), centro, anguloRadianes);

            // Dibujar el cuadrado en las nuevas coordenadas, lo dividí en blanco y rojo para ver mejor la rotación
            g.DrawLine(Pens.Red, lineaRoja1, lineaRoja2);
            g.DrawLine(Pens.Red, lineaRoja3, lineaRoja4);
            g.DrawLine(Pens.White, lineaBlanca1, lineaBlanca2);
            g.DrawLine(Pens.White, lineaBlanca3, lineaBlanca4);

            pictureBox1.Refresh();
        }

        // Botón que toma el ángulo proporcionado por un texto y crea y rota un cuadrado de acuerdo al pivote de la figura en su centro.
        private void button2_Click(object sender, EventArgs e)
        {
            Point centro = new Point((int)(pictureBox1.Width / 2), (int)(pictureBox1.Height / 2));

            // Crear el ángulo de rotación, double por que se usa sin y cos y PI
            double angulo = double.Parse(textBox1.Text);

            // Convertir el ángulo a radianes por que al parecer C# le gustan más los radianes, double por que se usa sin y cos y PI
            double anguloRadianes = (Math.PI / 180) * angulo;

            // Para borrar el cuadrado anterior: Se rellena todo el canvas de nuevo pero le da la ilusión de que se borró el cuadrado :)
            g.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Calcular la mitad del pcitureBox1 (En este caso solo las usé para las líneas amarillas)
            float hHeight = pictureBox1.Height / 2f;
            float hWidth = pictureBox1.Width / 2f;

            // Para dibujar las líneas amarillas que dan la referencia al origen
            g.DrawLine(Pens.Yellow, new Point(0, (int)hHeight), new Point(pictureBox1.Width, (int)hHeight));
            g.DrawLine(Pens.Yellow, new Point((int)hWidth, 0), new Point((int)hWidth, pictureBox1.Height));

            // Calcular el nuevo valor de las coordenadas para el cuadrado, ya no es con 100 porque el cuadrado se queda en el lugar
            Point linea1 = RotateSquare(new Point((int)centro.X - 50, (int)centro.Y - 50), centro, anguloRadianes);
            Point linea2 = RotateSquare(new Point((int)(centro.X + 50), (int)centro.Y - 50), centro, anguloRadianes);
            Point linea3 = RotateSquare(new Point((int)centro.X + 50, (int)(centro.Y + 50)), centro, anguloRadianes);
            Point linea4 = RotateSquare(new Point((int)(centro.X - 50), (int)(centro.Y + 50)), centro, anguloRadianes);

            // Dibujar el cuadrado en las nuevas coordenadas, lo dividí en blanco y rojo para ver mejor la rotación
            g.DrawLine(Pens.White, linea1, linea2);
            g.DrawLine(Pens.White, linea2, linea3);
            g.DrawLine(Pens.Red, linea3, linea4);
            g.DrawLine(Pens.Red, linea4, linea1);

            pictureBox1.Refresh();
        }

        // Botón que toma el ángulo proporcionado por un texto y crea y rota un cuadrado colocando su centro en el origen en el centro de la pantalla.
        private void button3_Click(object sender, EventArgs e)
        {
            // Crear el ángulo de rotación, double por que se usa sin y cos y PI
            double angulo = double.Parse(textBox1.Text);

            // Convertir el ángulo a radianes por que al parecer C# le gustan más los radianes, double por que se usa sin y cos y PI
            double anguloRadianes = (Math.PI / 180) * angulo;

            // Calcular la mitad del pcitureBox1
            float hHeight = pictureBox1.Height / 2f;
            float hWidth = pictureBox1.Width / 2f;

            // Coordenadas del cuadrado, creo que esta manera es mejor que las anteriores, pero no estoy seguro.
            int x1 = (int)hWidth;
            int y1 = (int)hHeight;
            int x2 = (int)hWidth + 100;
            int y2 = (int)hHeight - 100;

            // Calcular el centro del cuadrado
            Point centro = new Point((x1 + x2) / 2, (y1 + y2) / 2);

            // Para borrar el cuadrado anterior: Se rellena todo el canvas de nuevo pero le da la ilusión de que se borró el cuadrado :)
            g.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Para dibujar las líneas amarillas que dan la referencia al origen
            g.DrawLine(Pens.Yellow, new Point(0, (int)hHeight), new Point(pictureBox1.Width, (int)hHeight));
            g.DrawLine(Pens.Yellow, new Point((int)hWidth, 0), new Point((int)hWidth, pictureBox1.Height));

            // Calcular el nuevo valor de las coordenadas para el cuadrado, usando las coordenadas ya no hay que sumar y restar 50, 25 o 100. Pero estuvo más confuso de hacer.
            Point lineaRoja1 = RotatePoint(new Point(x1, y1), centro, anguloRadianes);
            Point lineaRoja2 = RotatePoint(new Point(x2, y1), centro, anguloRadianes);
            Point lineaRoja3 = RotatePoint(new Point(x1, y1), centro, anguloRadianes);
            Point lineaRoja4 = RotatePoint(new Point(x1, y2), centro, anguloRadianes);
            Point lineaBlanca1 = RotatePoint(new Point(x2, y1), centro, anguloRadianes);
            Point lineaBlanca2 = RotatePoint(new Point(x2, y2), centro, anguloRadianes);
            Point lineaBlanca3 = RotatePoint(new Point(x1, y2), centro, anguloRadianes);
            Point lineaBlanca4 = RotatePoint(new Point(x2, y2), centro, anguloRadianes);

            // Dibujar el cuadrado en las nuevas coordenadas, lo dividí en blanco y rojo para ver mejor la rotación
            g.DrawLine(Pens.Red, lineaRoja1, lineaRoja2);
            g.DrawLine(Pens.Red, lineaRoja3, lineaRoja4);
            g.DrawLine(Pens.White, lineaBlanca1, lineaBlanca2);
            g.DrawLine(Pens.White, lineaBlanca3, lineaBlanca4);

            pictureBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}