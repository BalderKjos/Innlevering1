using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Innlevering1
{
	class Building : GameState
	{
        Texture2D RoofNorthWest;
        Texture2D RoofNorth;
        Texture2D RoofNorthEast;
        Texture2D RoofWest;
        Texture2D RoofEast;
        Texture2D RoofSouthWest;
        Texture2D RoofSouthEast;
        Texture2D RoofSouth;
        Texture2D BrownBlock;
        Texture2D WindowTall;
        Texture2D WallBlockTall;
        Texture2D DoorTallClosed;
        Texture2D StoneBlock;

        public Building(SpriteBatch spritebatch, ContentManager content)
            : base(spritebatch, content)
        {
            loadBuildingContent();
        }

        /// <summary>
        /// Loads texture to Texture2D variables
        /// </summary>
        internal void loadBuildingContent()
		{
			RoofNorthWest = content.Load<Texture2D>(@"img/Roof North West");
			RoofNorth = content.Load<Texture2D>(@"img/Roof North");
			RoofNorthEast = content.Load<Texture2D>(@"img/Roof North East");
			RoofWest = content.Load<Texture2D>(@"img/Roof West");
			RoofEast = content.Load<Texture2D>(@"img/Roof East");
			RoofSouthWest = content.Load<Texture2D>(@"img/Roof South West");
			RoofSouth = content.Load<Texture2D>(@"img/Roof South");
			RoofSouthEast = content.Load<Texture2D>(@"img/Roof South East");
			BrownBlock = content.Load<Texture2D>(@"img/Brown Block");
			WindowTall = content.Load<Texture2D>(@"img/Window Tall");
			WallBlockTall = content.Load<Texture2D>(@"img/Wall Block Tall");
			DoorTallClosed = content.Load<Texture2D>(@"img/Door Tall Closed");
			StoneBlock = content.Load<Texture2D>(@"img/Stone Block");
			
		}

        internal override void Update()
		{
			
		}

        internal override void Draw()
		{

			for (int i = 0; i <= 6; i++)
			{
				if (i == 0)
				{
					spriteBatch.Draw(StoneBlock, new Vector2(100 * i, 400), Color.White);
					spriteBatch.Draw(WallBlockTall, new Vector2(100 * i, 285), Color.White);
					spriteBatch.Draw(RoofNorthWest, new Vector2(100 * i, 40), Color.White);
					spriteBatch.Draw(RoofWest, new Vector2(100 * i, 120), Color.White);
					spriteBatch.Draw(RoofSouthWest, new Vector2(100 * i, 200), Color.White);
				}
				if (i > 0 && i < 5)
				{
					spriteBatch.Draw(StoneBlock, new Vector2(100 * i, 400), Color.White);
					spriteBatch.Draw(WallBlockTall, new Vector2(100 * i, 285), Color.White);
					spriteBatch.Draw(WallBlockTall, new Vector2(100 * i, 285), Color.White);
					spriteBatch.Draw(RoofNorth, new Vector2(100 * i, 40), Color.White);
					spriteBatch.Draw(BrownBlock, new Vector2(100 * i, 120), Color.White);
					spriteBatch.Draw(RoofSouth, new Vector2(100 * i, 200), Color.White);
				}
				if (i == 5)
				{
					spriteBatch.Draw(StoneBlock, new Vector2(100 * i, 400), Color.White);
					spriteBatch.Draw(DoorTallClosed, new Vector2(100 * i, 305), Color.White);
					spriteBatch.Draw(RoofNorth, new Vector2(100 * i, 40), Color.White);
					spriteBatch.Draw(RoofNorth, new Vector2(100 * i, 80), Color.White);
					spriteBatch.Draw(WindowTall, new Vector2(100 * i, 200), Color.White);
				}
				if (i == 6)
				{
					spriteBatch.Draw(StoneBlock, new Vector2(100 * i, 400), Color.White);
					spriteBatch.Draw(WallBlockTall, new Vector2(100 * i, 285), Color.White);
					spriteBatch.Draw(RoofNorthEast, new Vector2(100 * i, 40), Color.White);
					spriteBatch.Draw(RoofEast, new Vector2(100 * i, 120), Color.White);
					spriteBatch.Draw(RoofSouthEast, new Vector2(100 * i, 200), Color.White);
				}

			}
			
		}
	}
}
