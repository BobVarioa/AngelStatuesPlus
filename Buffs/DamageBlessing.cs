using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Buffs
{
    public class DamageBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blessing : Damage");
            Description.SetDefault("Increased damage");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AngelPlayer>().BlessingBuffType = (int)BlessingBuffTypeID.Damage;
            player.GetModPlayer<AngelPlayer>().Blessed = true;
        }
    }
}