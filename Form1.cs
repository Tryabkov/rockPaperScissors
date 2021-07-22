using System;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        Random random = new();
        Dictionary<int, int> winMoves = new Dictionary<int, int>{
                {1, 3},
                {2, 1},
                {3, 2}};

        Dictionary<int, string> designations = new Dictionary<int, string>{
                {1, "rock"},
                {2, "paper"},
                {3, "scissors"}};

        public Form1()
        {
            //1 - rock
            //2 - paper
            //3 - scissors



            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BRock_Click(object sender, EventArgs e)
        {
            ClearAll();
            Сounting(1);
        }

        private void BPaper_Click(object sender, EventArgs e)
        {
            ClearAll();
            Сounting(2);
        }

        private void BScissors_Click(object sender, EventArgs e)
        {
            ClearAll();
            Сounting(3);
        }

        private void Сounting(int playerMove)
        {
            int enemyMove = random.Next(1, 4);

            if (playerMove != enemyMove)
            {
                if (enemyMove == winMoves[playerMove])
                {
                    PrintResults(playerMove, enemyMove, "You WIN!!!");
                }
                else
                {
                    PrintResults(playerMove, enemyMove, "Enemy win");
                }
            }
            else
            {
                PrintResults(playerMove, enemyMove, "Nobody win");
            }
        }

        private void PrintResults(int playerMove, int enemyMove, string result)
        {
            lbYourMove.Text = "Your move: " + designations[playerMove];
            lbEnemyMove.Text = "Enemy move: " + designations[enemyMove];
            lbResult.Text = result;
        }

        private void ClearAll()
        {

        }

        private void lbYourMove_Click(object sender, EventArgs e)
        {

        }
    }
}
