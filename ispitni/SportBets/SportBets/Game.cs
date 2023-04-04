using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBets
{
    public class Game
    {
        public string gameCode { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public decimal coef1 { get; set; }
        public decimal coef2 { get; set; }
        public decimal coefX { get; set; }

        public Game(string gameCode, Team homeTeam, Team awayTeam, decimal coef1, decimal coef2, decimal coefX)
        {
            this.gameCode = gameCode;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.coef1 = coef1;
            this.coef2 = coef2;
            this.coefX = coefX;
        }

        public override string ToString()
        {
            return $"{homeTeam.Name} - {awayTeam.Name} ({gameCode})";
        }
    }
}
