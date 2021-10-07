using AbstractFactoryPatternExample.Enumerables;
using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public abstract class EnemyShipBuilding
    {
        protected abstract EnemyShip MakeEnemyShip(TypeOfShip typeOfShip);

        public EnemyShip OrderTheShip(TypeOfShip typeOfShip)
        {
            var enemyShip = MakeEnemyShip(typeOfShip);

            enemyShip.Create();
            enemyShip.Display();
            enemyShip.FollowHeroShip();
            enemyShip.Shoot();

            return enemyShip;
        }
    }
}