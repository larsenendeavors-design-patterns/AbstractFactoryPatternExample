using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public class UfoEnemyShipFactory : EnemyShipFactory
    {
        public IWeapon AddWeapon()
        {
            return new UfoWeaponGun();
        }

        public IEngine AddEngine()
        {
            return new UfoEngine();
        }
    }
}