using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
namespace First_try_of_game
{



    public partial class Form1 : Form
    {
        //создание переменных
        Bitmap scene;
        const int ogranichitel = 2;
        Graphics game;
        Player start;
        Brush blackbrush;
        int gametimer = 0;
        
        PointF now;
        PointF now1;
        PointF now2;
        PointF now3;
        public Form1()
        {
            InitializeComponent();
            //инициализация


            scene = new Bitmap(canvas.Width, canvas.Height);
            game = Graphics.FromImage(scene);

            
            blackbrush = new SolidBrush(Color.Black);
            start = new Player(new PointF(100, 900), new PointF(900, 100), new PointF(1800, 900));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            
                var rand = new Random();
                //game.Clear(Color.White);

                //game.Clear(Color.White);
                //game.FillEllipse(blackbrush, player.A.X , player.A.Y , player.size, player.size);
                //game.FillEllipse(blackbrush, player.B.X , player.B.Y , player.size, player.size);
                //game.FillEllipse(blackbrush, player.C.X , player.C.Y , player.size, player.size);
                // game.DrawLine(,player.pos.X, player.pos.Y, player.pos.X, player.pos.Y);

                switch (rand.Next(0, 3))
                {
                    case 0:
                        if ((Math.Abs(start.A.X - now.X) > ogranichitel) && (Math.Abs(start.A.Y - now.Y) > ogranichitel))
                        {
                            now.X += (0.5f * (start.A.X - now.X));
                            now.Y += (0.5f * (start.A.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                        }
                        else if (((Math.Abs(start.B.X - now.X) > ogranichitel) && (Math.Abs(start.B.Y - now.Y) > ogranichitel)))
                        {
                            now.X += (0.5f * (start.B.X - now.X));
                            now.Y += (0.5f * (start.B.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);

                        }
                        break;
                    case 1:
                        if ((Math.Abs(start.B.X - now.X) > ogranichitel) && (Math.Abs(start.B.Y - now.Y) > ogranichitel))
                        {
                            now.X += (0.5f * (start.B.X - now.X));
                            now.Y += (0.5f * (start.B.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                        }
                        else if ((Math.Abs(start.C.X - now.X) > ogranichitel) && (Math.Abs(start.C.Y - now.Y) > ogranichitel))
                        {
                            now.X += (0.5f * (start.C.X - now.X));
                            now.Y += (0.5f * (start.C.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                        }
                        break;
                    case 2:
                        if ((Math.Abs(start.C.X - now.X) > ogranichitel) && (Math.Abs(start.C.Y - now.Y) > ogranichitel))
                        {
                            now.X += (0.5f * (start.C.X - now.X));
                            now.Y += (0.5f * (start.C.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                        }
                        else if ((Math.Abs(start.A.X - now.X) > ogranichitel) && (Math.Abs(start.A.Y - now.Y) > ogranichitel))
                        {
                            now.X += (0.5f * (start.A.X - now.X));
                            now.Y += (0.5f * (start.A.Y - now.Y));
                            game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                        }
                        break;
                }
                gametime.Text = gametimer.ToString();
                canvas.Image = scene;
                gametimer++;
            }

            private void Enter_Click(object sender, EventArgs e)
        {
            if ((start.A.X > 0) && (start.A.X < scene.Width) &&
                (start.A.Y > 0) && (start.A.Y < scene.Width) &&
                (start.B.X > 0) && (start.B.X < scene.Width) &&
                (start.B.Y > 0) && (start.B.Y < scene.Width) &&
                (start.C.X > 0) && (start.C.X < scene.Width) &&
                (start.C.Y > 0) && (start.C.Y < scene.Width))
            {
                label_Ax.Enabled = false;
                label_Bx.Enabled = false;
                label_Cx.Enabled = false;
                label_Ay.Enabled = false;
                label_By.Enabled = false;
                label_Cy.Enabled = false;
                Enter.Enabled = false;
                
                game.FillEllipse(blackbrush, start.A.X- start.size/2, start.A.Y - start.size / 2, start.size, start.size);
                game.FillEllipse(blackbrush, start.B.X - start.size / 2, start.B.Y - start.size / 2, start.size, start.size);
                game.FillEllipse(blackbrush, start.C.X - start.size / 2, start.C.Y - start.size / 2, start.size, start.size);
                now.X = start.A.X-start.B.X;
                now.Y = start.A.Y - start.B.Y;
                now1.X = start.A.X - start.C.X;
                now1.Y = start.A.Y - start.C.Y;
                now2.X = start.A.X - start.B.X;
                now2.Y = start.A.Y - start.B.Y;
                now3.X = start.A.X - start.C.X;
                now3.Y = start.A.Y - start.C.Y;
                gameTimer1.Start();
                gameTimer2.Start();
                gametimer3.Start();
                gametimer4.Start();
                //Thread second = new Thread(gameTimer(now1));

            }


        }

        public int stringToInt(string c)
        {
            int x = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i] == '0') || (c[i] == '1') || (c[i] == '2') || (c[i] == '3') || (c[i] == '4') || (c[i] == '5') || (c[i] == '6') || (c[i] == '7') || (c[i] == '8') || (c[i] == '9'))
                {
                    switch (c[i])
                    {
                        case '0':
                            x = x * 10 + 0;
                            break;
                        case '1':
                            x = x * 10 + 1;
                            break;
                        case '2':
                            x = x * 10 + 2;
                            break;
                        case '3':
                            x = x * 10 + 3;
                            break;
                        case '4':
                            x = x * 10 + 4;
                            break;
                        case '5':
                            x = x * 10 + 5;
                            break;
                        case '6':
                            x = x * 10 + 6;
                            break;
                        case '7':
                            x = x * 10 + 7;
                            break;
                        case '8':
                            x = x * 10 + 8;
                            break;
                        case '9':
                            x = x * 10 + 9;
                            break;

                    }
                }
                else { return -1; }
            }

            return x;
        }

        private void label_Ax_TextChanged(object sender, EventArgs e)
        {

            if (stringToInt(label_Ax.Text) == -1) { label_Ax.Text = "Это не цифра"; } else { start.A.X = stringToInt(label_Ax.Text); }
        }

        private void label_Bx_TextChanged(object sender, EventArgs e)
        {
            if (stringToInt(label_Bx.Text) == -1) { label_Bx.Text = "Это не цифра"; } else { start.B.X = stringToInt(label_Bx.Text); }
        }

        private void label_Cx_TextChanged(object sender, EventArgs e)
        {
            if (stringToInt(label_Cx.Text) == -1) { label_Cx.Text = "Это не цифра"; } else { start.C.X = stringToInt(label_Cx.Text); }
        }

        private void label_Cy_TextChanged(object sender, EventArgs e)
        {
            if (stringToInt(label_Cy.Text) == -1) { label_Cy.Text = "Это не цифра"; } else { start.C.Y = stringToInt(label_Cy.Text); }
        }

        private void label_By_TextChanged(object sender, EventArgs e)
        {
            if (stringToInt(label_By.Text) == -1) { label_By.Text = "Это не цифра"; } else { start.B.Y = stringToInt(label_By.Text); }
        }

        private void label_Ay_TextChanged(object sender, EventArgs e)
        {
            if (stringToInt(label_Ay.Text) == -1) { label_Ay.Text = "Это не цифра"; } else { start.A.Y = stringToInt(label_Ay.Text); }
        }

        

        private void gameTimer1_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            //game.Clear(Color.White);

            //game.Clear(Color.White);
            //game.FillEllipse(blackbrush, player.A.X , player.A.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.B.X , player.B.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.C.X , player.C.Y , player.size, player.size);
            // game.DrawLine(,player.pos.X, player.pos.Y, player.pos.X, player.pos.Y);

            switch (rand.Next(0, 3))
            {
                case 0:
                    if ((Math.Abs(start.A.X - now1.X) > ogranichitel) && (Math.Abs(start.A.Y - now1.Y) > ogranichitel))
                    {
                        now1.X += (0.5f * (start.A.X - now1.X));
                        now1.Y += (0.5f * (start.A.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);
                    }else if(((Math.Abs(start.B.X - now1.X) > ogranichitel) && (Math.Abs(start.B.Y - now1.Y) > ogranichitel)))
                    {
                        now1.X += (0.5f * (start.B.X - now1.X));
                        now1.Y += (0.5f * (start.B.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);

                    }
                    break;
                case 1:
                    if ((Math.Abs(start.B.X - now1.X) > ogranichitel) && (Math.Abs(start.B.Y - now1.Y) > ogranichitel))
                    {
                        now1.X += (0.5f * (start.B.X - now1.X));
                        now1.Y += (0.5f * (start.B.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);
                    }else if ((Math.Abs(start.C.X - now1.X) > ogranichitel) && (Math.Abs(start.C.Y - now1.Y) > ogranichitel))
                    {
                        now1.X += (0.5f * (start.C.X - now1.X));
                        now1.Y += (0.5f * (start.C.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);
                    }
                    break;
                case 2:
                    if ((Math.Abs(start.C.X - now1.X) > ogranichitel) && (Math.Abs(start.C.Y - now1.Y) > ogranichitel))
                    {
                        now1.X += (0.5f * (start.C.X - now1.X));
                        now1.Y += (0.5f * (start.C.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);
                    }else if ((Math.Abs(start.A.X - now1.X) > ogranichitel) && (Math.Abs(start.A.Y - now1.Y) > ogranichitel))
                    {
                        now1.X += (0.5f * (start.A.X - now1.X));
                        now1.Y += (0.5f * (start.A.Y - now1.Y));
                        game.FillEllipse(blackbrush, now1.X, now1.Y, 3, 3);
                    }
                    break;
            }
            gametime.Text = gametimer.ToString();
            canvas.Image = scene;
            gametimer++;
        }

        private void gameTimer2_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            //game.Clear(Color.White);

            //game.Clear(Color.White);
            //game.FillEllipse(blackbrush, player.A.X , player.A.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.B.X , player.B.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.C.X , player.C.Y , player.size, player.size);
            // game.DrawLine(,player.pos.X, player.pos.Y, player.pos.X, player.pos.Y);

            switch (rand.Next(0, 3))
            {
                case 0:
                    if ((Math.Abs(start.A.X - now.X) > ogranichitel) && (Math.Abs(start.A.Y - now.Y) > ogranichitel))
                    {
                        now.X += (0.5f * (start.A.X - now.X));
                        now.Y += (0.5f * (start.A.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                    }
                    else if (((Math.Abs(start.B.X - now.X) > ogranichitel) && (Math.Abs(start.B.Y - now.Y) > ogranichitel)))
                    {
                        now.X += (0.5f * (start.B.X - now.X));
                        now.Y += (0.5f * (start.B.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);

                    }
                    break;
                case 1:
                    if ((Math.Abs(start.B.X - now.X) > ogranichitel) && (Math.Abs(start.B.Y - now.Y) > ogranichitel))
                    {
                        now.X += (0.5f * (start.B.X - now.X));
                        now.Y += (0.5f * (start.B.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                    }
                    else if ((Math.Abs(start.C.X - now.X) > ogranichitel) && (Math.Abs(start.C.Y - now.Y) > ogranichitel))
                    {
                        now.X += (0.5f * (start.C.X - now.X));
                        now.Y += (0.5f * (start.C.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                    }
                    break;
                case 2:
                    if ((Math.Abs(start.C.X - now.X) > ogranichitel) && (Math.Abs(start.C.Y - now.Y) > ogranichitel))
                    {
                        now.X += (0.5f * (start.C.X - now.X));
                        now.Y += (0.5f * (start.C.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                    }
                    else if ((Math.Abs(start.A.X - now.X) > ogranichitel) && (Math.Abs(start.A.Y - now.Y) > ogranichitel))
                    {
                        now.X += (0.5f * (start.A.X - now.X));
                        now.Y += (0.5f * (start.A.Y - now.Y));
                        game.FillEllipse(blackbrush, now.X, now.Y, 3, 3);
                    }
                    break;
            }
            gametime.Text = gametimer.ToString();
            canvas.Image = scene;
            gametimer++;
        }

        private void gametimer3_Tick(object sender, EventArgs e)
        {
            
                var rand = new Random();

                //game.Clear(Color.White);
                //game.FillEllipse(blackbrush, player.A.X , player.A.Y , player.size, player.size);
                //game.FillEllipse(blackbrush, player.B.X , player.B.Y , player.size, player.size);
                //game.FillEllipse(blackbrush, player.C.X , player.C.Y , player.size, player.size);
                // game.DrawLine(,player.pos.X, player.pos.Y, player.pos.X, player.pos.Y);

                switch (rand.Next(0, 3))
                {
                    case 0:
                        if ((Math.Abs(start.A.X - now2.X) > ogranichitel) && (Math.Abs(start.A.Y - now2.Y) > ogranichitel))
                        {
                            now2.X += (0.5f * (start.A.X - now2.X));
                            now2.Y += (0.5f * (start.A.Y - now2.Y));
                            game.FillEllipse(blackbrush, now2.X, now2.Y, 3, 3);
                        }
                        break;
                    case 1:
                        if ((Math.Abs(start.B.X - now2.X) > ogranichitel) && (Math.Abs(start.B.Y - now2.Y) > ogranichitel))
                        {
                            now2.X += (0.5f * (start.B.X - now2.X));
                            now2.Y += (0.5f * (start.B.Y - now2.Y));
                            game.FillEllipse(blackbrush, now2.X, now2.Y, 3, 3);
                        }
                        break;
                    case 2:
                        if ((Math.Abs(start.C.X - now2.X) > ogranichitel) && (Math.Abs(start.C.Y - now2.Y) > ogranichitel))
                        {
                            now2.X += (0.5f * (start.C.X - now2.X));
                            now2.Y += (0.5f * (start.C.Y - now2.Y));
                            game.FillEllipse(blackbrush, now2.X, now2.Y, 3, 3);
                        }
                        break;
                }
                gametime.Text = gametimer.ToString();
                
                gametimer++;

            
        }

        private void gametimer4_Tick(object sender, EventArgs e)
        {
            var rand = new Random();

            //game.Clear(Color.White);
            //game.FillEllipse(blackbrush, player.A.X , player.A.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.B.X , player.B.Y , player.size, player.size);
            //game.FillEllipse(blackbrush, player.C.X , player.C.Y , player.size, player.size);
            // game.DrawLine(,player.pos.X, player.pos.Y, player.pos.X, player.pos.Y);

            switch (rand.Next(0, 3))
            {
                case 0:
                    if ((Math.Abs(start.A.X - now3.X) > ogranichitel) && (Math.Abs(start.A.Y - now3.Y) > ogranichitel))
                    {
                        now3.X += (0.5f * (start.A.X - now3.X));
                        now3.Y += (0.5f * (start.A.Y - now3.Y));
                        game.FillEllipse(blackbrush, now3.X, now3.Y, 3, 3);
                    }
                    break;
                case 1:
                    if ((Math.Abs(start.B.X - now3.X) > ogranichitel) && (Math.Abs(start.B.Y - now3.Y) > ogranichitel))
                    {
                        now3.X += (0.5f * (start.B.X - now3.X));
                        now3.Y += (0.5f * (start.B.Y - now3.Y));
                        game.FillEllipse(blackbrush, now3.X, now3.Y, 3, 3);
                    }
                    break;
                case 2:
                    if ((Math.Abs(start.C.X - now3.X) > ogranichitel) && (Math.Abs(start.C.Y - now3.Y) > ogranichitel))
                    {
                        now3.X += (0.5f * (start.C.X - now3.X));
                        now3.Y += (0.5f * (start.C.Y - now3.Y));
                        game.FillEllipse(blackbrush, now3.X, now3.Y, 3, 3);
                    }
                    break;
            }
            gametime.Text = gametimer.ToString();

            gametimer++;
        }
    }

    public class Player
    {
        public PointF A;
        public PointF B;
        public PointF C;
       
        public float size = 30f;

        public Player(PointF A, PointF B, PointF C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            
        }
    }
}
