using Microsoft.Xna.Framework;
using System;
using System.Runtime.InteropServices;
using Terraria;

namespace SymbioteMod.Components
{
    public abstract class TransformationState
    {
        private int _currentFrame;

        public TransformationState(string texturePath, int frameCount, int frameSpeed, bool autoloop = false, Vector2 drawOff = new Vector2())
        {
            TexturePath = texturePath;
            FrameCount = frameCount;
            FrameSpeed = frameSpeed;
            Autoloop = autoloop;
            DrawOffset = drawOff;
        }

        public void UpdateAnimation()
        {
            if(++FrameTime >= FrameSpeed)
            {
                if (++CurrentFrame >= FrameCount)
                {
                    if (!Autoloop)
                        Finished = true;
                    else
                    {
                        CurrentFrame = 0;
                        Finished = false;
                    }
                }
                FrameTime = 0;
            }
        }

        public abstract void UpdateState(Player player);

        public int CurrentFrame 
        { 
            get => _currentFrame; 
            set
            {
                _currentFrame = (int)MathHelper.Clamp(value, 0, FrameCount);
            }
        }

        public int FrameSpeed { get; set; }

        public bool Autoloop { get; set; }

        public bool Finished { get; private set; }

        public int FrameTime { get; private set; }

        public string TexturePath { get; set; }

        public int FrameCount { get; }

        public Vector2 DrawOffset { get; set; }

    }
}
