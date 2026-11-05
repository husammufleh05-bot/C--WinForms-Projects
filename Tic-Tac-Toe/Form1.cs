using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enPlayer{
            Player1,Player2
            }
        enum enWinner
        {
        Player1,
        Player2,
        Draw,
        GameInProgress
        };
         enWinner Winner;
        struct stPlayer
        {
          public  enWinner Winner;
         public   int Counter ;
            public bool GameOver;

        }
        stPlayer sPlayer;
        
        static enPlayer PlayerNow = enPlayer.Player1;
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White=Color.FromArgb(255,255,255,255);
            Pen WhitePen = new Pen(White);
            WhitePen.Width = 15;
            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(WhitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(WhitePen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(WhitePen, 610, 140, 610, 620);

            e.Graphics.DrawLine(WhitePen, 840, 140, 840, 620);

        }

        private void lbTicTacToe_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            ChangeValues(button9);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool CheckMatch(Button btn1, Button btn2, Button btn3)
        {
            string t1 = btn1.Tag?.ToString();
            string t2 = btn2.Tag?.ToString();
            string t3 = btn3.Tag?.ToString();

            // يجب ألا تكون القيمة null، وألا تكون القيمة الافتراضية '?'، وأن تتساوى الأزرار الثلاثة
            return t1 != null && t1 != "?" && t1 == t2 && t2 == t3;
        }
        void WinnerCheckValues()
        {

            if (CheckMatch(button1, button2, button3) ||
    CheckMatch(button4, button5, button6) ||
    CheckMatch(button7, button8, button9) ||
    CheckMatch(button1, button4, button7) ||
    CheckMatch(button2, button5, button8) ||
    CheckMatch(button3, button6, button9) ||
    CheckMatch(button1, button5, button9) ||
    CheckMatch(button3, button5, button7))
            {
                if(PlayerNow==enPlayer.Player1)
                {
                    lbWinner.Text = "player2";
                    sPlayer.Winner = enWinner.Player2;
                }
                else
                {
                    lbWinner.Text = "Player1";
                        
                    sPlayer.Winner = enWinner.Player1;
                }
                MessageBox.Show("Game Over!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if(sPlayer.Counter==9)
            {
                lbWinner.Text=enWinner.Draw.ToString();
                MessageBox.Show("Game Over!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
         void ChangeValues(Button btn)
        {
            if (btn.Tag != null && btn.Tag.ToString() != "?")
                return;

            if (PlayerNow == enPlayer.Player1)
            {
                btn.Tag = "X";
                btn.Image = Resources.X2;
                PlayerNow = enPlayer.Player2;

                lbTurn.Text = "Player2";
                sPlayer.Counter++;
                
            }
            else
            {
                btn.Tag = "O";
                btn.Image = Resources.O2;
                PlayerNow = enPlayer.Player1;

                lbTurn.Text = "Player1";
                sPlayer.Counter++;
            }
            WinnerCheckValues();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            ChangeValues(button1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeValues(button4);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeValues(button7);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeValues(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeValues(button3);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeValues(button5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeValues(button6);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeValues(button8);

        }
    }
}
