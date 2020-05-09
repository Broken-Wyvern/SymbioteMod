using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using SymbioteMod.Players;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using SymbioteMod.Components;

namespace SymbioteMod.PlayerLayers
{
    public static class SymbioteLayer
    {
        public static readonly PlayerLayer SymbioteDrawLayer = new PlayerLayer("SymbioteMod", "SymbioteLayer", PlayerLayer.MiscEffectsFront, delegate (PlayerDrawInfo drawInfo)
        {
            if (drawInfo.shadow != 0f)
                return;

            Player drawPlayer = drawInfo.drawPlayer;

            SymbiotePlayer sPlayer = SymbiotePlayer.Get(drawPlayer);

            if (drawPlayer.dead || !sPlayer.HasSymbiote || !sPlayer.CurrentSymbiote.HasActiveState)
                return;

            TransformationState state = sPlayer.CurrentSymbiote.CurrentState;

            Texture2D texture = ModContent.GetTexture("SymbioteMod/Symbiotes/" + sPlayer.CurrentSymbiote.CurrentState.TexturePath);

            int textureWidth = (int)texture.Width;
            int textureHeight = (int)(texture.Height / state.FrameCount);

            Color drawColor = Lighting.GetColor((int)drawPlayer.Center.X / 16, (int)drawPlayer.Center.Y / 16);

            Vector2 drawPosition = drawPlayer.Center + new Vector2(state.DrawOffset.X, state.DrawOffset.Y + drawPlayer.gfxOffY);

            Rectangle sourceRect = new Rectangle(0, textureHeight * state.CurrentFrame, textureWidth, textureHeight);

            Vector2 origin = new Vector2(textureWidth * 0.5f, textureHeight * 0.5f);

            SpriteEffects sfx = drawPlayer.direction == 1 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;

            DrawData symbioteDrawData = new DrawData
            (
                texture,
                drawPosition - Main.screenPosition,
                sourceRect,
                drawColor,
                drawPlayer.fullRotation,
                origin,
                2f,
                sfx,
                1
            );

            Main.playerDrawData.Add(symbioteDrawData);
        });
    }
}
