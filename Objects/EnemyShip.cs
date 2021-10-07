using System;
using AbstractFactoryPatternExample.Factories;

namespace AbstractFactoryPatternExample.Objects
{
    public abstract class EnemyShip
    {
        protected string Name { get; set; }
        protected IWeapon Weapon { get; set; }
        protected IEngine Engine { get; set; }
        protected EnemyShipFactory EnemyShipFactory { get; set; }

        public abstract void Create();

        public void Display()
        {
            Console.WriteLine(Name + " appears on screen.");
        }
        
        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " follows the hero.");
        }

        public void Shoot()
        {
            Console.WriteLine(Name + " shoots at the hero and does " + Weapon);
        }
        


        public override string ToString()
        {
            return "The " + Name + " has a top speed of " + Engine + " and an attack power of " + Weapon;
        }

    }
}