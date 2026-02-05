using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TicTacToe.Business;

namespace TicTacToe.Presentation
{
    public partial class Form1 : Form
    {
        private GameLogic gameLogic = new GameLogic(); // ensure ready before handlers
        private Button[] gameButtons;
        private bool gameStarted = false;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Use the field gameLogic (do not shadow it)

            // Initialize the array of game buttons
            gameButtons = new Button[]
            {
                button0, button1, button2,
                button3, button4, button5,
                button6, button7, button8
            };

            // Attach click events to all game buttons
            for (int i = 0; i < gameButtons.Length; i++)
            {
                int index = i; // Capture index for closure
                gameButtons[i].Click += (s, e) => GameButton_Click(index);
                gameButtons[i].Font = new Font("Arial", 36, FontStyle.Bold);
                gameButtons[i].Enabled = false;
            }

            // Attach button events
            startButton.Click += StartButton_Click;
            newRoundButton.Click += NewRoundButton_Click;
            newGameButton.Click += NewGameButton_Click;

            // Initially disable game control buttons
            newRoundButton.Enabled = false;
            newGameButton.Enabled = false;

            // Initialize labels
            name1Label.Text = "Player 1 (X)";
            name2Label.Text = "Player 2 (O)";
        }

        // Ensure the player object who has Symbol == "X" is the starter
        private void EnsureXStarts()
        {
            if (gameLogic == null) return;

            if (gameLogic.xPlayer != null && gameLogic.xPlayer.Symbol == "X")
            {
                gameLogic.turn = gameLogic.xPlayer;
            }
            else if (gameLogic.oPlayer != null && gameLogic.oPlayer.Symbol == "X")
            {
                gameLogic.turn = gameLogic.oPlayer;
            }
            else if (gameLogic.xPlayer != null) // fallback
            {
                gameLogic.turn = gameLogic.xPlayer;
            }
        }

