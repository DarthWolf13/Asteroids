using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip ship;

        public PlayingState()
        {
            ship = new SpaceShip();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(ship);
        }
    }
}
