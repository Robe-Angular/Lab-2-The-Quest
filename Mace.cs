using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Mace"; } }

        public void MaceAttackPattern(Direction[] directionArray, Random random)
        {
            if (directionArray.Length != 4)
                return;
            foreach (Direction direction in directionArray)
            {
                if (this.DamageEnemy(direction, 20, 6, random))
                    return;
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            Direction[] directionArray = {Direction.Up, Direction.Right,
                Direction.Left, Direction.Down};
            this.MaceAttackPattern(directionArray, random);
            
            
        }
    }
}
