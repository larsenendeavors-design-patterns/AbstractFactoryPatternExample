using AbstractFactoryPatternExample.Factories;

namespace AbstractFactoryPatternExample.Objects
{
    public class UfoBossEnemyShip : EnemyShip
    {
        public UfoBossEnemyShip(EnemyShipFactory enemyShipFactory)
        {
            EnemyShipFactory = enemyShipFactory;
        }

        public override void Create()
        {
            Name = "Ufo Boss";
            Weapon = EnemyShipFactory.AddWeapon();
            Engine = EnemyShipFactory.AddEngine();
        }
        
    }
}