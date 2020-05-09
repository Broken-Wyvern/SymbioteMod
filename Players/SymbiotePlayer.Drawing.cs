using Terraria;
using SymbioteMod.PlayerLayers;
using SymbioteMod.Symbiotes;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace SymbioteMod.Players
{
    public sealed partial class SymbiotePlayer : ModPlayer
    {
        public override void ModifyDrawLayers(List<PlayerLayer> layers)
        {
            if (HasSymbiote && CurrentSymbiote.IsActive)
            {
                if (!CurrentSymbiote.HasActiveState)
                    return;


                if (SymbioteState is SpawnState && SymbioteState.CurrentFrame == 4)
                    layers.ForEach(x => Main.NewText(x.Name));

                int hair = layers.FindIndex(x => x.Name == "Head");

                int hairBack = layers.FindIndex(x => x.Name == "HairBack");

                if (CurrentSymbiote.ShouldHideHair)
                {
                    if (hair != -1)
                        layers.RemoveAt(hair);

                    if (hairBack != -1)
                        layers.RemoveAt(hairBack);
                }

                if(CurrentSymbiote.HasFullyCovered)
                    layers.RemoveAll(x => x.Name != "MiscEffectsFront");

                layers.Add(SymbioteLayer.SymbioteDrawLayer);
            }
        }
    }
}
