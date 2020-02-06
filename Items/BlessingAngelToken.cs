using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class BlessingAngelToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blessing Token");
            Tooltip.SetDefault("Will use a proportionate amount of AP when used");
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
            //recipe.AddIngredient(ItemID.DirtBlock, 50);
            //recipe.AddIngredient(ItemID.StoneBlock, 50);
            //recipe.AddIngredient(ItemID.CopperBar, 10);
            //recipe.AddIngredient(ItemID.IronBar, 5);
            //recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class OfferBlessingAngelToken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offer Blessing Token");
            Tooltip.SetDefault("A Small Sacrifice");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().ChooseBlessing();
            item.TurnToAir();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            AngelPlayer player = Main.LocalPlayer.GetModPlayer<AngelPlayer>();
            TooltipLine tooltipLine = new TooltipLine(mod, "1", $"Sacrifced {player.BlessingAngelTokensSacrifced} Blessing Token" + (player.BlessingAngelTokensSacrifced != 1 ? "s" : "") + "");
            tooltips.Add(tooltipLine);
        }

        public override void AddRecipes()
        {
            BlessingRecipe PArecipe = new BlessingRecipe(mod);
            PArecipe.AddIngredient(mod.GetItem("BlessingAngelToken"));
            PArecipe.SetResult(this);
            PArecipe.AddRecipe();
        }
    }
}