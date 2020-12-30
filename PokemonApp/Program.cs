using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonApp.Characters;
using PokemonApp.Interfaces;

namespace PokemonApp
{
    class Program
    {
        
        static void Main(string[] args)
        {

            List<IPokemon> pokemons = new List<IPokemon>() {
                new Charmander(20){ name = "Charmander"},
                new Bulbasaur(25){ name = "Bulbasaur"},
                new Charizard(30){ name = "Charizard"}

            };
            var Enemy = ((from p in pokemons.OrderBy(x => Guid.NewGuid()) select p).Take(1)).ToList()[0];

            Console.WriteLine("{0} has appeared", Enemy.name);

            //List collection of 'pokemons' is being printed to the screen with action
            int _i = 1;
            Action<IPokemon> pokemonListAction = (pokemon) =>
            {
                Console.WriteLine((_i++).ToString() + " - " + pokemon.name + " - " + pokemon.hpMessage);
            };
            //getting pokemons list without enemy
            var withoutEnemyPokemons = (from p in pokemons where p.name!=Enemy.name select p).ToList();
            withoutEnemyPokemons.ForEach(pokemonListAction);

            //Ask for a number from user to select a pokemon
            Console.WriteLine(Environment.NewLine+"Please select a pokemon to battle");

            string choice = Console.ReadLine();
            int choiceInt;

            if (int.TryParse(choice, out choiceInt))
            {
                Console.WriteLine("Your choice is {0}", choiceInt.ToString());
                var selectedPokemon = withoutEnemyPokemons[choiceInt - 1];
                Console.WriteLine("Your pokemon is {0}", selectedPokemon.name);

                bool turnuser = true,gameContinue=true;
                while (gameContinue)
                {
                    GameMessage(selectedPokemon, Enemy);

                    if (turnuser)
                    {
                        Console.WriteLine("Please give an action, Press A to Attack, Press P to potion");
                        string actionChoice = Console.ReadLine();
                        switch (actionChoice.ToUpper())
                        {
                            case "A":
                                gameContinue = selectedPokemon.attack(Enemy);
                                break;
                            case "P":
                                selectedPokemon.potion();
                                break;
                            default:
                                Console.WriteLine("Wrong input for an action");
                                break;
                        }
                        if (!gameContinue)
                        {
                            GameMessage(selectedPokemon, Enemy);

                            Console.WriteLine("You win!");
                        }
                    }
                    else {
                        Console.WriteLine("It is your enemy's turn");
                        gameContinue = Enemy.attack(selectedPokemon);
                        if (!gameContinue)
                        {
                            GameMessage(selectedPokemon, Enemy);
                            Console.WriteLine("You lost!");                        }
                    }
                    turnuser = !turnuser;

                }
            }
            else Console.WriteLine("Your choice must be among the listed numbers");
            
            Console.Read();

        }
        static void GameMessage(IPokemon userPokemon, IPokemon enemyPokemon)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("----------------------");
            Console.WriteLine("Player pokemon {0}", userPokemon.name);
            Console.WriteLine("HP: {0}", userPokemon.hpMessage);
            Console.WriteLine("Enemy pokemon {0}", enemyPokemon.name);
            Console.WriteLine("HP: {0}", enemyPokemon.hpMessage);
            Console.WriteLine("----------------------");
        }
    }
}
