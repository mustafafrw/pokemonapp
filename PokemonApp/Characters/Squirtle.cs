using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    class Squirtle : Character
    {
        public Squirtle()
        {
            name = "Squirtle";
            hpstart = 30;
            element = "Water";
            hpleft = hpstart;
            hpIncrease = 5;
            minAttack = 8;
        }
    }
}
