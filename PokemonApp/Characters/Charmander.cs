using PokemonApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    public class Charmander : Character
    {
        public Charmander()
        {
            name = "Charmander";
            hpstart = 25;
            element = "Fire";
            hpleft = hpstart;
            hpIncrease = 3;
            minAttack = 3;
        }
    }
}
