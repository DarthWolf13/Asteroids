using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Rock : SpriteGameObject
    {
        Vector2 randomPos, randomVel;
        public string assetname;

        public Rock(string assetname) : base(assetname)
        {
            randomPos = new Vector2(GameEnvironment.Random.Next(0, Asteroids.Screen.X), GameEnvironment.Random.Next(0, Asteroids.Screen.Y));
            this.position = randomPos;
            randomVel = new Vector2(GameEnvironment.Random.Next(1, 100), GameEnvironment.Random.Next(1, 100));
            this.velocity = randomVel;
            this.assetname = assetname;
        }

        public Rock(Vector2 location, Vector2 move, string assetname) : base(assetname)
        {
            //location = new Vector2();
            this.position = location;
            //move = new Vector2(0, 100);
            this.velocity = move;
            this.assetname = assetname;
        }

        public void WrapScreen()
        {
            if (this.position.X < 0)
            {
                this.position.X = Asteroids.Screen.X;
            }

            if (this.position.X > Asteroids.Screen.X)
            {
                this.position.X = 0;
            }

            if (this.position.Y < 0)
            {
                this.position.Y = Asteroids.Screen.Y;
            }

            if (this.position.Y > Asteroids.Screen.Y)
            {
                this.position.Y = 0;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            WrapScreen();
        }
    }
}
