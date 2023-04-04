using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBets
{
    public class TicketForGame
    {
        public Game game { get; set; }
        public String type { get; set; }

        public TicketForGame(Game game, string type)
        {
            this.game = game;
            this.type = type;
        }

        public decimal getCoef()
        {
            switch (type)
            {
                case "1":
                    return game.coef1;
                case "2":
                    return game.coef2;
                default:
                    return game.coefX;
            }
        }

        public override string ToString()
        {
            return $"{game.ToString()} Type: {type} Coef: {getCoef()}";
        }
    }
}
