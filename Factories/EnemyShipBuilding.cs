using AbstractFactoryPatternExample.Enumerables;
using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(TypeOfShip typeOfShip);

        public EnemyShip OrderTheShip(TypeOfShip typeOfShip)
        {
            // The ship is made here, based on the enum you pass in which determines what factory it gets
            var enemyShip = MakeEnemyShip(typeOfShip);

            enemyShip.Create();
            enemyShip.Display();
            enemyShip.FollowHeroShip();
            enemyShip.Shoot();

            return enemyShip;
        }
    }
}