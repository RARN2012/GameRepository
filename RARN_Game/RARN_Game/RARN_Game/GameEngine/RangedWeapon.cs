using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RARN_Game.GameEngine
{
    abstract class RangedWeapon : RangedWeaponInterface
    {
        protected internal Stack<Projectile> myClip;
        protected internal int myClipSize;
        protected internal Texture2D myImage;
        protected internal Vector2 myImagePos;
        protected internal State myWeaponState;
        protected internal Projectile myProjectile;


        public RangedWeapon(Texture2D image,Vector2 imagePos,int clipSize
            ,Projectile aProjectile)
        {
            myClip = new Stack<Projectile>();
            myClipSize = clipSize;
            myImage = image;
            myImagePos = imagePos;
            myProjectile = aProjectile;
            reload();
        }

        public void shootWeapon()
        {
            if (myClip.Count > 0)
            {
                myClip.Pop().shootProjectile();
            }
        }

        public void reload()
        {
            while (myClip.Count() < myClipSize)
            {
                myClip.Push(myProjectile);
            }
        }

        public int getNumberOfShots()
        {
            return myClip.Count();
        }

        public virtual void Update(GameTime gameTime)
        {
            if(myWeaponState!= null)
            myWeaponState.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch batch)
        {
            if(myWeaponState!=null)
            myWeaponState.Draw(batch);
        }
    }
}
