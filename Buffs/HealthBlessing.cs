using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Buffs
{
    public class HealthBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing : Health");
            Description.SetDefault("Increased Max Life, and Life Regen");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AngelPlayer>().BlessingBuffType = (int)BlessingBuffTypeID.Health;
        }
    }
}