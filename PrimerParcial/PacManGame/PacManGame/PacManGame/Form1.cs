using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGame
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;

        static Position position;

        int level = 1;
        int score = 0;
        int coins = 0;
        bool right, left, up, down;

        bool righte1 = true, lefte1;
        bool righte2, lefte2 = true;
        bool upe3 = true, downe3;
        bool righte4 = true, lefte4;

        int[,] coins0 = new int[25, 25];
        int[,] coins2 = new int[25, 25];
        int[,] coins3 = new int[25, 25];


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(750, 750);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            DrawMap();

            // Para obtener la posición del PacMan
            position = new Position()
            {
                X = PacMan.Left,
                Y = PacMan.Top,
                Path = 2,

                XE1 = Enemywuan.Left,
                YE1 = Enemywuan.Top,
                XE2 = EnemyTwo.Left,
                YE2 = EnemyTwo.Top,
                XE3 = EnemyThree.Left,
                YE3 = EnemyThree.Top,
                XE4 = EnemyCuatro.Left,
                YE4 = EnemyCuatro.Top,
                Pathe = 1,

                
            };

            // Default Imagen del Pacman
            PacMan.Image = GIFS.pacmanRIGHT;
            Enemywuan.Image = GIFS.ghost1;
            EnemyTwo.Image = GIFS.ghost2;
            EnemyThree.Image = GIFS.ghost3;
            EnemyCuatro.Image = GIFS.ghost4;
            LogoPictureBox.Image = GIFS.pacmanLOGO;



        }

        // Función para usar el teclado para moverse
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D || e.KeyData == Keys.Right)
            {
                right = true;
                left = false;
                up = false;
                down = false;
                PacMan.Image = GIFS.pacmanRIGHT;
            }
            if (e.KeyData == Keys.A || e.KeyData == Keys.Left)
            {
                right = false;
                left = true;
                up = false;
                down = false;
                PacMan.Image = GIFS.pacmanLEFT;
            }
            if (e.KeyData == Keys.W || e.KeyData == Keys.Up)
            {
                right = false;
                left = false;
                up = true;
                down = false;
                PacMan.Image = GIFS.pacmanUP;
            }
            if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
            {
                right = false;
                left = false;
                up = false;
                down = true;
                PacMan.Image = GIFS.pacmanDOWN;
            }
        }
        // Termina utilizar Teclado

        
        // Funciones de Colisión
        private bool CollisionLevel1(int x, int y)
        {
            if (Map.map0[y, x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CollisionLevel2(int x, int y)
        {
            if (Map.map2[y, x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CollisionLevel3(int x, int y)
        {
            if (Map.map3[y, x] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Terminar Colisiones
        

        // Función para hacer los Túneles
        private bool TunelNivel1(int x, int y)
        {
            if (Map.map0[y, x] == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool TunelNivel2(int x, int y)
        {
            if (Map.map2[y, x] == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TunelNivel3(int x, int y)
        {
            if (Map.map3[y, x] == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Terminar Tuneles

        // Funciones para las Monedas
        private void Coins0(int x, int y)
        {
            if (Map.map0[y, x] == 0)
            {
                if (coins0[y, x] == 1)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), x * 30, y * 30, 30, 30);
                    coins0[y, x] = 0;
                    score += 420;
                    coins--;
                }
            }
        }

        private void Coins2(int x, int y)
        {
            if (Map.map2[y, x] == 0)
            {
                if (coins2[y, x] == 1)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), x * 30, y * 30, 30, 30);
                    coins2[y, x] = 0;
                    score += 420;
                    coins--;
                }
            }
        }

        private void Coins3(int x, int y)
        {
            if (Map.map3[y, x] == 0)
            {
                if (coins3[y, x] == 1)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), x * 30, y * 30, 30, 30);
                    coins3[y, x] = 0;
                    score += 420;
                    coins--;
                }
            }
        }
        // Terminar Monedas

        // Timer donde se hace todo
        private void timer1_Tick(object sender, EventArgs e)
        {

            // Asignación del pacman a su posición
            PacMan.Left = position.X;
            PacMan.Top = position.Y;


            // Asignación de enemigos a sus posiciones
            Enemywuan.Left = position.XE1;
            Enemywuan.Top = position.YE1;

            EnemyTwo.Left = position.XE2;
            EnemyTwo.Top = position.YE2;

            EnemyThree.Left = position.XE3;
            EnemyThree.Top = position.YE3;

            EnemyCuatro.Left = position.XE4;
            EnemyCuatro.Top = position.YE4;


            // Para los labels
            XPosition.Text = "Position in the x axis: " + position.X;
            YPosition.Text = "Position in the y axis: " + position.Y;
            CoinsLabel.Text = "You have this many coins left: " + coins;
            ScoreLabel.Text = "Your score: " + score;


            // Coordenadas de mapa
            int movementX = position.X / 30;
            int movementY = position.Y / 30;

            // Fantasma 1 Nivel 1, 2, 3
            int movementXE1 = position.XE1 / 30;
            int movementYE1 = position.YE1 / 30;

            // Fantasma 2 Nivel 1, 2, 3
            int movementXE2 = position.XE2 / 30;
            int movementYE2 = position.YE2 / 30;

            // Fantasma 3 Nivel 1, 2, 3
            int movementXE3 = position.XE3 / 30;
            int movementYE3 = position.YE3 / 30;

            // Fantasma 4 Nivel 1, 2, 3
            int movementXE4 = position.XE4 / 30;
            int movementYE4 = position.YE4 / 30;

            if (level == 1)
            {
                // Collision en caso de que el muro esté a la derecha.
                if (right == true)
                {
                    position.X += position.Path;
                    movementX = (position.X + 28) / (30);

                    if (CollisionLevel1(movementX, movementY))
                    {
                        right = false;
                        position.X -= 2;
                    }
                }

                // Collision en caso de que el muro esté a la izquierda.
                if (left == true)
                {
                    position.X -= position.Path;
                    movementX = position.X / 30;

                    if (CollisionLevel1(movementX, movementY))
                    {
                        left = false;
                        position.X += 2;
                    }
                }

                // Collision en caso de que el muro esté arriba.
                if (up == true)
                {
                    position.Y -= position.Path;
                    movementY = position.Y / 30;

                    if (CollisionLevel1(movementX, movementY))
                    {
                        up = false;
                        position.Y += 2;
                    }
                    if (TunelNivel1(movementX, movementY))
                    {
                        position.Y += 690;
                    }
                }

                // Collision en caso de que el muro esté abajo.
                if (down == true)
                {
                    position.Y += position.Path;
                    movementY = (position.Y + 28) / 30;

                    if (CollisionLevel1(movementX, movementY))
                    {
                        down = false;
                        position.Y -= 2;
                    }
                    if (TunelNivel1(movementX, movementY))
                    {
                        position.Y -= 690;
                    }
                }

                // Llamar a la función de las monedas 
                Coins0(movementX, movementY);

                // Fantasma 1
                if (righte1 == true)
                {
                    movementXE1 = (position.XE1 + 29) / (30);
                    position.XE1 += position.Pathe;
                    if (CollisionLevel1(movementXE1, movementYE1))
                    {
                        righte1 = false;
                        position.XE1 -= 1;
                        lefte1 = true;
                    }
                }
                if (lefte1 == true)
                {
                    movementXE1 = (position.XE1) / (30);
                    position.XE1 -= position.Pathe;
                    if (CollisionLevel1(movementXE1, movementYE1))
                    {
                        lefte1 = false;
                        position.XE1 += 1;
                        righte1 = true;
                    }
                }

                // Fantasma 2
                if (righte2 == true)
                {
                    movementXE2 = (position.XE2 + 29) / (30);
                    position.XE2 += position.Pathe;
                    if (CollisionLevel1(movementXE2, movementYE2))
                    {
                        righte2 = false;
                        position.XE2 -= 1;
                        lefte2 = true;
                    }
                }
                if (lefte2 == true)
                {
                    movementXE2 = (position.XE2) / (30);
                    position.XE2 -= position.Pathe;
                    if (CollisionLevel1(movementXE2, movementYE2))
                    {
                        lefte2 = false;
                        position.XE2 += 1;
                        righte2 = true;
                    }
                }

                // Fantasma 3
                if (upe3 == true)
                {
                    movementYE3 = (position.YE3 + 29) / (30);
                    position.YE3 += position.Pathe;
                    if (CollisionLevel1(movementYE3, movementXE3))
                    {
                        upe3 = false;
                        position.YE3 -= 1;
                        downe3 = true;
                    }
                }
                if (downe3 == true)
                {
                    movementYE3 = (position.YE3) / (30);
                    position.YE3 -= position.Pathe;
                    if (CollisionLevel1(movementYE3, movementXE3))
                    {
                        downe3 = false;
                        position.YE3 += 1;
                        upe3 = true;
                    }
                }

                // Fantasma 4
                if (righte4 == true)
                {
                    movementXE4 = (position.XE4 + 29) / (30);
                    position.XE4 += position.Pathe;
                    if (CollisionLevel1(movementXE4, movementYE4))
                    {
                        righte4 = false;
                        position.XE4 -= 1;
                        lefte4 = true;
                    }
                }
                if (lefte4 == true)
                {
                    movementXE4 = (position.XE4) / (30);
                    position.XE4 -= position.Pathe;
                    if (CollisionLevel1(movementXE4, movementYE4))
                    {
                        lefte4 = false;
                        position.XE4 += 1;
                        righte4 = true;
                    }
                }


                // Si el Pacman toca a fantasma 1
                if (PacMan.Bounds.IntersectsWith(Enemywuan.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Bienvenido a Amalucan";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 2
                if (PacMan.Bounds.IntersectsWith(EnemyTwo.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Por estacionarte en Barrio de Santiago";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 3
                if (PacMan.Bounds.IntersectsWith(EnemyThree.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "¿Para que pasas por la CAPU?";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 4
                if (PacMan.Bounds.IntersectsWith(EnemyCuatro.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "En la Falluca somos familia...";
                    DrawMap();
                }

            }
            else if (level == 2)
            {

                if (right == true)
                {
                    position.X += position.Path;
                    movementX = (position.X + 29) / (30);

                    if (CollisionLevel2(movementX, movementY))
                    {
                        right = false;
                        position.X--;
                    }
                }

                // Collision en caso de que el muro esté a la izquierda.
                if (left == true)
                {
                    position.X -= position.Path;
                    movementX = position.X / 30;

                    if (CollisionLevel2(movementX, movementY))
                    {
                        left = false;
                        position.X++;
                    }
                }

                // Collision en caso de que el muro esté arriba.
                if (up == true)
                {
                    position.Y -= position.Path;
                    movementY = position.Y / 30;

                    if (CollisionLevel2(movementX, movementY))
                    {
                        up = false;
                        position.Y++;
                    }
                    if (TunelNivel2(movementX, movementY))
                    {
                        position.Y += 690;
                    }
                }

                // Colision en caso de que el muro esté abajo.
                if (down == true)
                {
                    position.Y += position.Path;
                    movementY = (position.Y + 29) / 30;

                    if (CollisionLevel2(movementX, movementY))
                    {
                        down = false;
                        position.Y--;
                    }
                    if (TunelNivel2(movementX, movementY))
                    {
                        position.Y -= 690;
                    }
                }
                // Llamar a la función de las monedas 
                Coins2(movementX, movementY);

                // Fantasma 1
                if (righte1 == true)
                {
                    movementXE1 = (position.XE1 + 29) / (30);
                    position.XE1 += position.Pathe;
                    if (CollisionLevel2(movementXE1, movementYE1))
                    {
                        righte1 = false;
                        position.XE1 -= 1;
                        lefte1 = true;
                    }
                }
                if (lefte1 == true)
                {
                    movementXE1 = (position.XE1) / (30);
                    position.XE1 -= position.Pathe;
                    if (CollisionLevel2(movementXE1, movementYE1))
                    {
                        lefte1 = false;
                        position.XE1 += 1;
                        righte1 = true;
                    }
                }

                // Fantasma 2
                if (righte2 == true)
                {
                    movementXE2 = (position.XE2 + 29) / (30);
                    position.XE2 += position.Pathe;
                    if (CollisionLevel2(movementXE2, movementYE2))
                    {
                        righte2 = false;
                        position.XE2 -= 1;
                        lefte2 = true;
                    }
                }
                if (lefte2 == true)
                {
                    movementXE2 = (position.XE2) / (30);
                    position.XE2 -= position.Pathe;
                    if (CollisionLevel2(movementXE2, movementYE2))
                    {
                        lefte2 = false;
                        position.XE2 += 1;
                        righte2 = true;
                    }
                }

                // Fantasma 3
                if (upe3 == true)
                {
                    movementYE3 = (position.YE3 + 29) / (30);
                    position.YE3 += position.Pathe;
                    if (CollisionLevel2(movementYE3, movementXE3))
                    {
                        upe3 = false;
                        position.YE3 -= 1;
                        downe3 = true;
                    }
                }
                if (downe3 == true)
                {
                    movementYE3 = (position.YE3) / (30);
                    position.YE3 -= position.Pathe;
                    if (CollisionLevel2(movementYE3, movementXE3))
                    {
                        downe3 = false;
                        position.YE3 += 1;
                        upe3 = true;
                    }
                }

                // Fantasma 4
                if (righte4 == true)
                {
                    movementXE4 = (position.XE4 + 29) / (30);
                    position.XE4 += position.Pathe;
                    if (CollisionLevel2(movementXE4, movementYE4))
                    {
                        righte4 = false;
                        position.XE4 -= 1;
                        lefte4 = true;
                    }
                }
                if (lefte4 == true)
                {
                    movementXE4 = (position.XE4) / (30);
                    position.XE4 -= position.Pathe;
                    if (CollisionLevel2(movementXE4, movementYE4))
                    {
                        lefte4 = false;
                        position.XE4 += 1;
                        righte4 = true;
                    }
                }


                // Si el Pacman toca a fantasma 1
                if (PacMan.Bounds.IntersectsWith(Enemywuan.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Bienvenido a Amalucan";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 2
                if (PacMan.Bounds.IntersectsWith(EnemyTwo.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Por estacionarte en Barrio de Santiago";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 3
                if (PacMan.Bounds.IntersectsWith(EnemyThree.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "¿Para que pasas por la CAPU?";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 4
                if (PacMan.Bounds.IntersectsWith(EnemyCuatro.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "En la Falluca somos familia...";
                    DrawMap();
                }
            }
            else if (level == 3)
            {
                if (right == true)
                {
                    position.X += position.Path;
                    movementX = (position.X + 29) / (30);

                    if (CollisionLevel3(movementX, movementY))
                    {
                        right = false;
                        position.X--;
                    }
                }

                // Collision en caso de que el muro esté a la izquierda.
                if (left == true)
                {
                    position.X -= position.Path;
                    movementX = position.X / 30;

                    if (CollisionLevel3(movementX, movementY))
                    {
                        left = false;
                        position.X++;
                    }
                }

                // Collision en caso de que el muro esté arriba.
                if (up == true)
                {
                    position.Y -= position.Path;
                    movementY = position.Y / 30;

                    if (CollisionLevel3(movementX, movementY))
                    {
                        up = false;
                        position.Y++;
                    }
                    if (TunelNivel3(movementX, movementY))
                    {
                        position.Y += 690;
                    }
                }

                // Collision en caso de que el muro esté abajo.
                if (down == true)
                {
                    position.Y += position.Path;
                    movementY = (position.Y + 29) / 30;

                    if (CollisionLevel3(movementX, movementY))
                    {
                        down = false;
                        position.Y--;
                    }
                    if (TunelNivel3(movementX, movementY))
                    {
                        position.Y -= 690;
                    }
                }
                // Llamar a la función de las monedas 
                Coins3(movementX, movementY);

                // Fantasma 1
                if (righte1 == true)
                {
                    movementXE1 = (position.XE1 + 29) / (30);
                    position.XE1 += position.Pathe;
                    if (CollisionLevel3(movementXE1, movementYE1))
                    {
                        righte1 = false;
                        position.XE1 -= 1;
                        lefte1 = true;
                    }
                }
                if (lefte1 == true)
                {
                    movementXE1 = (position.XE1) / (30);
                    position.XE1 -= position.Pathe;
                    if (CollisionLevel3(movementXE1, movementYE1))
                    {
                        lefte1 = false;
                        position.XE1 += 1;
                        righte1 = true;
                    }
                }

                // Fantasma 2
                if (righte2 == true)
                {
                    movementXE2 = (position.XE2 + 29) / (30);
                    position.XE2 += position.Pathe;
                    if (CollisionLevel3(movementXE2, movementYE2))
                    {
                        righte2 = false;
                        position.XE2 -= 1;
                        lefte2 = true;
                    }
                }
                if (lefte2 == true)
                {
                    movementXE2 = (position.XE2) / (30);
                    position.XE2 -= position.Pathe;
                    if (CollisionLevel3(movementXE2, movementYE2))
                    {
                        lefte2 = false;
                        position.XE2 += 1;
                        righte2 = true;
                    }
                }

                // Fantasma 3
                if (upe3 == true)
                {
                    movementYE3 = (position.YE3 + 29) / (30);
                    position.YE3 += position.Pathe;
                    if (CollisionLevel3(movementYE3, movementXE3))
                    {
                        upe3 = false;
                        position.YE3 -= 1;
                        downe3 = true;
                    }
                }
                if (downe3 == true)
                {
                    movementYE3 = (position.YE3) / (30);
                    position.YE3 -= position.Pathe;
                    if (CollisionLevel3(movementYE3, movementXE3))
                    {
                        downe3 = false;
                        position.YE3 += 1;
                        upe3 = true;
                    }
                }

                // Fantasma 4
                if (righte4 == true)
                {
                    movementXE4 = (position.XE4 + 29) / (30);
                    position.XE4 += position.Pathe;
                    if (CollisionLevel3(movementXE4, movementYE4))
                    {
                        righte4 = false;
                        position.XE4 -= 1;
                        lefte4 = true;
                    }
                }
                if (lefte4 == true)
                {
                    movementXE4 = (position.XE4) / (30);
                    position.XE4 -= position.Pathe;
                    if (CollisionLevel3(movementXE4, movementYE4))
                    {
                        lefte4 = false;
                        position.XE4 += 1;
                        righte4 = true;
                    }
                }


                // Si el Pacman toca a fantasma 1
                if (PacMan.Bounds.IntersectsWith(Enemywuan.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Bienvenido a Amalucan";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 2
                if (PacMan.Bounds.IntersectsWith(EnemyTwo.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "Por estacionarte en Barrio de Santiago";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 3
                if (PacMan.Bounds.IntersectsWith(EnemyThree.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "¿Para que pasas por la CAPU?";
                    DrawMap();
                }

                // Si el Pacman toca a fantasma 4
                if (PacMan.Bounds.IntersectsWith(EnemyCuatro.Bounds))
                {
                    coins = 0;
                    score = 0;
                    position.X = 360;
                    position.Y = 510;
                    right = false;
                    left = false;
                    up = false;
                    down = false;
                    Ghost1Label.Text = "En la Falluca somos familia...";
                    DrawMap();
                }
            }
            
            
            if(coins == 0)
            {
                position.X = 360;
                position.Y = 510;
                level++;
                right = false;
                left = false;
                up = false;                 
                down = false;
                DrawMap();
            }
        }

        private void DrawMap()
        {
            pictureBox1.Refresh();
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);

            if (level == 1)
            {
                for (int x = 0; x < Map.map0.GetLength(0); x++)
                {
                    for (int y = 0; y < Map.map0.GetLength(1); y++)
                    {
                        // Coins
                        if (Map.map0[y, x] == 0)
                        {
                            g.FillEllipse(new SolidBrush(Color.White), x * 30 + 9, y * 30 + 9, 9, 9);
                            coins0[y, x] = 1;
                            coins++;
                        }
                        // Walls
                        else if (Map.map0[y, x] == 1)
                        {
                            g.DrawRectangle(Pens.CornflowerBlue, x * 30, y * 30, 30, 30);

                        }
                        // Empty Space
                        else if (Map.map0[y, x] == 2)
                        {

                        }
                        // Tunnels
                        else if (Map.map0[y, x] == 3)
                        {

                        }
                        // Intersections
                        else if (Map.map0[y, x] == 4)
                        {

                        }
                    }
                }
                pictureBox1.Invalidate();
            }
            else if (level == 2) 
            {
                for (int x = 0; x < Map.map2.GetLength(0); x++)
                {
                    for (int y = 0; y < Map.map2.GetLength(1); y++)
                    {
                        // Coins
                        if (Map.map2[y, x] == 0)
                        {
                            g.FillEllipse(new SolidBrush(Color.White), x * 30 + 9, y * 30 + 9, 9, 9);
                            coins2[y, x] = 1;
                            coins++;
                        }
                        // Walls
                        else if (Map.map2[y, x] == 1)
                        {
                            g.DrawRectangle(Pens.CornflowerBlue, x * 30, y * 30, 30, 30);
                        }
                        // Empty Space
                        else if (Map.map2[y, x] == 2)
                        {
                        }
                        // Tunnels
                        else if (Map.map2[y, x] == 3)
                        {
                        }
                        // Intersections
                        else if (Map.map2[y, x] == 4)
                        {
                        }
                    }
                }
                pictureBox1.Invalidate();
            }
            else if (level == 3)
            {
                for (int x = 0; x < Map.map3.GetLength(0); x++)
                {
                    for (int y = 0; y < Map.map3.GetLength(1); y++)
                    {
                        // Coins
                        if (Map.map3[y, x] == 0)
                        {
                            g.FillEllipse(new SolidBrush(Color.White), x * 30 + 9, y * 30 + 9, 9, 9);
                            coins3[y, x] = 1;
                            coins++;
                        }
                        // Walls
                        else if (Map.map3[y, x] == 1)
                        {
                            g.DrawRectangle(Pens.CornflowerBlue, x * 30, y * 30, 30, 30);
                        }
                        // Empty Space
                        else if (Map.map3[y, x] == 2)
                        {
                        }
                        // Tunnels
                        else if (Map.map3[y, x] == 3)
                        {
                        }
                        // Intersections
                        else if (Map.map3[y, x] == 4)
                        {
                        }
                    }
                }
                pictureBox1.Invalidate();
            }

        }
    }
}
