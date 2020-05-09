using Microsoft.Xna.Framework;
using SymbioteMod.Players;
using Terraria;

namespace SymbioteMod.Symbiotes.Venom
{
    public sealed class VenomSpawn : SpawnState
    {
        public VenomSpawn() : base("Venom/Transformation", 12, 4)
        {
            DrawOffset = new Vector2(0, -8);
        }

        public override void UpdateState(Player player)
        {
            base.UpdateState(player);

            if (Finished)
                SymbiotePlayer.Get(player).SymbioteState = new VenomIdle();

            if (CurrentFrame == 4)
                SymbiotePlayer.Get(player).CurrentSymbiote.ShouldHideHair = true;

            if(CurrentFrame == 8)
                SymbiotePlayer.Get(player).CurrentSymbiote.HasFullyCovered = true;
        }
    }
}
