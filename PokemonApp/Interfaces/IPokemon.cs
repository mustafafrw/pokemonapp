﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonApp.Interfaces
{
    public interface IPokemon
    {
        bool attack(IPokemon pokemon);
        void potion();
        String name { get; set; }
        String hpMessage { get; }
        String element { get; set; }
        int hpleft { get; set; }

    }
}
