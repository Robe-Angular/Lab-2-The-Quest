using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        {}

        public override string Name { get { return "Sword"; } }

        public void SwordAttackPattern(Direction[] directionArray,Random random)
        {
            if (directionArray.Length != 3)
                return;
            foreach(Direction direction in directionArray)
            {
                if (this.DamageEnemy(direction, 10, 3, random))
                {
                    
                    return;
                }
                    
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            Direction[] arrayForUp = { Direction.Up, Direction.Right, Direction.Left };
            Direction[] arrayForDown = { Direction.Down, Direction.Left, Direction.Right };
            Direction[] arrayForLeft = {Direction.Left, Direction.Down, Direction.Up};
            Direction[] arrayForRight = { Direction.Right, Direction.Up, Direction.Down };
            switch (direction)
            {
                case Direction.Up:
                    SwordAttackPattern(arrayForUp, random);
                    break;
                case Direction.Down:
                    SwordAttackPattern(arrayForDown, random);
                    break;
                case Direction.Left:
                    SwordAttackPattern(arrayForLeft, random);
                    break;
                case Direction.Right:
                    SwordAttackPattern(arrayForRight, random);
                    break;

            }
        }
    }
}
