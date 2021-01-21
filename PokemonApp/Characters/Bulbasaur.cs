using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonApp.Interfaces;

namespace PokemonApp.Characters
{
   
    public class Bulbasaur : Character
    {
        public Bulbasaur()
        {
            name = "Bulbasaur";
            hpstart = 30;
            element = "Earth";
            hpleft = hpstart;
            hpIncrease = 5;
            minAttack = 1;
        }
    }

}
