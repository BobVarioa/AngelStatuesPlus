using Terraria.ModLoader;

namespace AngelMod
{
    public enum BlessingBuffTypeID : int
    {
        Damage,
        Health,
        Defense,
        Speed,
        Wings
    }
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