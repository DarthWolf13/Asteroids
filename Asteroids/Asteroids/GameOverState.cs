using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class GameOverState : GameObjectList
    {
        private TextGameObject text;

        public GameOverState()
        {
            this.text = new TextGameObject("GameFont");
            this.text.Text = "Game Over";
            this.text.Position = new Vector2((Asteroids.Screen.X / 2) - (this.text.Size.X / 2), (Asteroids.Screen.Y / 2) - (this.text.Size.Y / 2));

            this.Add(text);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                Asteroids.GameStateManager.SwitchTo("TitleScreenState");
            }
        }
    }
}