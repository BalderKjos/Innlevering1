using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Innlevering1
{
    abstract class GameState
    {
        protected SpriteBatch spriteBatch;
        protected ContentManager content;

        public GameState(SpriteBatch spriteBatch, ContentManager content)
        {
            this.spriteBatch = spriteBatch;
            this.content = content;
        }

        internal abstract void Update();
        internal abstract void Draw();

    }
}
