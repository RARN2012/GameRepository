/*
 * Sprite abstract class, that all sprites will extend
 * Copyright: Riese Narcisse & Rob Argue
 * Date: 12/21/2012
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RARN_Game.GameEngine
{
    abstract class Sprite
    {
        internal Texture2D image;
        internal Vector2 position;
        internal Vector2 velocity;
        internal Vector2 acceleration;
        internal Vector2 origin;
        internal Vector2 scale;
        internal Single angle;
        internal Single angularAcceleration;
        internal Single angularVelocity;
        internal Color color;
        internal SpriteEffects spriteDirection; 

        public Sprite(Texture2D anImage,Vector2 aPosition)
        {
            image = anImage;
            position = aPosition;
            velocity = new Vector2(0,0);
            acceleration = new Vector2(0,0);
            scale = new Vector2(1, 1);
            angle = 0;
            angularAcceleration = 0;
            angularVelocity = 0;
            color = Color.White;
            spriteDirection = SpriteEffects.None;
            origin = new Vector2(anImage.Width / 2, anImage.Height / 2);
        }

        /*
         * Method that updates the sprite
         * */
        internal virtual void Update(GameTime gameTime)
        {
            velocity += acceleration * gameTime.ElapsedGameTime.Milliseconds;
            position += velocity * gameTime.ElapsedGameTime.Milliseconds;

            angularVelocity += angularAcceleration * gameTime.ElapsedGameTime.Milliseconds;
            angle += angularVelocity * gameTime.ElapsedGameTime.Milliseconds;

            if (velocity.X < 0)
            {
                spriteDirection = SpriteEffects.FlipHorizontally;
            }
            if(velocity.X > 0)
            {
                spriteDirection = SpriteEffects.None;
            }
        }

        /*
         * Method that draws the sprite
         * */
        internal virtual void Draw(SpriteBatch spriteBatch,GameTime gameTime)
        {
            spriteBatch.Draw(image, position, null, color, 
                angle,origin, scale,spriteDirection, 0);
        }

        /*
         * Method that returns a bounding rectangle of
         * a Sprite, that also takes in to account scaling
         * */

        public virtual Rectangle getBoundingBox()
        {
            int width = (int)(image.Width * scale.X);
            int height = (int)(image.Height * scale.Y);

            Rectangle boundingBox = new Rectangle(width / 2, height / 2, width, height);

            return boundingBox;
        }

        /*
         * Method that returns a bool indicating whether
         * there was a hit or not
         * */
        public bool checkHit(Rectangle anotherBoundingBox)
        {
            return getBoundingBox().Intersects(anotherBoundingBox);
        }

    }
}
