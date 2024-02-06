using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }

        public override void Move(Random random)
        {
            if (random.Next(3) != 0)
            {
                this.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }



            if (this.NearPlayer() && !Dead)
                this.game.HitPlayer(4, random);
        }
    }
}
