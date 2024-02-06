using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        { }

        public override void Move(Random random)
        {
            if (this.Dead) return;

            if(random.Next(3) == 0)
            {
                this.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            

            if (this.NearPlayer())
                this.game.HitPlayer(3, random);
        }
    }
}
