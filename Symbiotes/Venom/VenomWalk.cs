using Microsoft.Xna.Framework;
using SymbioteMod.Components;
using SymbioteMod.Players;
using Terraria;

namespace SymbioteMod.Symbiotes.Venom
{
    public sealed class VenomWalk : TransformationState
    {
        public VenomWalk() : base("Venom/Walk", 9, 5, true)
        {
            DrawOffset = new Vector2(0, -12);
        }

        public override void UpdateState(Player player)
        {
            if(!player.controlLeft && !player.controlRight)
                SymbiotePlayer.Get(player).SymbioteState = new VenomIdle();
        }
    }
}
