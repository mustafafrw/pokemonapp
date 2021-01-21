using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonApp.Interfaces;
using PokemonApp.Characters;

namespace TestsPokemonApp
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestName()
        {
            IPokemon pokemon = new Charmander();
            Assert.AreEqual(pokemon.name, "Charmander");
        }
        [TestMethod]
        public void TestElement()
        {
            IPokemon pokemon = new Charmander();
            Assert.AreEqual(pokemon.element, "Fire");
        }
        [TestMethod]
        public void TestAttack()
        {
            Character pokemon = new Charmander();
            var enemy = new Bulbasaur();
            enemy.attack(pokemon);

            Assert.AreNotEqual(pokemon.hpleft, pokemon.hpstart);
        }
        [TestMethod]
        public void TestPotionStart()
        {
            Character pokemon = new Charmander();
            pokemon.potion();

            Assert.AreEqual(pokemon.hpleft,pokemon.hpstart);
        }
        [TestMethod]
        public void TestPotionAfterAttack()
        {
            Character pokemon = new Charmander();
            var enemy = new Bulbasaur();
            enemy.attack(pokemon);
            enemy.attack(pokemon);
            int hpbefore = pokemon.hpleft;
            pokemon.potion();

            Assert.AreNotEqual(hpbefore, pokemon.hpleft);
        }
    }
}
