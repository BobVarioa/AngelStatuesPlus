using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod
{
    public class PocketAngelRecipe : ModRecipe
    {
        public PocketAngelRecipe(Mod mod) : base(mod)
        {
           
        }

		public override bool RecipeAvailable()
		{           
			return Main.LocalPlayer.GetModPlayer<AngelPlayer>().PocketAngelStatue;
        }
	}
}
