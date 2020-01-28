using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class AngelTokenTier1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tier 1 Offering Token");
            Tooltip.SetDefault("...");
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
            recipe.AddIngredient(ItemID.DirtBlock, 50);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class OfferAngelTokenTier1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offer Tier 1 Token");
            Tooltip.SetDefault("A Small Sacrifice");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().SpawnTier1();
            item.TurnToAir();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            AngelPlayer player = Main.LocalPlayer.GetModPlayer<AngelPlayer>();
            TooltipLine tooltipLine = new TooltipLine(mod, "1", $"Sacrifced {player.AngelTokensSacrifced1} Token" + (player.AngelTokensSacrifced1 != 1 ? "s" : "") + "");
            tooltips.Add(tooltipLine);
        }

        public override void AddRecipes()
        {
            AngelRecipe recipe = new AngelRecipe(mod);
            recipe.AddIngredient(mod.GetItem("AngelTokenTier1"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            PocketAngelRecipe PArecipe = new PocketAngelRecipe(mod);
            PArecipe.AddIngredient(mod.GetItem("AngelTokenTier1"));
            PArecipe.SetResult(this);
            PArecipe.AddRecipe();
        }
    }
}