using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class SpaceShip : RotatingSpriteGameObject
    {
        Vector2 startPos;

        public SpaceShip() : base("spr_spaceship")
        {
            startPos = new Vector2(Asteroids.Screen.X / 2, Asteroids.Screen.Y / 2);
            this.position = startPos;
            this.origin = sprite.Center;
        }
    }
}
