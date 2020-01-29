using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class AngelTokenTier2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tier 2 Offering Token");
            Tooltip.SetDefault("An emblem that marks the beginning of a new adventure.");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 50);
            recipe.AddIngredient(ItemID.Vertebrae, 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class OfferAngelTokenTier2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offer Tier 2 Token");
            Tooltip.SetDefault("A Small Sacrifice");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().SpawnTier2();
            item.TurnToAir();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            AngelPlayer player = Main.LocalPlayer.GetModPlayer<AngelPlayer>();
            TooltipLine tooltipLine = new TooltipLine(mod, "1", $"Sacrifced {player.AngelTokensSacrifced2} Token" + (player.AngelTokensSacrifced2 != 1 ? "s" : "") + "");
            tooltips.Add(tooltipLine);
        }

        public override void AddRecipes()
        {
            AngelRecipe recipe = new AngelRecipe(mod);
            recipe.AddIngredient(mod.GetItem("AngelTokenTier2"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            PocketAngelRecipe PArecipe = new PocketAngelRecipe(mod);
            PArecipe.AddIngredient(mod.GetItem("AngelTokenTier2"));
            PArecipe.SetResult(this);
            PArecipe.AddRecipe();
        }
    }
}