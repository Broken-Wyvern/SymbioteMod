using SymbioteMod.Players;
using Terraria;
using Terraria.ModLoader;

namespace SymbioteMod.Items
{
    public sealed partial class SymbioteGlobalItem : GlobalItem
    {
        // Makes sure that once player is transformed, they cannot use any items
        public override bool CanUseItem(Item item, Player player) => !(SymbiotePlayer.Get(player).CurrentSymbiote != null && SymbiotePlayer.Get(player).CurrentSymbiote.IsActive);
    }
}
