using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class PocketAngelStatue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pocket Angel Statue");
            Tooltip.SetDefault("...");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 2;
        }

        public override void UpdateInventory(Player player)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().PocketAngelStatue = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            AngelPlayer player = Main.LocalPlayer.GetModPlayer<AngelPlayer>();
            TooltipLine tooltipLine = new TooltipLine(mod, "1", $"Sacrifced {player.AngelTokensSacrificedTotal} Token" + (player.AngelTokensSacrificedTotal != 1 ? "s" : "") + "");
            tooltips.Add(tooltipLine);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AngelStatue, 5);
            recipe.AddIngredient(ItemID.Chain, 10);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}