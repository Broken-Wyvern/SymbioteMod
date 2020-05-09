using SymbioteMod.Components;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace SymbioteMod.Players
{
    public sealed partial class SymbiotePlayer : ModPlayer
    {
        public override void Initialize()
        {
            CurrentSymbiote = null;
        }

        public override void PreUpdate()
        {
            if (HasSymbiote && CurrentSymbiote.IsActive)
                CurrentSymbiote?.UpdateTransformationStats(player);
        }

        public override void PostUpdate()
        {
            if (HasSymbiote && CurrentSymbiote.IsActive)
                CurrentSymbiote?.UpdateTransformationStats(player);

            if (HasSymbiote && SymbioteState != null)
                SymbioteState.UpdateAnimation();
        }

        public override void ResetEffects()
        {
            BlockControls = false;

            if (HasSymbiote && CurrentSymbiote.IsActive)
            {
                if (SymbioteState != null)
                {
                    SymbioteState.UpdateState(player);
                }

                CurrentSymbiote?.ResetTransformationEffects(player);
            }
        }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (HasSymbiote)
            {
                if (SModInput.ActivateSymbiote.JustPressed)
                {
                    CurrentSymbiote.IsActive = !CurrentSymbiote.IsActive;
                    CurrentSymbiote.OnTransform(player);
                }
            }
        }

        public Transformation CurrentSymbiote { get; set; }

        public bool HasSymbiote => CurrentSymbiote != null;

        public TransformationState SymbioteState
        {
            get => CurrentSymbiote.CurrentState;
            set => CurrentSymbiote.CurrentState = value;
        }

        public static SymbiotePlayer Get(Player player) => player.GetModPlayer<SymbiotePlayer>();

        public static SymbiotePlayer GetLocal() => Main.LocalPlayer.GetModPlayer<SymbiotePlayer>();
    }
}
