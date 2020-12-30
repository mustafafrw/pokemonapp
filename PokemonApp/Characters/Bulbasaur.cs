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
        }
        public Bulbasaur(int hpstart)
        {
            this.hpstart = hpstart;
            hpleft = hpstart;
            hpIncrease = 3;
        }
    }

}
