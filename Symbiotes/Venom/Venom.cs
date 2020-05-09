using SymbioteMod.Components;
using SymbioteMod.Players;
using Terraria;

namespace SymbioteMod.Symbiotes.Venom
{
    public sealed class Venom : Transformation
    {
        public Venom() : base("Venom")
        {
        }

        public override void ResetTransformationEffects(Player player)
        {
        }

        public override void UpdateTransformationStats(Player player)
        {
        }

        public override void OnTransform(Player player)
        {
            ShouldHideHair = false;
            HasFullyCovered = false;
            SymbiotePlayer.Get(player).SymbioteState = new VenomSpawn();
        }
    }
}
