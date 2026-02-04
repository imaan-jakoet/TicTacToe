using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Business
{
    internal class GameLogic
    {
        GameBoard board = new GameBoard();
        public Player turn;
        public Player xPlayer;
        public Player oPlayer;

        public Boolean CheckWin(Player turn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board.grid[i, 0] != GameBoard.CellState.Empty &&
                    board.grid[i, 0] == board.grid[i, 1] &&
                    board.grid[i, 1] == board.grid[i, 2])
                {
                    turn.addScore();
                    return true;
                }
                else if (board.grid[0, i] != GameBoard.CellState.Empty &&
                    board.grid[0, i] == board.grid[1, i] &&
                    board.grid[1, i] == board.grid[2, i])
                {
                    turn.addScore();
                    return true;
                }
            }
            if (board.grid[0, 0] != GameBoard.CellState.Empty &&
                board.grid[0, 0] == board.grid[1, 1] &&
                board.grid[1, 1] == board.grid[2, 2])
            {
                turn.addScore();
                return true;
            }
            else if (board.grid[0, 2] != GameBoard.CellState.Empty &&
                board.grid[0, 2] == board.grid[1, 1] &&
                board.grid[1, 1] == board.grid[2, 0])
            {
                turn.addScore();
                return true;
            }
            else
            {
                CheckDraw();
                return false;
            }
        }

        public Boolean CheckDraw()
        {
            return board.turnCount >= 9 && !CheckWin(turn);
        }

        public void SwitchTurn(Player turn)
        {
            board.turnCount++;
            if (turn.Equals(xPlayer))
            {
                turn = oPlayer;

            }
            else
            {
                turn = xPlayer;
            }
            if (CheckWin(turn))
            {
                board.NewRound(xPlayer, oPlayer);
            }
        }
    }
}
