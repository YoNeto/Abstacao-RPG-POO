using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public abstract class Wizzard : Hero
    {
        public Wizzard(string Name, int level)
        {
            this.Name = Name;
            this.level = level;
        }
        public override string Attack()
        {
            return $"{this.Name} lançou magia com seu cajado";
        }

        public string Attack(int Bonus)
        {
            if(Bonus >= 35)
                return $"{this.Name} lançou magia com seu cajado com dano efetivo de +{Bonus}% de dano";
            else
                return $"{this.Name} lançou magia com seu cajado com bonus de ataque de +{Bonus}%";
        }
    }
}