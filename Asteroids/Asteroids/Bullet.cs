using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Bullet : SpriteGameObject
    {
        Vector2 startPos;

        public Bullet(float x, float y, Vector2 speed) : base("spr_bullet")
        {
            startPos = new Vector2(-200, -200);
            this.position = startPos;
            this.origin = sprite.Center;
            //this.velocity = new Vector2();
            this.position = new Vector2(x, y);
            this.velocity = speed;
        }
    }
}
