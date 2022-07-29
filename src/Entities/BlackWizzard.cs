using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public class BlackWizzard : Wizzard
    {
        const int constanteVidaWizzard = 9;
        const int constanteManaWizzard = 15;
        public BlackWizzard(string Name, int level) : base(Name, level)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = "Black Wizzard";
            this.Health = level * constanteVidaWizzard;
            this.Mana = level * constanteManaWizzard;
        }
    }
}