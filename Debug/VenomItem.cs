using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using SymbioteMod.Players;
using SymbioteMod.Symbiotes.Venom;

namespace SymbioteMod.Debug
{
    public class VenomItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Venom DEBUG");
            Tooltip.SetDefault("Gives you Venom symbiote");
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingUp; 
        }

        public override bool UseItem(Player player)
        {
            SymbiotePlayer.Get(player).CurrentSymbiote = new Venom();
            return true;
        }
    }
}
