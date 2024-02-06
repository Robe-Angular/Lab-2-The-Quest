using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class BluePotion : Weapon, IPotion
    {
        private bool used;
        public bool Used{ get { return this.used; } }

        public BluePotion(Game game, Point location)
            : base(game, location)
            { }

        public override string Name { get { return "Blue potion"; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            this.used = true;
        }
    }
}
