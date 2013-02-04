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
        // Declares Character-textures
        private Texture2D CharacterBoy;
        private Texture2D CharacterCatGirl;
        private Texture2D CharacterHornGirl;
        private Texture2D CharacterPinkgirl;
        private Texture2D CharacterPrincessGirl;

        // Declares Character-Placement
        private Vector2 CharacterPlacement = new Vector2(-100, 350);
        
        // Declares a box around the mouse, used to detect mouse-character collition
        private Rectangle mouseBox;
        private Rectangle characterBox;

        //
        private int characterStartPlacement = -100;
        private int characterStopPlacement = 800;
        private int CharacterNum;
        private int lifeCount = 5;
        private int level = 0;
        private int runTimeCounter = 0;
        private int numberOfCharacters = 0;
        private int nextNumberOfCharacters = 0;
        private int drawCount = 1;
        private int nextDrawCount = 1;
        private float levelSpeed = 1;
        private float nextLevelSpeed = 1;

        private Boolean ifCharacterChoosen = true;

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
            mouseBox = new Rectangle(Mouse.GetState().X + (mouseBox.Width / 2), Mouse.GetState().Y + (mouseBox.Height / 2), 20, 20);
            characterBox = new Rectangle((int)CharacterPlacement.X, (int)CharacterPlacement.Y, CharacterBoy.Bounds.Width, CharacterBoy.Bounds.Height);
            CharacterPlacement.X += levelSpeed;

            if (mouseBox.Intersects(characterBox) &&
                Mouse.GetState().LeftButton == ButtonState.Pressed)
                CharacterPlacement.X = characterStartPlacement;

            if (CharacterPlacement.X > characterStopPlacement)
                CharacterPlacement.X = characterStartPlacement;
                lifeCount--;

            if (ifCharacterChoosen)
            {
                Random rand = new Random();
                CharacterNum = rand.Next(0, 5);
                ifCharacterChoosen = false;
            }
            if (CharacterPlacement.X == characterStartPlacement)
                ifCharacterChoosen = true;

            if (runTimeCounter == 300)
            {
                runTimeCounter = 0;
                if (level == 0)
                    level = 1;
                else
                    level = 0;
            }
            switch (level)
            {
                case 0:
                    if (nextLevelSpeed == levelSpeed)
                    {
                        nextLevelSpeed = levelSpeed + 1;
                    }
                    break;
                case 1:
                    levelSpeed = nextLevelSpeed;
                    break;
                default:
                    levelSpeed = 1;
                    break;
            }
                
            runTimeCounter++;
        }


        internal void drawRandomCharacter()
        {
            switch (CharacterNum)
            {
                case 0:
                    spriteBatch.Draw(CharacterBoy, CharacterPlacement, Color.White);
                    break;
                case 1:
                    spriteBatch.Draw(CharacterCatGirl, CharacterPlacement, Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(CharacterHornGirl, CharacterPlacement, Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(CharacterPinkgirl, CharacterPlacement, Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(CharacterPrincessGirl, CharacterPlacement, Color.White);
                    break;
                default:
                    spriteBatch.Draw(CharacterBoy, CharacterPlacement, Color.White);
                    break;
            }
        }

        internal override void Draw()
        {
            drawRandomCharacter();
        }
    }
}
