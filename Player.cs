using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        private List<Weapon> inventory = new List<Weapon> { };

        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string> { };
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location)
            :base(game, location){
            hitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            this.location = Move(direction, game.Boundaries);

            Console.WriteLine("Playe");
            Console.WriteLine(this.location);
            Console.WriteLine("Weapon In Room");
            Console.WriteLine(game.WeaponInRoom.Location);

            if (!game.WeaponInRoom.PickedUp)
            {
                if (
                    Math.Abs(game.WeaponInRoom.Location.X - this.Location.X) <= 20
                    && Math.Abs(game.WeaponInRoom.Location.Y - this.Location.Y) <= 20
                )
                {
                    inventory.Add(game.WeaponInRoom);
                    Console.WriteLine(game.WeaponInRoom.Location);

                    if (Weapons.Count == 1)
                        equippedWeapon = game.WeaponInRoom;
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (this.equippedWeapon == null)
                return;
            if (this.equippedWeapon is IPotion)
            {
                IPotion equippedPotion = this.equippedWeapon as IPotion;
                if (equippedPotion.Used)
                    return;
                
            }
            this.equippedWeapon.Attack(direction, random);
            
        }


    }
    
}
