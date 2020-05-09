using Terraria.ModLoader;

namespace SymbioteMod
{
    public static class SModInput
    {
        public static void LoadInput(Mod mod)
        {
            ActivateSymbiote = mod.RegisterHotKey("Transform", "Z");
        }

        public static void UnloadInput()
        {
            ActivateSymbiote = null;
        }

        public static ModHotKey ActivateSymbiote { get; private set; }
    }
}
