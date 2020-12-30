using PokemonApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Characters
{
    public class Charmander : Character
    {
        public Charmander(int hpstart)
        {
            this.hpstart = hpstart;
            hpleft = hpstart;
            hpIncrease = 3;
        }
        public Charmander()
        {
        }
    }
}
