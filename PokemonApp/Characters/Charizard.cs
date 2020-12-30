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
        }
        public Charizard(int hpstart)
        {
            this.hpstart = hpstart;
            hpleft = hpstart;
            hpIncrease = 3;
        }
    }
}
