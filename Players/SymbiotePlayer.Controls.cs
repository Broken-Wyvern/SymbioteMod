using Terraria.ModLoader;

namespace SymbioteMod.Players
{
    public sealed partial class SymbiotePlayer : ModPlayer
    {
        public override void SetControls()
        {
            if(BlockControls)
            {
                player.controlDown = false;
                player.controlHook = false;
                player.controlJump = false;
                player.controlLeft = false;
                player.controlRight = false;
                player.controlUp = false;
                player.controlUseItem = false;
                player.controlUseTile = false;
                player.controlTorch = false;
                player.controlMount = false;
            }
        }

        public bool BlockControls { get; set; }
    }
}
