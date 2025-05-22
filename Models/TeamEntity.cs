using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionshipEFCore.Models
{
    class TeamEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<PlayerEntity> Players { get; set; } = new List<PlayerEntity>();
        public ICollection<TeamDuel> Duels { get; set; } = new List<TeamDuel>();
        public TeamEntity()
        {
        }
        public TeamEntity(string name)
        {
            this.name = name;
        }
    }
}
