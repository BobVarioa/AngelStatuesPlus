using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Buffs
{
    public class WingsBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing : Wings");
            Description.SetDefault("Increased Max wing time");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AngelPlayer>().BlessingBuffType = (int)BlessingBuffTypeID.Wings;
            player.GetModPlayer<AngelPlayer>().Blessed = true;
        }
    }
}