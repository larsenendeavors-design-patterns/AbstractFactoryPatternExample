using System;
using AbstractFactoryPatternExample.Enumerables;
using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public class UfoEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip MakeEnemyShip(TypeOfShip typeOfShip)
        {
            if (typeOfShip == TypeOfShip.UFO)
            {
                // The factories determine what weapons and engines the ships get and you end up with a generic enemyShip
                // with the specific properties you want
                var enemyShipFactory = new UfoEnemyShipFactory();
                var enemyShip = new UfoEnemyShip(enemyShipFactory);
                return enemyShip;
            }

            if (typeOfShip == TypeOfShip.UFO_BOSS)
            {
                var enemyShipFactory = new UfoBossEnemyShipFactory();
                var enemyShip = new UfoBossEnemyShip(enemyShipFactory);
                return enemyShip;
            }

            throw new InvalidOperationException("This type of ship is not currently supported!");
        }
    }
}