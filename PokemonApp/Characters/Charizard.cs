using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    public class Charizard : Character
    {
        public Charizard()
        {
            name = "Charizard";
            hpstart = 30;
            element = "Fire";
            hpleft = hpstart;
            hpIncrease = 3;
            minAttack = 5;
        }
    }
}
