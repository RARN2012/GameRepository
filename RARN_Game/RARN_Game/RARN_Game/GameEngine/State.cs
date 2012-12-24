using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RARN_Game.GameEngine
{
    interface State
    {
        void Update(GameTime elapsedTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
