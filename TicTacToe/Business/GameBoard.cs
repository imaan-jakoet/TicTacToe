using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Business;

namespace TicTacToe.Business
{
    internal class GameBoard
    {
        public enum CellState
        {
            Empty,
            X,
            O
        }

        public CellState[,] grid = new CellState[3, 3];
        public int turnCount;

        public void ResetBoard(string xPlayerName, string oPlayerName)
        {
            grid = new CellState[3, 3];
            turnCount = 0;
        }

        public void NewRound(Player xPlayer, Player oPlayer)
        {
            Player temp = xPlayer;
            xPlayer = oPlayer;
            oPlayer = temp;
            ResetBoard(xPlayer.Name, oPlayer.Name);
        }
    }
}