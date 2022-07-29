using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public class WhiteWizzard : Wizzard
    {
        const int constanteVidaWizzard = 12;
        const int constanteManaWizzard = 11;
        public WhiteWizzard(string Name, int level) : base(Name, level)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = "White Wizzard";
            this.Health = level * constanteVidaWizzard;
            this.Mana = level * constanteManaWizzard;
        }
    }
}