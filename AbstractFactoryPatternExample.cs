using System;
using System.Diagnostics.CodeAnalysis;
using AbstractFactoryPatternExample.Enumerables;
using AbstractFactoryPatternExample.Factories;

namespace AbstractFactoryPatternExample
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    internal class AbstractFactoryPatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/07
         */
        
        /*
         * Author's Note: This one was admittedly a doozy, it's combining a lot of OOO theories together
         * and I don't think I've seen this one in the wild before.  Basically what's happening here is objects are primarily
         * being made with primitives and interfaces, blending together the concept of factories and Strategies.
         */
        
        private static void Main(string[] args)
        {
            EnemyShipBuilding enemyShipBuilding = new UfoEnemyShipBuilding();

            // This is the entry point, you order the ship
            var enemyShip = enemyShipBuilding.OrderTheShip(TypeOfShip.UFO);
            Console.WriteLine(enemyShip.ToString());

            var theBoss = enemyShipBuilding.OrderTheShip(TypeOfShip.UFO_BOSS);
            Console.WriteLine(theBoss.ToString());
        }
    }
}
