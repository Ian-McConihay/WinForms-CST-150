/*
* Ian McConihay
* CST-150
* Activity 6
* Sep 29 2024
* 
*/
namespace CST_150_Activity_6_TicTacToe
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int[,] board = new int[3, 3];
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
        }

        /// <summary>
        /// Initializes the game board with random values (0 or 1).
        /// Calls methods to update the display and check for a winner.
        /// </summary>
        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = random.Next(0, 2); // Randomly assign 0 or 1 to each cell
                }
            }
            UpdateBoardDisplay(); // Refresh the display to show the current board state
            CheckForWinner(); // Check if there's a winner after initialization
        }

        /// <summary>
        /// Updates the visual display of the game board in the UI.
        /// Creates and adds labels for each cell based on the board's values.
        /// </summary>
        private void UpdateBoardDisplay()
        {
            tableLayoutPanel1.Controls.Clear(); // Clear previous controls from the panel
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Label cell = new Label
                    {
                        Text = board[i, j] == 0 ? "O" : "X", // Display "O" for 0 and "X" for 1
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Arial", 48),
                        BorderStyle = BorderStyle.FixedSingle // Add a border around each cell
                    };
                    tableLayoutPanel1.Controls.Add(cell, j, i); // Add the cell to the layout panel
                }
            }
        }

        /// <summary>
        /// Checks the game board for a winner or a tie.
        /// Displays the result if a winner is found or if the game ends in a tie.
        /// </summary>
        private void CheckForWinner()
        {
            // Check rows and columns for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    DisplayResult(board[i, 0]); // Display winner if all three in a row match
                    return;
                }

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    DisplayResult(board[0, i]); // Display winner if all three in a column match
                    return;
                }
            }

            // Check diagonals for a winner
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                DisplayResult(board[0, 0]); // Display winner if top-left to bottom-right matches
                return;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                DisplayResult(board[0, 2]); // Display winner if top-right to bottom-left matches
                return;
            }

            // Check for a tie by ensuring all cells are filled
            bool isTie = true;
            foreach (var cell in board)
            {
                if (cell == -1) // If there are any unfilled cells, it's not a tie
                {
                    isTie = false;
                    break;
                }
            }

            if (isTie)
            {
                lblResult.Text = "Result: It's a tie!"; // Display tie result if all cells are filled
            }
        }

        /// <summary>
        /// Displays the result of the game indicating the winner.
        /// </summary>
        /// <param name="winner">The winning player (0 for O, 1 for X).</param>
        private void DisplayResult(int winner)
        {
            lblResult.Text = winner == 0 ? "Result: O Wins!" : "Result: X Wins!"; // Show who won
        }

        /// <summary>
        /// Starts a new game by re-initializing the game board.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeBoard(); // Reset the game board for a new game
        }

    }
}
