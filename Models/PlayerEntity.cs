using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionshipEFCore.Models
{
    class PlayerEntity
    {
        public int Id { get; set; }
        public int number { get; set; }
        public string peach_place { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Second_name { get; set; }
        public string country { get; set; }
        public int TeamId { get; set; }
        public TeamEntity Team { get; set; } = new TeamEntity();
        public PlayerEntity()
        {
        }
        public PlayerEntity(int number, string peach_place, string name, string surname, string second_name, string country)
        {
            this.number = number;
            this.peach_place = peach_place;
            Name = name;
            Surname = surname;
            Second_name = second_name;
            this.country = country;
        }
    }
}
