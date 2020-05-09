using SymbioteMod.Components;
using SymbioteMod.Players;
using Terraria;

namespace SymbioteMod.Symbiotes
{
    public class SpawnState : TransformationState
    {
        public SpawnState(string texturePath, int frameCount, int frameSpeed, bool autoloop = false) : base(texturePath, frameCount, frameSpeed, autoloop)
        {
        }

        public override void UpdateState(Player player)
        {
            SymbiotePlayer.Get(player).BlockControls = true;
        }
    }
}
