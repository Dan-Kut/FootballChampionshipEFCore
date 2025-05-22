using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionshipEFCore.Models
{
    class TeamDuel
    {
        public int Id { get; set; }
        public int Team1Id { get; set; }
        public TeamEntity Team1 { get; set; } = new TeamEntity();
        public int Team2Id { get; set; }
        public TeamEntity Team2 { get; set; } = new TeamEntity();
    }
}
