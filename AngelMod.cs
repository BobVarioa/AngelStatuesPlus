using Terraria.ModLoader;

namespace AngelMod
{
    public class AngelMod : Mod
    {
        public static ModHotKey AngelStatueMessagesToggle;

        public AngelMod()
        {
        }

        public override void Load()
        {
            AngelStatueMessagesToggle = RegisterHotKey("AngelStatueMessagesToggle", "K");
        }


        public override void Unload()
        {
            AngelStatueMessagesToggle = null;
        }
    }
}