using Terraria;
using Terraria.ModLoader;

namespace SymbioteMod.Components
{
    public abstract class Transformation
    {
        public Transformation(string displayName)
        {
            DisplayName = displayName;
        }
        public abstract void UpdateTransformationStats(Player player);

        public abstract void ResetTransformationEffects(Player player);

        public virtual void OnTransform(Player player)
        { 
        }

        public TransformationState CurrentState { get; set; }

        public bool HasActiveState => CurrentState != null;

        public bool IsActive { get; set; }

        public string DisplayName { get; }

        public float HostSyncRate { get; set; }

        public bool ShouldHideHair { get; set; }

        public bool HasFullyCovered { get; set; }
    }
}
