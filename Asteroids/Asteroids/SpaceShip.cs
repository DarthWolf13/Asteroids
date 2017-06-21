using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Up))
            {
                this.velocity += this.AngularDirection * 5;
            }
            if (inputHelper.IsKeyDown(Keys.Down))
            {
                this.velocity -= this.AngularDirection * 5;
            }
            if (inputHelper.IsKeyDown(Keys.Left))
            {
                this.Degrees -= 4;
            }
            if (inputHelper.IsKeyDown(Keys.Right))
            {
                this.Degrees += 4;
            }
        }
    }
}
