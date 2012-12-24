using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using RARN_Game.GameEngine;
using RARN_Game.Projectiles;

namespace RARN_Game.RangedWeapons
{
    class Pistol:RangedWeapon
    {
        public Pistol(Texture2D pistolImage, Vector2 startPos, int clipSize,
            Projectile aProjectile) :
            base(pistolImage, startPos, clipSize,aProjectile)
        {
            myImage = pistolImage;
            myImagePos = startPos;
            myClipSize = clipSize;
            myProjectile = aProjectile;
            myWeaponState = new ShownState(this);
        }

        class ShownState : State
        {
            private RangedWeapon thePistol;

            public ShownState(RangedWeapon aPistol)
            {
                thePistol = aPistol;
            }

            public void Update(GameTime elapsedTime)
            {
                
            }

            public void Draw(SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(thePistol.myImage,
                    thePistol.myImagePos
                    , Color.White);
            }
        }
    }
}
