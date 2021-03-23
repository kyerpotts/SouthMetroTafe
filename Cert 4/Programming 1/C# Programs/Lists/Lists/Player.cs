using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Player
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public string Name { get; set; }
        public string Team { get; set; }
    }
}
