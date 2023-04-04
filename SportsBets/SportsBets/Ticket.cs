using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    public class Ticket
    {
        public Game Game { get; set; }
        public int Type { get; set; }

        public Ticket(Game game, int type)
        {
            Game = game;
            Type = type;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Game.ToString(), Type == 0 ? "1" : Type == 1 ? "X" : "2");
        }
    }
}
