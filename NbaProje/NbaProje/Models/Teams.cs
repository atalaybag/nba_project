using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NbaProje.Models
{
    public class Teams
    {
        public int TeamsID { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        [DisplayName("Team City")]
        public string TeamCity { get; set; }
        [DisplayName("Team Arena")]
        public string TeamArena { get; set; }
        [DisplayName("Championships")]
        public int ChCount { get; set; }
        [DisplayName("W")]
        public int Win { get; set; }
        [DisplayName("L")]
        public int Lose { get; set; }
        [DisplayName("Win/Lose %")]
        public double WinLosePercentage { get; set; }
        [DisplayName("PPG")]
        public double PointsPerGame { get; set; }
        [DisplayName("OPPG")]
        public double OpponentPointsPerGame { get; set; }
        public string Conference { get; set; }
        public ICollection<Players> Players { get; set; }

    }
}
