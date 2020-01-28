using System;
using System.Collections.Generic;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace AngelMod
{
    class AngelPlayer : ModPlayer
    {
        public bool AngelStatueMessages = true;
        public bool PocketAngelStatue = false;
        public int AngelTokensSacrifced0 = 0;
        public int AngelTokensSacrifced1 = 0;
        public int AngelTokensSacrifced2 = 0;
        public int AngelTokensSacrifced3 = 0;
        public int AngelTokensSacrifced4 = 0;
        public int AngelTokensSacrifced5 = 0;
        public int AngelTokensSacrifced6 = 0;
        public int AngelTokensSacrifced7 = 0;
        public int AngelTokensSacrifced8 = 0;
        public int AngelTokensSacrifced9 = 0;
        public int AngelTokensSacrifced10 = 0;
        public int AngelTokensSacrifced11 = 0;
        public int AngelTokensSacrificedTotal = 0;
        public override void ResetEffects()
        {
            PocketAngelStatue = false;
        }

        public override TagCompound Save()
        {
            var AngelTokensSacrifced = new List<int>();
            AngelTokensSacrifced.Add(AngelTokensSacrifced0);
            AngelTokensSacrifced.Add(AngelTokensSacrifced1);
            AngelTokensSacrifced.Add(AngelTokensSacrifced2);
            AngelTokensSacrifced.Add(AngelTokensSacrifced3);
            AngelTokensSacrifced.Add(AngelTokensSacrifced4);
            AngelTokensSacrifced.Add(AngelTokensSacrifced5);
            AngelTokensSacrifced.Add(AngelTokensSacrifced6);
            AngelTokensSacrifced.Add(AngelTokensSacrifced7);
            AngelTokensSacrifced.Add(AngelTokensSacrifced8);
            AngelTokensSacrifced.Add(AngelTokensSacrifced9);
            AngelTokensSacrifced.Add(AngelTokensSacrifced10);
            AngelTokensSacrifced.Add(AngelTokensSacrifced11);
            return new TagCompound {
				{"AngelTokensSacrifced", AngelTokensSacrifced},
                {"AngelTokensSacrificedTotal", AngelTokensSacrificedTotal}
            };
        }

        public override void Load(TagCompound tag)
        {
            var AngelTokensSacrifced = tag.GetList<int>("AngelTokensSacrifced");
            AngelTokensSacrifced0 = AngelTokensSacrifced[0];
            AngelTokensSacrifced1 = AngelTokensSacrifced[1];
            AngelTokensSacrifced2 = AngelTokensSacrifced[2];
            AngelTokensSacrifced3 = AngelTokensSacrifced[3];
            AngelTokensSacrifced4 = AngelTokensSacrifced[4];
            AngelTokensSacrifced5 = AngelTokensSacrifced[5];
            AngelTokensSacrifced6 = AngelTokensSacrifced[6];
            AngelTokensSacrifced7 = AngelTokensSacrifced[7];
            AngelTokensSacrifced8 = AngelTokensSacrifced[8];
            AngelTokensSacrifced9 = AngelTokensSacrifced[9];
            AngelTokensSacrifced10 = AngelTokensSacrifced[10];
            AngelTokensSacrifced11 = AngelTokensSacrifced[11];
            AngelTokensSacrificedTotal = tag.GetInt("AngelTokensSacrificedTotal");
    }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == false)
            {
                AngelStatueMessages = true;
                ResetAngelProgress();
            } else if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == true)
            {
                AngelStatueMessages = false;
                ResetAngelProgress();
            }
        }

            public void SpawnTier0() // Takes Away Life
        {
            if (player.statLife > 20)
            {
                player.statLife -= 20;
                switch (Main.rand.Next(0, 5))
                {
                    case 0:
                        player.QuickSpawnItem(ItemID.Heart, 1);
                        player.QuickSpawnItem(ItemID.CopperCoin, 1);
                        if (AngelStatueMessages) Main.NewText("No need to hurt yourself for me young child, but if you insist here is a gift.");
                        break;
                    case 1:
                        player.QuickSpawnItem(ItemID.Star, 1);
                        if (AngelStatueMessages) Main.NewText("Some mana for some life, I belive that is a fair trade.");
                        break;
                    case 2:
                        player.QuickSpawnItem(ItemID.Torch, 1);
                        if (AngelStatueMessages) Main.NewText("A little light to guide you on your journey.");
                        break;
                    case 3:
                        player.QuickSpawnItem(ItemID.OldShoe, 1);
                        if (AngelStatueMessages) Main.NewText("Have fun with it, I guess.");
                        break;
                    case 4:
                        player.QuickSpawnItem(ItemID.Acorn, 1);
                        if (AngelStatueMessages) Main.NewText("A bit of green to bring color to your otherwise gray life.");
                        break;
                    case 5:
                        if (AngelStatueMessages) Main.NewText("Why would I give you something? I have better things to do like nothing.");
                        break;
                }
            } else
            {
                if (AngelStatueMessages) Main.NewText("Just Stop.");
            }
            AngelTokensSacrifced0++;
        }
        public void SpawnTier1() // Pre Boss
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.Aglet, 1);
                    if (AngelStatueMessages) Main.NewText("Speed is the need! But shoelaces first.");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.IronskinPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Raise your iron will by drinking this potion.");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.ShinePotion, 1);
                    if (AngelStatueMessages) Main.NewText("Shine like a star! Or just a dim lightbulb.");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.SilverCoin, 1);
                    if (AngelStatueMessages) Main.NewText("Shiny, right? But this one isn't for you, here is a silver.");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.RecallPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Go back to where you came from! Trust me, it can be useful.");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Focus on your inside before your outside, actually work on your outside, you have some pretty nasty bruises right there.");
                    break;
            }
            AngelTokensSacrifced1++;
        }
        public void SpawnTier2() // Post Eye of Cthulhu
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced2++;
        }
        public void SpawnTier3() // Post Brain Of Cthulhu / Eater of Worlds
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced3++;
        }
        public void SpawnTier4() // Post Skeletron
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced4++;
        }
        public void SpawnTier5() // Pre Wall Of Flesh
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced5++;
        }
        public void SpawnTier6() // Early Hardmode
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced6++;
        }
        public void SpawnTier7() // Post Mechanical Bosses
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced7++;
        }
        public void SpawnTier8() // Post Plantera
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced8++;
        }
        public void SpawnTier9() // Pre Golem
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced9++;
        }
        public void SpawnTier10() // Lunar Events
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced10++;
        }
        public void SpawnTier11() // Post Moon Lord
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
                case 5:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced11++;
        }
        public void SpawnBlessing() // Blessing Token
        {
            int BlessingTime = 7200;

            //// Earlymode
            if (NPC.downedSlimeKing) BlessingTime += 3600; // King Slime
            if (NPC.downedBoss1) BlessingTime += 3600; // EoC
            if (NPC.downedBoss2) BlessingTime += 3600; // BoC / EoW
            if (NPC.downedQueenBee) BlessingTime += 3600; // Queen Bee
            if (NPC.downedBoss3) BlessingTime += 3600; // Skeletron
            if (Main.hardMode) BlessingTime += 3600; // Wall of Flesh

            //// Hardmode
            if (NPC.downedMechBoss1) BlessingTime += 3600; // Destroyer
            if (NPC.downedMechBoss2) BlessingTime += 3600; // Twins
            if (NPC.downedMechBoss3) BlessingTime += 3600; // Skeletron Prime
            if (NPC.downedPlantBoss) BlessingTime += 3600; // Plantera
            if (NPC.downedGolemBoss) BlessingTime += 3600; // Golem
            if (NPC.downedFishron) BlessingTime += 3600; // Duke Fishron

            //// Cultists +
            if (NPC.downedAncientCultist) BlessingTime += 3600; // Lunatic Cultist
            if (NPC.downedTowerSolar) BlessingTime += 3600; // Solar Pillar
            if (NPC.downedTowerVortex) BlessingTime += 3600; // Vortex Pillar
            if (NPC.downedTowerNebula) BlessingTime += 3600; // Nebula Pillar
            if (NPC.downedTowerStardust) BlessingTime += 3600; // Stardust Pillar
            if (NPC.downedMoonlord) BlessingTime += 3600; // Moon Lord

            //// Events
            if (NPC.downedGoblins) BlessingTime += 3600; // Goblin Invasion
            
            if (NPC.downedFrost) BlessingTime += 3600; // Frost Legion

            if (NPC.downedPirates) BlessingTime += 3600; // Pirate Invasion
            // Pumpkin Moon
            if (NPC.downedHalloweenTree) BlessingTime += 3600; // Mourning Wood
            if (NPC.downedHalloweenKing) BlessingTime += 3600; // Pumpking
            // Frost Moon
            if (NPC.downedChristmasTree) BlessingTime += 3600; // Everscream
            if (NPC.downedChristmasSantank) BlessingTime += 3600; // Santa NK-1
            if (NPC.downedChristmasIceQueen) BlessingTime += 3600; // Ice Queen

            if (NPC.downedMartians) BlessingTime += 3600; // Martian Madness

            //// 30 Possible Minutes
            if (Main.hardMode == true) {
                switch (Main.rand.Next(0, 4))
                {
                    case 0:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Damage
                        break;
                    case 1:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Health / Mana
                        break;
                    case 2:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Defense
                        break;
                    case 3:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Speed
                        break;
                    case 4:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Wings
                        break;
                }
            }
            else
            {
                switch (Main.rand.Next(0, 3))
                {
                    case 0:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Damage
                        break;
                    case 1:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Health / Mana
                        break;
                    case 2:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Defense
                        break;
                    case 3:
                        player.AddBuff(BuffID.AmmoBox, BlessingTime); // Blessing Speed
                        break;
                }
            }
        }

        public void ResetAngelProgress()
        {
            AngelTokensSacrifced0 = 0;
            AngelTokensSacrifced1 = 0;
            AngelTokensSacrifced2 = 0;
            AngelTokensSacrifced3 = 0;
            AngelTokensSacrifced4 = 0;
            AngelTokensSacrifced5 = 0;
            AngelTokensSacrifced6 = 0;
            AngelTokensSacrifced7 = 0;
            AngelTokensSacrifced8 = 0;
            AngelTokensSacrifced9 = 0;
            AngelTokensSacrifced10 = 0;
            AngelTokensSacrifced11 = 0;
            AngelTokensSacrificedTotal = 0;
        }
    }
}
