using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Buffs
{
    public class SpeedBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing : Speed");
            Description.SetDefault("Increased speed");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AngelPlayer>().BlessingBuffType = (int)BlessingBuffTypeID.Speed;
            player.GetModPlayer<AngelPlayer>().Blessed = true;
        }
    }
}