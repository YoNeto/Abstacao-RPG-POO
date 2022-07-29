using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public class Knight : Hero
    {
        const int constanteVidaKnight = 18;
        const int constanteManaKnight = 2;
        public Knight(){}
        public Knight(string Name, int level)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = "knight";
            this.Health = level * constanteVidaKnight;
            this.Mana = level * constanteManaKnight;
        }

        
    }
}