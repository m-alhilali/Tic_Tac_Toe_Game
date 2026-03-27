using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        sStateGame statesgame;
        enPlayer PlayerTurn = enPlayer.player1;
        enum enPlayer
        {
            player1,
            player2
        }

       enum enWinner
        {
            Player1,
            Player2,
            Draw,
            InProgress
        }
        struct sStateGame
        {
            public enWinner Winner;
            public short PlayAccount;
            public bool GameOver;
        }
        public Form1()
        {
            InitializeComponent();
        }

        void EndGame()
        {
            lblPlayerTurn.Text = "Game Over";
            Button[] btn = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button btn2 in btn)
            {
                btn2.Enabled=false;
            }

            switch(statesgame.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;
                case enWinner.Draw:
                    lblWinner.Text = "   Draw";
                    break;
            }
            MessageBox.Show("Game Over","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag)
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                if (btn1.Tag.ToString() == "X")
                {
                    statesgame.Winner = enWinner.Player1;
                    statesgame.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    statesgame.Winner = enWinner.Player2;
                    statesgame.GameOver = true;
                    EndGame();
                    return true;
                }


            }
           

            statesgame.GameOver= false;
            return false;
        }
       void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;
            if (CheckValues(button4, button5, button6))
                return;
            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button1, button5, button9))
                return;
            if (CheckValues(button3, button5, button7))
                return;
        }
        void ChangePicture(Button btn)
        {
            comBox1.Enabled = false;
            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.player1:
                        btn.Image = Resources.X;
                        lblPlayer.Text = "Player2";
                        PlayerTurn=enPlayer.player2;
                        statesgame.PlayAccount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.player2:
                        btn.Image = Resources.O;
                        lblPlayer.Text = "Player1";
                        PlayerTurn = enPlayer.player1;
                        statesgame.PlayAccount++;
                        btn.Tag = "C";
                        CheckWinner();
                        break;
                }
            }

            else
            {
                MessageBox.Show("This aleady Choiced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (statesgame.PlayAccount == 9)
            {
                statesgame.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color WhiteColor= Color.White;
            Pen pen = new Pen(WhiteColor,7);

            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap=System.Drawing.Drawing2D.LineCap.Round;

            //رسم الخطين الراسيين
            e.Graphics.DrawLine(pen, 580, 100, 580, 400);
            e.Graphics.DrawLine(pen, 410, 100, 410, 400);

            //رسم الخطيين الافقيين
            e.Graphics.DrawLine(pen, 700, 200, 280, 200);
            e.Graphics.DrawLine(pen, 700, 310, 280, 310);
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangePicture((Button) sender);

        }

        void ResetButton(Button btn)
        {
            btn.Enabled = true;
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Button[] btn = { button1, button2, button3, button4, button5, button6, button7, button8, button9};
            foreach (Button btn2 in btn)
            {
                ResetButton(btn2);
            }
            
            comBox1.Enabled = true;
            lblPlayer.Text = "Player1";
            PlayerTurn = enPlayer.player1;
            lblPlayerTurn.Text = "Turn";
            statesgame.Winner = enWinner.InProgress;
            statesgame.PlayAccount = 0;
            statesgame.GameOver = false;
            lblWinner.Text = "InProgress";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comBox1.SelectedIndex = 0;
        }

        private void WhoWillStart(object sender, EventArgs e)
        {
            if (comBox1.SelectedIndex == 0)
            {
                lblPlayer.Text = "Player1";
                PlayerTurn=enPlayer.player1;
                return;

            }
            lblPlayer.Text = "Player2";
            PlayerTurn = enPlayer.player2;
        }

    }
}
