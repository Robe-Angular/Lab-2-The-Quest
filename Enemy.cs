using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_2_The_Quest
{
    public abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int hitPoints;
        public int Hitpoints { get { return this.hitPoints; } }
        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }

        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location) { this.hitPoints = hitPoints; }

        public abstract void Move(Random random);

        public void Hit (int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage + 1);
        }

        protected bool NearPlayer()
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > this.location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < this.location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < this.location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;


        }

    }
}
