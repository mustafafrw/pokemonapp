using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    class Pidgey : Character
    {
        public Pidgey()
        {
            name = "Pidgey";
            hpstart = 25;
            element = "Flying";
            hpleft = hpstart;
            hpIncrease = 1;
            minAttack = 9;
        }
    }
}
