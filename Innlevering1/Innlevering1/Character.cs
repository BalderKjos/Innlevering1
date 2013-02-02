using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Innlevering1
{
    class Character : GameState
    {
        Texture2D CharacterBoy;
        Vector2 CharacterBoyPlacement = new Vector2(20, 350);
        Texture2D CharacterCatGirl;
        Texture2D CharacterHornGirl;
        Texture2D CharacterPinkgirl;
        Texture2D CharacterPrincessGirl;


        public Character(SpriteBatch spriteBatch, ContentManager contentMananger)
            : base(spriteBatch, contentMananger)
        {
            loadCharacter();
        }

        internal void loadCharacter()
        {
            CharacterBoy = content.Load<Texture2D>(@"img/Character Boy");
            CharacterCatGirl = content.Load<Texture2D>(@"img/Character Cat Girl");
            CharacterHornGirl = content.Load<Texture2D>(@"img/Character Horn girl");
            CharacterPinkgirl = content.Load<Texture2D>(@"img/Character Pink Girl");
            CharacterPrincessGirl = content.Load<Texture2D>(@"img/Character Princess Girl");
        }

        internal override void Update()
        {
            CharacterBoyPlacement.X += 1;
            if (Mouse.GetState().X < Mouse.GetState().X + CharacterBoy.Bounds.Width &&
                Mouse.GetState().X > CharacterBoyPlacement.X &&
                Mouse.GetState().Y < Mouse.GetState().Y + CharacterBoy.Bounds.Width &&
                Mouse.GetState().Y > CharacterBoyPlacement.Y &&
                Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                CharacterBoyPlacement.X = -100;
            }
        }

        internal override void Draw()
        {
            spriteBatch.Draw(CharacterBoy, CharacterBoyPlacement, Color.White);
        }
    }
}
