using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RARN_Game.GameEngine
{
    class Character:Sprite
    {
        public Character(Texture2D aTexture, Vector2 position) :
            base (aTexture,position)
        {

        }
    }
}
