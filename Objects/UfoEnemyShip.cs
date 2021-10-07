using System;
using AbstractFactoryPatternExample.Factories;

namespace AbstractFactoryPatternExample.Objects
{
    public class UfoEnemyShip : EnemyShip
    {
        public UfoEnemyShip(UfoEnemyShipFactory enemyShipFactory)
        {
            EnemyShipFactory = enemyShipFactory;
        }
        
        public override void Create()
        {
            Name = "Ufo";
            Weapon = EnemyShipFactory.AddWeapon();
            Engine = EnemyShipFactory.AddEngine();
        }
        
    }
}