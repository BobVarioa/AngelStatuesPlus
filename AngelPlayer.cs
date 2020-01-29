using AngelMod.Items;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Events;
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
        public int BlessingAngelTokensSacrifced = 0; 
        public int AngelTokensSacrificedTotal = 0;

        public int BlessingTime = 0;
        public int BlessingPower = 0;

        public int BlessingBuffType = 0;

        public override void ResetEffects()
        {
            PocketAngelStatue = false;
        }

        public override TagCompound Save()
        {
            var AngelTokensSacrifced = new List<int>();
            int ModVersion = 1000;
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
            AngelTokensSacrifced.Add(BlessingAngelTokensSacrifced);
            AngelTokensSacrifced.Add(AngelTokensSacrificedTotal);
            return new TagCompound {
				{"AngelTokensSacrifced", AngelTokensSacrifced},
                {"AngelStatuesPlusVersion", ModVersion}
            };
        }

        public override void Load(TagCompound tag)
        {
            int ModVersion = tag.GetInt("AngelStatuesPlusVersion");
            if (ModVersion == 1000)
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
                BlessingAngelTokensSacrifced = AngelTokensSacrifced[12];
                AngelTokensSacrificedTotal = AngelTokensSacrifced[13];
            }
        }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == false)
            {
                AngelStatueMessages = true;
                ResetProgress(false);
            } else if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == true)
            {
                AngelStatueMessages = false;
                ResetProgress(false);
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
            AngelTokensSacrificedTotal -= 1;
        }
        public void SpawnTier1() // Pre Boss
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.IronskinPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Raise your iron will by drinking this potion.");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.ShinePotion, 1);
                    if (AngelStatueMessages) Main.NewText("Shine like a star! Or just a dim lightbulb.");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.SilverCoin, 1);
                    if (AngelStatueMessages) Main.NewText("Shiny, right? But this one isn't for you, here is a silver.");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.RecallPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Go back to where you came from! Trust me, it can be useful.");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Focus on your inside before your outside, actually work on your outside, you have some pretty nasty bruises right there.");
                    break;
            }
            AngelTokensSacrifced1++;
            AngelTokensSacrificedTotal += 1;
        }
        public void SpawnTier2() // Post Eye of Cthulhu
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.Aglet, 1);
                    if (AngelStatueMessages) Main.NewText("Speed is the need! But shoelaces first.");
                    break;
                case 1:
                    if (WorldGen.crimson) 
                    {
                        player.QuickSpawnItem(ItemID.CrimtaneBar, Main.rand.Next(2, 5));
                    } else
                    {
                        player.QuickSpawnItem(ItemID.DemoniteBar, Main.rand.Next(2, 5));
                    }
                    if (AngelStatueMessages) Main.NewText("Have some mystical metals I found.");
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
            }
            AngelTokensSacrifced2++;
            AngelTokensSacrificedTotal += 10;
        }
        public void SpawnTier3() // Post Brain Of Cthulhu / Eater of Worlds
        {
            switch (Main.rand.Next(0, 4))
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
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Mediocre Bundle o' Buffs : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced3++;
            AngelTokensSacrificedTotal += 20;
        }
        public void SpawnTier4() // Post Skeletron
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.LockBox, 1);
                    if (AngelStatueMessages) Main.NewText("Life's full of mysteries, this one doesn't have a key.");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.GoldenKey, 1);
                    if (AngelStatueMessages) Main.NewText("Unlock your hopes and dreams, or just a chest. It's up to you.");
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
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Mediocre Blessing Token : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced4++;
            AngelTokensSacrificedTotal += 30;
        }
        public void SpawnTier5() // Pre Wall Of Flesh
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.HealingPotion, 1);
                    if (AngelStatueMessages) Main.NewText("Heal your brain and body with this magical drink.");
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
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Lesser Bundle o' Buffs : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced5++;
            AngelTokensSacrificedTotal += 40;
        }
        public void SpawnTier6() // Early Hardmode
        {
            switch (Main.rand.Next(0, 4))
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
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Bundle o' Buffs : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced6++;
            AngelTokensSacrificedTotal += 50;
        }
        public void SpawnTier7() // Post Mechanical Bosses
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.SoulofFright, 5);
                    player.QuickSpawnItem(ItemID.SoulofMight, 5);
                    player.QuickSpawnItem(ItemID.SoulofSight, 5);
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, 5);
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1);
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.SoulofFlight, 10);
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.LifeforcePotion, 1);
                    break;
            }
            if (AngelStatueMessages && AngelTokensSacrifced7 == 0) Main.NewText("You've done well so far beating the lunatic's creatitions, I think it's time to reward you greatly.");
            if (AngelStatueMessages && AngelTokensSacrifced7 > 0) Main.NewText("Thank you for helping the world, here's a gift.");
            AngelTokensSacrifced7++;
            AngelTokensSacrificedTotal += 60;
        }
        public void SpawnTier8() // Post Plantera
        {
            switch (Main.rand.Next(0, 4))
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
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Greater Blessing Token : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced8++;
            AngelTokensSacrificedTotal += 70;
        }
        public void SpawnTier9() // Post Golem
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.PlanteraBossBag, 1);
                    if (AngelStatueMessages) Main.NewText("You probably need this more than me, don't have a green thumb anyways.");
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, 20);
                    if (AngelStatueMessages) Main.NewText("Heal your body, mind, and soul.");
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.BrokenHeroSword, 1);
                    if (AngelStatueMessages) Main.NewText("The sword of one of my fallen champions, maybe you can put it to good use.");
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.SolarTablet, 2);
                    if (AngelStatueMessages) Main.NewText("Eclipse your enemies and Shadow your evils.");
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Greater Bundle o' Buffs : TODO
                    if (AngelStatueMessages) Main.NewText("...");
                    break;
            }
            AngelTokensSacrifced9++;
            AngelTokensSacrificedTotal += 80;
        }
        public void SpawnTier10() // Lunar Events
        {
            if (AngelStatueMessages && !NPC.LunarApocalypseIsUp) Main.NewText("Beat the Lunatic, now beat his master!");
            if (AngelStatueMessages && NPC.LunarApocalypseIsUp) Main.NewText("The events are over but is the evil truly gone?");
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.SuperHealingPotion, 5);
                    player.QuickSpawnItem(ItemID.SuperManaPotion, 5);
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.PlatinumCoin, Main.rand.Next(1, 2));
                    break;
                case 2:
                    player.QuickSpawnItem(ModContent.ItemType<AngelTokenTier9>(), 5);
                    break;
                case 3:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Blessing Token : TODO
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Supreme Bundle o' Buffs : TODO
                    break;
            }
            AngelTokensSacrifced10++;
            AngelTokensSacrificedTotal += 90;
        }
        public void SpawnTier11() // Post Moon Lord
        {
            switch (Main.rand.Next(0, 4))
            {
                case 0:
                    player.QuickSpawnItem(ItemID.SuperHealingPotion, 5);
                    player.QuickSpawnItem(ItemID.SuperManaPotion, 5);
                    break;
                case 1:
                    player.QuickSpawnItem(ItemID.PlatinumCoin, Main.rand.Next(2,4));
                    break;
                case 2:
                    player.QuickSpawnItem(ItemID.MoonLordBossBag, 1);
                    break;
                case 3:
                    player.QuickSpawnItem(ModContent.ItemType<BlessingAngelToken>(), 1); 
                    break;
                case 4:
                    player.QuickSpawnItem(ItemID.AngelStatue, 1); // Supreme Bundle O' Buffs : TODO
                    break;
            }
            if (AngelStatueMessages && AngelTokensSacrifced11 == 0) Main.NewText("You've done it! You beat Cthulhu's Brother, the Moon Lord. Thank you for gifting us true freedom.");
            if (AngelStatueMessages && AngelTokensSacrifced11 > 0) Main.NewText("I am forever in your debt, great hero.");
            AngelTokensSacrifced11++;
            AngelTokensSacrificedTotal += 100;
        }
        public void CalcBlessing() 
        {
            int TempBlessingTime = 7200;
            int TempBlessingPower = 2;

            //// Earlymode
            if (NPC.downedSlimeKing) TempBlessingTime += 3600; TempBlessingPower += 1; // King Slime
            if (NPC.downedBoss1) TempBlessingTime += 3600; TempBlessingPower += 1; // EoC
            if (NPC.downedBoss2) TempBlessingTime += 3600; TempBlessingPower += 1; // BoC / EoW
            if (NPC.downedQueenBee) TempBlessingTime += 3600; TempBlessingPower += 1; // Queen Bee
            if (NPC.downedBoss3) TempBlessingTime += 3600; TempBlessingPower += 1; // Skeletron
            if (Main.hardMode) TempBlessingTime += 3600; TempBlessingPower += 1; // Wall of Flesh

            //// Hardmode
            if (NPC.downedMechBoss1) TempBlessingTime += 3600; TempBlessingPower += 1; // Destroyer
            if (NPC.downedMechBoss2) TempBlessingTime += 3600; TempBlessingPower += 1; // Twins
            if (NPC.downedMechBoss3) TempBlessingTime += 3600; TempBlessingPower += 1; // Skeletron Prime
            if (NPC.downedPlantBoss) TempBlessingTime += 3600; TempBlessingPower += 1; // Plantera
            if (NPC.downedGolemBoss) TempBlessingTime += 3600; TempBlessingPower += 1; // Golem
            if (NPC.downedFishron) TempBlessingTime += 3600; TempBlessingPower += 1; // Duke Fishron

            //// Cultists +
            if (NPC.downedAncientCultist) TempBlessingTime += 3600; TempBlessingPower += 1; // Lunatic Cultist
            if (NPC.downedTowerSolar) TempBlessingTime += 3600; TempBlessingPower += 1; // Solar Pillar
            if (NPC.downedTowerVortex) TempBlessingTime += 3600; TempBlessingPower += 1; // Vortex Pillar
            if (NPC.downedTowerNebula) TempBlessingTime += 3600; TempBlessingPower += 1; // Nebula Pillar
            if (NPC.downedTowerStardust) TempBlessingTime += 3600; TempBlessingPower += 1; // Stardust Pillar
            if (NPC.downedMoonlord) TempBlessingTime += 3600; TempBlessingPower += 1; // Moon Lord

            //// Events
            if (NPC.downedGoblins) TempBlessingTime += 3600; TempBlessingPower += 1; // Goblin Invasion

            if (NPC.downedFrost) TempBlessingTime += 3600; TempBlessingPower += 1; // Frost Legion

            if (NPC.downedPirates) TempBlessingTime += 3600; TempBlessingPower += 1; // Pirate Invasion
            // Pumpkin Moon
            if (NPC.downedHalloweenTree) TempBlessingTime += 3600; TempBlessingPower += 1; // Mourning Wood
            if (NPC.downedHalloweenKing) TempBlessingTime += 3600; TempBlessingPower += 1; // Pumpking
            // Frost Moon
            if (NPC.downedChristmasTree) TempBlessingTime += 3600; TempBlessingPower += 1; // Everscream
            if (NPC.downedChristmasSantank) TempBlessingTime += 3600; TempBlessingPower += 1; // Santa NK-1
            if (NPC.downedChristmasIceQueen) TempBlessingTime += 3600; TempBlessingPower += 1; // Ice Queen

            if (NPC.downedMartians) TempBlessingTime += 3600; TempBlessingPower += 1; // Martian Madness

            //// 30 Possible Minutes
            BlessingTime = TempBlessingTime;
            BlessingPower = TempBlessingPower;
        }
        public void ChooseBlessing() // Blessing Token
        {
            CalcBlessing();

            if (Main.hardMode == true) {
                switch (Main.rand.Next(0, 4))
                {
                    case 0:
                        player.AddBuff(ModContent.BuffType<Buffs.DamageBlessing>(), BlessingTime); // Blessing Damage
                        break;
                    case 1:
                        player.AddBuff(ModContent.BuffType<Buffs.HealthBlessing>(), BlessingTime); // Blessing Health
                        break;
                    case 2:
                        player.AddBuff(ModContent.BuffType<Buffs.DefenseBlessing>(), BlessingTime); // Blessing Defense
                        break;
                    case 3:
                        player.AddBuff(ModContent.BuffType<Buffs.SpeedBlessing>(), BlessingTime); // Blessing Speed
                        break;
                    case 4:
                        player.AddBuff(ModContent.BuffType<Buffs.WingsBlessing>(), BlessingTime); // Blessing Wings
                        break;
                }
            }
            else
            {
                switch (Main.rand.Next(0, 3))
                {
                    case 0:
                        player.AddBuff(ModContent.BuffType<Buffs.DamageBlessing>(), BlessingTime); // Blessing Damage
                        break;
                    case 1:
                        player.AddBuff(ModContent.BuffType<Buffs.HealthBlessing>(), BlessingTime); // Blessing Health / Mana
                        break;
                    case 2:
                        player.AddBuff(ModContent.BuffType<Buffs.DefenseBlessing>(), BlessingTime); // Blessing Defense
                        break;
                    case 3:
                        player.AddBuff(ModContent.BuffType<Buffs.SpeedBlessing>(), BlessingTime); // Blessing Speed
                        break;
                }
            }
        }

        public void BlessingBuff()
        {
            CalcBlessing();
            switch (BlessingBuffType) 
            {
                case (int)BlessingBuffTypeID.Damage:
                    player.allDamageMult += BlessingPower;
                    break;
                case (int)BlessingBuffTypeID.Health:
                    player.statLifeMax2 += 5 * BlessingPower;
                    break;
                case (int)BlessingBuffTypeID.Defense:
                    player.statDefense += BlessingPower;
                    player.endurance += (BlessingPower / 2);
                    break;
                case (int)BlessingBuffTypeID.Speed:
                    player.maxRunSpeed += (BlessingPower / 3);
                    break;
                case (int)BlessingBuffTypeID.Wings:
                    player.wingTimeMax += (BlessingPower / 3);
                    break;
            }
        }

        public void ResetProgress(bool total = true)
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

            if (total == true)
            {
                NPC.downedSlimeKing = false;// King Slime
                NPC.downedBoss1 = false;// EoC
                NPC.downedBoss2 = false;// BoC / EoW
                NPC.downedQueenBee = false;// Queen Bee
                NPC.downedBoss3 = false;// Skeletron
                Main.hardMode = false;// Wall of Flesh

                //// Hardmode
                NPC.downedMechBoss1 = false;// Destroyer
                NPC.downedMechBoss2 = false;// Twins
                NPC.downedMechBoss3 = false;// Skeletron Prime
                NPC.downedPlantBoss = false;// Plantera
                NPC.downedGolemBoss = false;// Golem
                NPC.downedFishron = false;// Duke Fishron

                //// Cultists +
                NPC.downedAncientCultist = false;// Lunatic Cultist
                NPC.downedTowerSolar = false;// Solar Pillar
                NPC.downedTowerVortex = false;// Vortex Pillar
                NPC.downedTowerNebula = false;// Nebula Pillar
                NPC.downedTowerStardust = false;// Stardust Pillar
                NPC.downedMoonlord = false;// Moon Lord

                //// Events
                NPC.downedGoblins = false;// Goblin Invasion

                NPC.downedFrost = false;// Frost Legion

                NPC.downedPirates = false;// Pirate Invasion
                                          // Pumpkin Moon
                NPC.downedHalloweenTree = false;// Mourning Wood
                NPC.downedHalloweenKing = false;// Pumpking
                                                // Frost Moon
                NPC.downedChristmasTree = false;// Everscream
                NPC.downedChristmasSantank = false;// Santa NK-1
                NPC.downedChristmasIceQueen = false;// Ice Queen

                NPC.downedMartians = false;// Martian Madness
            }
        }
    }
}
