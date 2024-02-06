using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        {}

        public override void Move(Random random)
        {
            if (this.Dead) return;

            Direction directionOfNewLocation = random.Next(2) == 0 ? 
                this.FindPlayerDirection(game.PlayerLocation)
                : (Direction)random.Next(4);

            this.location = Move(directionOfNewLocation, game.Boundaries);

            if (this.NearPlayer())
                this.game.HitPlayer(2, random);

        }
    }
}
