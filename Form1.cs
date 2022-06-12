using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        const string USERWIN = "You WIN!!!";
        const string PROGRAMWIN = "Enemy win";
        const string NOBODYWIN = "Nobody win";
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

        private void RockButton_Click(object sender, EventArgs e)
        {
            Сounting(1);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {           
            Сounting(2);
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            Сounting(3);
        }

        private void Сounting(int playerMove)
        {
            int enemyMove = random.Next(1, 4);

            if (playerMove != enemyMove)
            {
                if (enemyMove == winMoves[playerMove])
                {
                    PrintResults(playerMove, enemyMove, USERWIN);
                }
                else
                {
                    PrintResults(playerMove, enemyMove, PROGRAMWIN);
                }
            }
            else
            {
                PrintResults(playerMove, enemyMove, NOBODYWIN);
            }
        }

        private void PrintResults(int playerMove, int enemyMove, string result)
        {
            UserMoveLabel.Text = "Your move: " + designations[playerMove];
            programMoveLabel.Text = "Enemy move: " + designations[enemyMove];
            resultLabel.Text = result;
        }
    }
}
