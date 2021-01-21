using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    class Pikachu:Character
    {
        public Pikachu()
        {
            name = "Pikachu";
            hpstart = 25;
            element = "Electricity";
            hpleft = hpstart;
            hpIncrease = 7;
            minAttack = 4;
        }
    }
}
