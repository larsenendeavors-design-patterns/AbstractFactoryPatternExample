using System;
using System.Diagnostics.CodeAnalysis;
using AbstractFactoryPatternExample.Enumerables;
using AbstractFactoryPatternExample.Factories;

namespace AbstractFactoryPatternExample
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    internal class AbstractFactoryPatternExample
    {
        private static void Main(string[] args)
        {
            EnemyShipBuilding enemyShipBuilding = new UfoEnemyShipBuilding();

            var enemyShip = enemyShipBuilding.OrderTheShip(TypeOfShip.UFO);
            Console.WriteLine(enemyShip.ToString());

            var theBoss = enemyShipBuilding.OrderTheShip(TypeOfShip.UFO_BOSS);
            Console.WriteLine(theBoss.ToString());
        }
    }
}
