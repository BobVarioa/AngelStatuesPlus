using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Buffs
{
    public class DefenseBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing : Defense");
            Description.SetDefault("Increased defense and damage reduction");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AngelPlayer>().BlessingBuffType = (int)BlessingBuffTypeID.Defense;
        }
    }
}