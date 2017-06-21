using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip ship;
        GameObjectList bullets;

        public PlayingState()
        {
            ship = new SpaceShip();
            bullets = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(ship);
            this.Add(bullets);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet(ship.Position.X, ship.Position.Y, ship.AngularDirection * 300));
            }
        }
    }
}
