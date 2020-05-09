using Microsoft.Xna.Framework;
using SymbioteMod.Components;
using SymbioteMod.Players;
using Terraria;

namespace SymbioteMod.Symbiotes.Venom
{
    public class VenomIdle : TransformationState
    {
        public VenomIdle() : base("Venom/Idle", 7, 6, true)
        {
            DrawOffset = new Vector2(0, -6);
        }

        public override void UpdateState(Player player)
        {
            if (player.controlLeft || player.controlRight)
                SymbiotePlayer.Get(player).SymbioteState = new VenomWalk();
        }
    }
}
