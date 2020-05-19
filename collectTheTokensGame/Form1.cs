using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collectTheTokensGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        int count = 0;
        int timeLeft = 60;
        Random rand = new Random();
        Timer timer = new Timer();
        token[] redTokens = new token[50];
        token blueToken;
        Bitmap redImage = new Bitmap(@"H:\2020\13CSC\3.7computerProgram\Tasks\collectTheTokensGame\redCircle.png");
        Bitmap blueImage = new Bitmap(@"H:\2020\13CSC\3.7computerProgram\Tasks\collectTheTokensGame\blueCircle.png");

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < redTokens.Length; i++)
            {
                int xCoordinate = rand.Next(this.Width - 50);
                int yCoordinate = rand.Next(40, this.Height - 75);
                redTokens[i] = new token(xCoordinate, yCoordinate, redImage);
                Controls.Add(redTokens[i].TokenPictureBox);
            }

            timer.Enabled = true;
            timer.Interval = 1000;

            blueToken = new token(10, 50, blueImage);
            Controls.Add(blueToken.TokenPictureBox);
            
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            timer.Tick += new EventHandler(timer_Tick);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int right = 1;
            int left = -1;
            int up = -1;
            int down = 1;

            int blueDist = blueToken.TokenPictureBox.Width / 2;

            if (e.KeyCode == Keys.W)
            {
                blueToken.moveUpDown(up, blueDist);
            }
            if (e.KeyCode == Keys.S)
            {
                blueToken.moveUpDown(down, blueDist);
            }
            if (e.KeyCode == Keys.A)
            {
                blueToken.moveRightLeft(left, blueDist);
            }
            if (e.KeyCode == Keys.D)
            {
                blueToken.moveRightLeft(right, blueDist);
            }

            for (int z = 0; z < redTokens.Length; z++)
            {
                if (blueToken.TokenPictureBox.Bounds.IntersectsWith(redTokens[z].TokenPictureBox.Bounds))
                {
                    count++;
                    redTokens[z].TokenPictureBox.Top = 1000;
                    redTokens[z].TokenPictureBox.Left = 1000;
                    lblCollectedCount.Text = "TOKENS COLLECTED: " + count;
                }
            }

            if (count == redTokens.Length)
            {
                timer.Enabled = false;
                MessageBox.Show("Congratulations you have completed the game!");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "TIME LEFT: " + timeLeft;
            if (timeLeft == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("Bad luck, you have failed.");
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
