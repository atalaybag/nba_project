using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NbaProje.Models
{
    public class Players
    {
        public int PlayersID { get; set; }
        public string Playerimg { get; set; }
        [DisplayName("Jersey Number")]
        public int PlayerJerseyNo { get; set; }
        [DisplayName("Name")]
        public string PlayerName { get; set; }

        public string Position { get; set; }
        public int Games { get; set; }
        [DisplayName("Games Started")]
        public int GamesStarted { get; set; }
        public double MP { get; set; }
        public double FG { get; set; }
        public double FGA { get; set; }
        public double FGP { get; set; }
        public double TP { get; set; }
        public double TPA { get; set; }
        public double TPP { get; set; }
        public double TwP { get; set; }
        public double TwPA { get; set; }
        public double TwPP { get; set; }
        public double eFG { get; set; }
        public double FT { get; set; }
        public double FTA { get; set; }
        public double FTP { get; set; }
        public double ORB { get; set; }
        public double DRB { get; set; }
        public double TRB { get; set; }
        public double AST { get; set; }
        public double STL { get; set; }
        public double BLK { get; set; }
        public double TOV { get; set; }
        public double PF { get; set; }
        public double PTS { get; set; }

        public int TeamsID { get; set; }
        public Teams Teams { get; set; }
    }
}
