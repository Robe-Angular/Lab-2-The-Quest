using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    public abstract class Weapon : Mover
    {
        
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }
        public Weapon(Game game, Point location)
            : base(game, location)
        {
            
            pickedUp = false;
        }

        public void PickUpWeapon()
        {
            this.pickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            Console.WriteLine(direction);
            for (int distance = 0; distance < radius; distance++)
            {
                
                foreach (Enemy enemy in game.Enemies)
                {
                    if(!enemy.Dead && Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
                
            }
            return false;
        }

        
        

        public Point Move(Direction direction,Point target, Rectangle boundaries )
        {
            this.location = target;
            target = Move(direction, boundaries);
            
            return target;
        }

        public bool Nearby(Point enemyLocation, Point target, int radius)
        {
            //Console.WriteLine(target);
            //Console.WriteLine(enemyLocation);
            //Console.WriteLine(distance);
            if (Math.Abs(enemyLocation.X - target.X) < radius
                && Math.Abs(enemyLocation.Y - target.Y) < radius )
                return true;
            return false;


        }
        
    }
}
