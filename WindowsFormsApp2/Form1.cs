using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int speed_left = 10; //speed of the ball
        public int speed_top = 10;
        public int points = 0;
        public int points2 = 0;
        int bool_strrt_l, bool_strrt_t;

        public Form1()
        {
           
            InitializeComponent();

           bool_strrt_l = ball.Left;
           bool_strrt_t = ball.Top;
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {
        }

        private void playground_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // if (e.KeyCode == Keys.Escape) { this.Close(); }  //press Escape to Quit*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;
            if(ball.Bottom >= Racket .Top && ball.Bottom <= Racket.Bottom && ball.Left >= Racket .Left && ball.Right <= Racket.Right )
            {
            
                speed_top = -speed_top;
                points2 += 1;
                Point_lbl2.Text = points2.ToString();
            }
            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >=playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;           //stop the game
                start.Visible = true;
                label1.Visible = true;
                hScrollBar1.Visible = true;
                points += 1;
                Point_lbl.Text = points.ToString();
                points2 = 0;
                Point_lbl2.Text = points2.ToString();
              
            }

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }  //press Escape to Quit
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void start_Click(object sender, EventArgs e)
        {
       
            Racket.Top = playground.Bottom - (playground.Bottom / 10); //Set the position of Racket

          

            ball.Left = bool_strrt_l;
            ball.Top = bool_strrt_t;

            start.Visible = false;
            label1.Visible = false;
            hScrollBar1.Visible = false;
            timer1.Enabled = true;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { 
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            speed_top = speed_left = 10 + (e.OldValue/5) ;
        }
    }
}