        private void AnnounceStarter()
        {
            EnsureXStarts();
            if (gameLogic?.turn != null)
            {
                MessageBox.Show($"{gameLogic.turn.Name} (X) will start the round.\nX must always start first.",
                    "Round Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (gameLogic == null) gameLogic = new GameLogic();

            // Validate player names
            if (string.IsNullOrWhiteSpace(player1TextBox.Text) ||
                string.IsNullOrWhiteSpace(player2TextBox.Text))
            {
                MessageBox.Show("Please enter names for both players!",
                    "Missing Names", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize players and keep symbols explicit
            gameLogic.xPlayer = new Player(player1TextBox.Text, "X");
            gameLogic.oPlayer = new Player(player2TextBox.Text, "O");

            // Ensure X starts
            EnsureXStarts();

            // Announce who starts (X must always start first)
            AnnounceStarter();

            // Initialize board
            gameLogic.board.ResetBoard(gameLogic.xPlayer.Name, gameLogic.oPlayer.Name);

            // Update UI
            name1Label.Text = $"{gameLogic.xPlayer.Name} (X)";
            name2Label.Text = $"{gameLogic.oPlayer.Name} (O)";

            // Enable game buttons
            EnableGameButtons(true);
            gameStarted = true;

            // Disable name input and start button
            player1TextBox.Enabled = false;
            player2TextBox.Enabled = false;
            startButton.Enabled = false;

            // Enable game control buttons
            newRoundButton.Enabled = true;
            newGameButton.Enabled = true;

            // Update scoreboard
            UpdateScoreboard();

            // Clear the board
            ClearBoard();
        }

        private void GameButton_Click(int buttonIndex)
        {
            if (!gameStarted)
                return;

            // Convert button index to grid coordinates
            int row = buttonIndex / 3;
            int col = buttonIndex % 3;

            // Check if cell is already occupied
            if (gameLogic.board.grid[row, col] != GameBoard.CellState.Empty)
            {
                MessageBox.Show("This cell is already occupied!",
                    "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Make the move
            GameBoard.CellState cellState = gameLogic.turn.Symbol == "X"
                ? GameBoard.CellState.X
                : GameBoard.CellState.O;

            gameLogic.board.grid[row, col] = cellState;
            gameButtons[buttonIndex].Text = gameLogic.turn.Symbol;
            gameLogic.board.turnCount++;

            // Check for win
            if (gameLogic.CheckWin(gameLogic.turn))
            {
                MessageBox.Show($"{gameLogic.turn.Name} wins!",
                    "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateScoreboard();
                EnableGameButtons(false);
                return;
            }

            // Check for draw
            if (gameLogic.CheckDraw())
            {
                MessageBox.Show("It's a draw!",
                    "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableGameButtons(false);
                return;
            }

            // Switch turns
            gameLogic.turn = (gameLogic.turn == gameLogic.xPlayer)
                ? gameLogic.oPlayer
                : gameLogic.xPlayer;
        }

        private void NewRoundButton_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
                return;

            // Instead of swapping player object references (which can break
            // the invariant that xPlayer.Symbol == "X"), swap the display identity
            // (name and score). Keep the Symbol property tied to xPlayer and oPlayer.
            if (gameLogic?.xPlayer == null || gameLogic.oPlayer == null)
                return;

            // Swap names and scores so roles (X/O) remain attached to the same fields
            string tempName = gameLogic.xPlayer.Name;
            int tempScore = gameLogic.xPlayer.Score;

            gameLogic.xPlayer.Name = gameLogic.oPlayer.Name;
            gameLogic.xPlayer.Score = gameLogic.oPlayer.Score;

            gameLogic.oPlayer.Name = tempName;
            gameLogic.oPlayer.Score = tempScore;

            // Update labels (xPlayer always represents X)
            name1Label.Text = $"{gameLogic.xPlayer.Name} (X)";
            name2Label.Text = $"{gameLogic.oPlayer.Name} (O)";

            // Reset board and ensure X starts
            gameLogic.board.ResetBoard(gameLogic.xPlayer.Name, gameLogic.oPlayer.Name);
            EnsureXStarts();

            // Announce who starts (X must always start first)
            AnnounceStarter();

            // Clear and enable board
            ClearBoard();
            EnableGameButtons(true);

            // Update scoreboard
            UpdateScoreboard();
            }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (gameLogic == null) return;

            // Reset everything
            if (gameLogic.xPlayer != null) gameLogic.xPlayer.Score = 0;
            if (gameLogic.oPlayer != null) gameLogic.oPlayer.Score = 0;

            // Reset board
            if (gameLogic.xPlayer != null && gameLogic.oPlayer != null)
            {
                gameLogic.board.ResetBoard(gameLogic.xPlayer.Name, gameLogic.oPlayer.Name);
                EnsureXStarts();

                // Announce who starts (X must always start first) only if names are fixed
                if (!player1TextBox.Enabled && !player2TextBox.Enabled)
                {
                    AnnounceStarter();
                }
            }

            // Clear and enable board
            ClearBoard();
            EnableGameButtons(true);

            // Update scoreboard
            UpdateScoreboard();

            // Optionally reset player names
            DialogResult result = MessageBox.Show(
                "Do you want to change player names?",
                "New Game",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                player1TextBox.Enabled = true;
                player2TextBox.Enabled = true;
                player1TextBox.Text = "";
                player2TextBox.Text = "";
                startButton.Enabled = true;

                EnableGameButtons(false);
                ClearBoard();
                gameStarted = false;

                newRoundButton.Enabled = false;
                newGameButton.Enabled = false;

                player1ListBox.Items.Clear();
                player2ListBox.Items.Clear();

                name1Label.Text = "Player 1 (X)";
                name2Label.Text = "Player 2 (O)";
            }
        }

        private void UpdateScoreboard()
        {
            // Clear list boxes
            player1ListBox.Items.Clear();
            player2ListBox.Items.Clear();

            if (gameLogic?.xPlayer != null)
            {
                player1ListBox.Items.Add($"{gameLogic.xPlayer.Name}");
                player1ListBox.Items.Add($"Score: {gameLogic.xPlayer.Score}");
            }

            if (gameLogic?.oPlayer != null)
            {
                player2ListBox.Items.Add($"{gameLogic.oPlayer.Name}");
                player2ListBox.Items.Add($"Score: {gameLogic.oPlayer.Score}");
            }
        }

        private void ClearBoard()
        {
            foreach (Button btn in gameButtons)
            {
                btn.Text = "";
            }
        }

        private void EnableGameButtons(bool enable)
        {
            foreach (Button btn in gameButtons)
            {
                btn.Enabled = enable;
            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {

        }

        private void newRoundButton_Click_1(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}