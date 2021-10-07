using AbstractFactoryPatternExample.Objects;

namespace AbstractFactoryPatternExample.Factories
{
    public interface EnemyShipFactory
    {
        public IWeapon AddWeapon();
        public IEngine AddEngine();
    }
}