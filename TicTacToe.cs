using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private int player2;
        private int player1;
        private int Turn;
        public TicTacToe()
        {
            InitializeComponent();

            // Start game with player 1
            label3.Text = "Player 1";
            Turn = 1;
            player1 = 0;
            player2 = 0;
            lblPlayer1Score.Text = player1.ToString();
            lblPlayer2Score.Text = player2.ToString();

            ClearBoard();
        }


        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleClick(button1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            HandleClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleClick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleClick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleClick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleClick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleClick(button9);
        }

        private void HandleClick(Button button)
        {
            if (string.IsNullOrEmpty(button.Text))
            {
                button.Text = Turn == 1 ? "X" : "O";

                Turn = Turn == 1 ? 2 : 1;

                label3.Text = Turn == 1 ? "Player 1" : "Player 2";

                GetWinner();
            }

        }


        public void GetWinner()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();
                    }

                    ClearBoard();

                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    if (button2.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        lblPlayer1Score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        lblPlayer2Score.Text = player2.ToString();

                    }
                    ClearBoard();

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Start game with player 1
            label3.Text = "Player 1";
            Turn = 1;
            player1 = 0;
            player2 = 0;
            lblPlayer1Score.Text = player1.ToString();
            lblPlayer2Score.Text = player2.ToString();
            ClearBoard();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Turn = 1;
            label3.Text = "Player 1";
            ClearBoard();
        }

        private void ClearBoard()
        {
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.White;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = string.Empty;
        }
    }
}
