using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public class UfoBossEnemyShipFactory : EnemyShipFactory
    {
        public IWeapon AddWeapon()
        {
            return new UfoBossWeaponGun();
        }

        public IEngine AddEngine()
        {
            return new UfoBossEngine();
        }
    }
}