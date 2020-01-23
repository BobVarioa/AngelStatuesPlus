using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod
{
    class AngelPlayer : ModPlayer
    {
        public bool AngelStatueMessages = true;
        public bool PocketAngelStatue = false;

        public override void ResetEffects()
        {
            PocketAngelStatue = false;
        }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == false)
            {
                AngelStatueMessages = true;
            } else if (AngelMod.AngelStatueMessagesToggle.JustPressed && AngelStatueMessages == true)
            {
                AngelStatueMessages = false;
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
                    if (AngelStatueMessages) Main.NewText("Work on your inside before your outside, actually focus on your outside, you have some pretty nasty bruises right there.");
                    break;
            }
        }
        public void SpawnTier2() // Post Eye of Cthulhu
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier3() // Post Brain Of Cthulhu / Eater of Worlds
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier4() // Post Skeletron
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier5() // Pre Wall Of Flesh
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier6() // Early Hardmode
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier7() // Post Mechanical Bosses
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier8() // Post Plantera
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier9() // Pre Golem
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier10() // Lunar Events
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }
        public void SpawnTier11() // Post Moon Lord
        {
            switch (Main.rand.Next(0, 5))
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
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
    }
}
