using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class OfferAngelTokenTier0 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offer 20 Life");
            Tooltip.SetDefault("A Small Sacrifice");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().SpawnTier0();
            item.TurnToAir();
        }

        public override void AddRecipes()
        {
            AngelRecipe recipe = new AngelRecipe(mod);
            //recipe.AddIngredient(mod.GetItem("AngelTokenTier1"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            PocketAngelRecipe PArecipe = new PocketAngelRecipe(mod);
            //PArecipe.AddIngredient(mod.GetItem("AngelTokenTier1"));
            PArecipe.SetResult(this);
            PArecipe.AddRecipe();
        }
    }
}