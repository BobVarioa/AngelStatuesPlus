using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class AngelStatueGlobalRecipe : GlobalItem
    {
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.AngelStatue);
            recipe.AddRecipe();
        }
    }
}