using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RARN_Game.GameEngine;

namespace RARN_Game.Projectiles
{
    class Bullet : Projectile
    {
        public Bullet(Texture2D bulletImage, Vector2 startPos,
            float travelSpeed,int damageDone)
            : base(bulletImage, startPos, travelSpeed,damageDone)
        {
            myProjectileIMG = bulletImage;
            myStartPosition = startPos;
            myTravelSpeed = travelSpeed;
            myDamageDone = damageDone;
            myProjectileState = new RestingState(this);
        }
        public override void shootProjectile()
        {
            myProjectileState = new ShotState(this);
        }

        class RestingState : State
        {
            private Projectile theBullet;

            public RestingState(Projectile aBullet)
            {
                theBullet = aBullet;
                theBullet.myStartPosition = new Vector2(100, 100);
            }

            public void Update(GameTime elapsedTime)
            {

            }

            public void Draw(SpriteBatch spriteBatch)
            {

            }
        }

        class ShotState : State
        {
            private Projectile theBullet;

            public ShotState(Projectile aBullet)
            {
                theBullet = aBullet;
            }

            public void Update(GameTime elapsedTime)
            {
                theBullet.myStartPosition.X += theBullet.myTravelSpeed;
                //if (theBullet.myStartPosition.X > 500)
                //{
                    //theBullet.myProjectileState = new RestingState(theBullet);
                //}
            }

            public void Draw(SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(theBullet.myProjectileIMG,
                    theBullet.myStartPosition
                    ,Color.White);
            }
        }
    }
}
