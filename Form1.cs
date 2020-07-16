using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;

        }
        //Call Method
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enime(gamespeed);
            gameover();
            coin(gamespeed);
            coincollection();

        }

        int collectedcoin = 0;

        Random r = new Random();
        int x, y;

        //Enime Part//
        void enime(int speed)
        {
            if (enime1.Top >= 500)
            { x = r.Next(0, 200);
                
                enime1.Location = new Point(x, 0);
            }
            else { enime1.Top += speed; }

            if (enime2.Top >= 500)
            {
                x = r.Next(0, 400);

                enime2.Location = new Point(x, 0);
            }
            else { enime2.Top += speed; }

            if (enime3.Top >= 500)
            {
                x = r.Next( 200,350);

                enime3.Location = new Point(x, 0);
            }
            else { enime3.Top += speed; }
        }

        //Coin Part//
        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);

                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }

        }
            //Game Over//
            void gameover()
        { 
            if(car.Bounds.IntersectsWith(enime1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enime2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(enime3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }
        //Road Part//
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if(pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if(pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if(pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if(pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Coin function//
        void coincollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coin = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coin = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coin = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coin = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }
        //Car Control Part//
        int gamespeed = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left >0)
                car.Left += -11; 
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right < 380)
                car.Left += 11;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
            
        }
    }
}
