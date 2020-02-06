using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod
{
    public class BlessingRecipe : ModRecipe
    {
        public BlessingRecipe(Mod mod) : base(mod)
        {
           
        }

		public override bool RecipeAvailable()
		{
            return (!Main.LocalPlayer.GetModPlayer<AngelPlayer>().Blessed && Main.LocalPlayer.GetModPlayer<AngelPlayer>().PocketAngelStatue ? true : false);
		}
	}
}
