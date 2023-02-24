using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDeParticulas2
{
    public partial class Form1 : Form
    {
        private const int PARTICLE_COUNT = 100;
        private const int PARTICLE_SIZE_MIN = 5;
        private const int PARTICLE_SIZE_MAX = 15;
        private const int PARTICLE_VELOCITY_MIN = -5;
        private const int PARTICLE_VELOCITY_MAX = 5;
        private const int PARTICLE_GENERATION_DELAY = 100;
        private const int EMITTER_X = 460;
        private const int EMITTER_Y = 210;
        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 25;
        private const int MIN_SPEED = -5;
        private const int MAX_SPEED = 30;
        private const int GRAVITY = 1;
        private const int NEW_PARTICLE_COUNT = 10;

        private Particle[] particles;
        private Random random;
        private Timer timer;

        Image ImagenDeFondo = Image.FromFile("C:\\Users\\marco\\OneDrive\\Documentos\\Udlap\\5to Semestre\\Graficación y Videojuegos\\SegundoParcial\\SistemaDeParticulas2\\PacManMap.png");

        public Form1()
        {
            InitializeComponent();
            InitializeParticleSystem();
            InitializeTimer();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void InitializeParticleSystem()
        {
            particles = new Particle[PARTICLE_COUNT];
            random = new Random();

            for (int i = 0; i < PARTICLE_COUNT; i++)
            {
                particles[i] = new Particle
                {
                    X = pictureBox1.Width / 2,
                    Y = pictureBox1.Height / 2,
                    Size = random.Next(PARTICLE_SIZE_MIN, PARTICLE_SIZE_MAX),
                    Color = Color.FromArgb(50, 50, random.Next(150, 256)),
                    VelocityX = random.Next(PARTICLE_VELOCITY_MIN, PARTICLE_VELOCITY_MAX),
                    VelocityY = random.Next(PARTICLE_VELOCITY_MIN, PARTICLE_VELOCITY_MAX)
                };
            }
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = PARTICLE_GENERATION_DELAY;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Dibujar las partículas
            for (int i = 0; i < PARTICLE_COUNT; i++)
            {
                Particle particle = particles[i];
                if (particle.Image != null)
                {
                    g.DrawImage(particle.Image, particle.X - particle.Size / 2, particle.Y - particle.Size / 2, particle.Size, particle.Size);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
    {
            pictureBox1.BackgroundImage = ImagenDeFondo;
            // Generar nuevas partículas
            for (int i = 0; i < NEW_PARTICLE_COUNT; i++)
        {
            GenerateParticle();
        }

        // Actualizar posición de las partículas
            for (int i = 0; i < PARTICLE_COUNT; i++)
        {
                particles[i].X += particles[i].VelocityX;
                particles[i].Y += particles[i].VelocityY;
                particles[i].VelocityY += GRAVITY;

                // Verificar límites
                if (particles[i].X < 0)
                {
                    particles[i].VelocityX *= -1;
                    particles[i].X = 0;
                }
                else if (particles[i].X > pictureBox1.Width - particles[i].Size)
                {
                    particles[i].VelocityX *= -1;
                    particles[i].X = pictureBox1.Width - particles[i].Size;
                }

                if (particles[i].Y < 0)
                {
                    particles[i].VelocityY *= -1;
                    particles[i].Y = 0;
                }
                else if (particles[i].Y > pictureBox1.Height - particles[i].Size)
                {
                    particles[i].VelocityY *= -1;
                    particles[i].Y = pictureBox1.Height - particles[i].Size;
                }
            }

            // Redibujar las partículas
            pictureBox1.Invalidate();
        }

        private void GenerateParticle()
        {
            Random random = this.random;

            // Generar una nueva partícula
            Particle particle = new Particle();
            particle.X = EMITTER_X;
            particle.Y = EMITTER_Y;
            particle.Size = random.Next(MIN_SIZE, MAX_SIZE + 1);
            particle.Color = Color.FromArgb(50, 50, random.Next(150, 256));
            double speed = random.Next(MIN_SPEED, MAX_SPEED + 1);
            double angle = random.NextDouble() * 2 * Math.PI;
            particle.VelocityX = (float)(speed * Math.Cos(angle));
            particle.VelocityY = (float)(speed * Math.Sin(angle));

            // Subir la imagen de los fantasmitas
            particle.Image = Image.FromFile("C:\\Users\\marco\\OneDrive\\Documentos\\Udlap\\5to Semestre\\Graficación y Videojuegos\\SegundoParcial\\SistemaDeParticulas2\\Ghost.png"); 

            // Reemplazar partícula random con una nueva
            particles[random.Next(PARTICLE_COUNT)] = particle;
        }

        public class Particle
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float VelocityX { get; set; }
            public float VelocityY { get; set; }
            public Color Color { get; set; }
            public int Size { get; set; }
            public Image Image { get; set; } 
        }
    }
}
