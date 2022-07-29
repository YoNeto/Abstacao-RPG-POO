using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public class Ninja : Hero
    {
        const int constanteVidaNinja = 14;
        const int constanteManaNinja = 3;
        public Ninja(){}
        public Ninja(string Name, int level)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = "Ninja";
            this.Health = level * constanteVidaNinja;
            this.Mana = level * constanteManaNinja;
        }

        public string Attack(bool stealth)
        {
            if(stealth)
                return $"{this.Name} atacou com sua Shuriken de forma furtiva, dando dano critico";
            else
                return $"{this.Name} atacou com sua Shuriken";
        }
        
    }
}