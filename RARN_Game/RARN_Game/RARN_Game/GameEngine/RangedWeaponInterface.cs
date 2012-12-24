using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RARN_Game.GameEngine
{
    interface RangedWeaponInterface
    {

     /*
      * Method to shoot the weaopon; All
      * RangedWeapons must have some sort of shoot
      * method.
      * */
      void shootWeapon();

      /*
       * Method to reload the weapon. This method
       * will be based off of clip size
       * */
      void reload();

      /*
       * Return the number of shots left
       * */
      int getNumberOfShots();
    }
}
