using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids
{
    class PlayingState : GameObjectList
    {
        SpaceShip ship;
        GameObjectList bullets, rocks;
        int rockAmount = 20;
        string rockType;

        public PlayingState()
        {
            ship = new SpaceShip();
            bullets = new GameObjectList();
            rocks = new GameObjectList();

            string[] rock = new string[] {"spr_rock1", "spr_rock2", "spr_rock3"};
            

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(ship);
            this.Add(bullets);
            this.Add(rocks);

            for(int i = 0; i < rockAmount; i++)
            {
                rockType = rock[GameEnvironment.Random.Next(3)];
                this.rocks.Add(new Rock(rockType));
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet(ship.Position.X, ship.Position.Y, ship.AngularDirection * 300));
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach(Bullet bullet in bullets.Objects)
            {
                foreach (Rock rock in rocks.Objects)
                {
                    if (bullet.CollidesWith(rock))
                    {
                        bullet.Visible = false;

                        if (rock.assetname == "spr_rock3") {
                            rock.Visible = false;
                            this.rocks.Add(new Rock(rock.Position, rock.Velocity, "spr_rock2"));
                            break;
                        }
                        else if(rock.assetname == "spr_rock2")
                        {
                            rock.Visible = false;
                            this.rocks.Add(new Rock(rock.Position, rock.Velocity, "spr_rock1"));
                            break;
                        }
                        else if(rock.assetname == "spr_rock1")
                        {
                            rock.Visible = false;
                            break;
                        }                        
                    }
                }
            }
        }
    }
}
