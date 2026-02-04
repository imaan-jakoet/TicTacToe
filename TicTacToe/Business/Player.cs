using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Business
{
    internal class Player
    {
        private string name;
        private int score;
        private string symbol;

        public Player(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
            this.score = 0;
        }

        public void addScore()
        {
            score++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
    }
}
