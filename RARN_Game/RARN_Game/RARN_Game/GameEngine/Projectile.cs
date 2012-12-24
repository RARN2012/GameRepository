using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RARN_Game.GameEngine
{
    abstract class Projectile : ProjectileInterface
    {
        protected internal float myTravelSpeed;
        protected internal int myDamageDone;
        protected internal Vector2 myStartPosition;
        protected internal Texture2D myProjectileIMG;
        protected internal State myProjectileState;

        public Projectile(Texture2D projectileIMG,Vector2 startPos,
            float travelSpeed,int damageDone)
        {
            myProjectileIMG = projectileIMG;
            myStartPosition = startPos;
            myTravelSpeed = travelSpeed;
            myDamageDone = damageDone;
        }

        public float getProjectileSpeed()
        {
            return myTravelSpeed;
        }

        /*
         * Changes the state of the projectile to
         * a shot state. Every projectile must be able
         * to be shot
         * */
        public abstract void shootProjectile();

        public virtual void Update(GameTime gameTime)
        {
            if(myProjectileState!=null)
            myProjectileState.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch batch)
        {
            if(myProjectileState!=null)
            myProjectileState.Draw(batch);
        }
    }
}
