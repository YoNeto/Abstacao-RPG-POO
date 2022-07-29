using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRPG_POO.src.Entities
{
    public abstract class Hero
    {
        public Hero(){}
        public Hero(string Name, int level)
        {
            this.Name = Name;
            this.level = level;
        }
        public override string ToString()
        {
            return $"Nome: {this.Name} | Level: {this.level}| Class: {this.HeroType}| HP: {this.Health}/{this.Health}| MP: {this.Mana}/{this.Mana}";
        }
        public string Name;

        public int level;

        public string HeroType;

        public int Health;

        public int Mana;

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada";
        }
    }
}