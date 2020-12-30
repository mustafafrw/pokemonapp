using PokemonApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    public abstract class Character : IPokemon
    {
        readonly Random randomAttack = new Random();
        public int hpstart { get; set; }
        public int hpleft { get; set; }
        public int hpIncrease { get; set; }
        public String name { get; set; }
        public String hpMessage { get { return hpleft + " / " + hpstart; } }
        public virtual bool attack(IPokemon pokemon) {
            pokemon.hpleft -= randomAttack.Next(0,10);
            if (pokemon.hpleft <= 0) { pokemon.hpleft = 0; return false; }
            return true;
        }
        public virtual void potion()
        {
            if (hpleft + hpIncrease <= hpstart)
                hpleft = hpleft + hpIncrease;
            else
                hpleft = hpstart;
        }
    }
}
