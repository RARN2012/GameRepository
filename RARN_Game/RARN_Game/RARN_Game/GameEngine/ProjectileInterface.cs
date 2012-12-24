using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Projectile interface; All projecticles should
 * implement this interface; It is recommended to
 * use some sort of collection when making projectiles
 * */
namespace RARN_Game.GameEngine
{
    interface ProjectileInterface
    {
        /*
         * Get the speed the projectile can
         * travel
         * */
        float getProjectileSpeed();
    }
}
