using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod
{
    public class AngelRecipe : ModRecipe
    {
        public AngelRecipe(Mod mod) : base(mod)
        {
           
        }

		public override bool RecipeAvailable()
		{
			if (Main.LocalPlayer.GetModPlayer<AngelPlayer>().PocketAngelStatue != true)
			{
				bool isangelstatueclose = false;
				Point playerPos = Main.LocalPlayer.Center.ToTileCoordinates();
				for (int angelX = playerPos.X - 7; angelX < playerPos.X + 8; angelX++)
				{
					for (int angelY = playerPos.Y - 7; angelY < playerPos.Y + 8; angelY++)
					{
						if (WorldGen.InWorld(angelX, angelY))
						{
							Tile tile = Framing.GetTileSafely(angelX, angelY);
							if (tile.type == TileID.Statues && tile.frameX >= 1 * (18 * 2) && tile.frameX <= 2 * (18 * 2) && tile.frameY <= 50)
							{
								isangelstatueclose = true;
							}
						}
					}
				}
				return isangelstatueclose;
			}
			else
			{
				return false;
			}
		}
	}
}
