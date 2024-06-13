using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 15;
        int pipeSpeed = 8;
        int gameScore = 0;
        int lifeCount = 3;
        int lifeTime = 0;  
        public Form1()
        {
            InitializeComponent();
        }

        private void Game_timer_tick_event(object sender, EventArgs e)
        {
            birdVisiableTime();
            lifeTime += 20;
            bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            exLife.Left -= pipeSpeed;

            if(pipeDown.Left < -150)
            {
                pipeDown.Left = 750;
                gameScore++;
            }
            if (pipeUp.Left < -80)
            {
                pipeUp.Left = 950;
                gameScore++;
            }
            if(bird.Bounds.IntersectsWith(pipeUp.Bounds) || bird.Bounds.IntersectsWith(pipeDown.Bounds))
            {
                endGame();
            }
            if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                Game_timer.Stop();
                gameOver.Text = "Game Over\nYour Score is : " + gameScore;
                gameOver.Visible = true;
            }
            if (bird.Bounds.IntersectsWith(exLife.Bounds) && lifeCount < 3)
            {
                exLifeFun();
            }
            if(exLife.Left < -10)
            {
                exLife.Left = 10000;
            }
            if(lifeCount == 1)
            {
                l1.Visible = true;
            }
            if (lifeCount == 2)
            {
                l2.Visible = true;
            }
            if (lifeCount == 3)
            {
                l3.Visible = true;
            }
            score.Text = "Score :" + gameScore;

        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) {
                gravity = 15;
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void endGame()
        {
            if(lifeCount == 0 && lifeTime > 3000)
            {
                Game_timer.Stop();
                gameOver.Text = "Game Over\nYour Score is : " + gameScore;
                gameOver.Visible = true;
            }
            else
            {
                switch(lifeCount)
                {
                    case 1:
                        if(lifeTime > 2500)
                        {
                            l1.Visible = false;
                            lifeCount--;
                            lifeTime = 0;
                        }                       
                        break;
                    case 2:
                        if (lifeTime > 2500)
                        {
                            l2.Visible = false;
                            lifeCount--;
                            lifeTime = 0;
                        }
                        break;
                    case 3:
                        if (lifeTime > 2500)
                        {
                            l3.Visible = false;
                            lifeCount--;
                            lifeTime = 0;
                        }
                        break;
                }
            }
        }
        private void birdVisiableTime()
        {
            if(bird.Visible == true && lifeTime < 2500)
            {
                bird.Visible = false;
            }
            else if(bird.Visible == false && lifeTime > 2500)
            {
                bird.Visible = true;
            }
            else
            {
                bird.Visible = true;
            }
        }
        private void exLifeFun()
        {
            lifeCount++;
            exLife.Left = 15000;
        }
    }
}
