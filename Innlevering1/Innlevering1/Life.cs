using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Innlevering1
{
    class Life : GameState
    {
        private Texture2D Heart;
        private int lifeCount = 5;

        public Life(SpriteBatch spriteBatch, ContentManager contentMananger)
            : base(spriteBatch, contentMananger)
        {
            loadHeart();
        }

        internal void loadHeart()
        {
            Heart = content.Load<Texture2D>(@"img/Heart");

        }

        internal override void Update()
        {
            
        }

        internal override void Draw()
        {
            for (int i = 0; i < lifeCount; i++)
            {
                spriteBatch.Draw(Heart, new Rectangle(50 * i, 10, 50, 70), Color.White);
            }
        }
    }
}
