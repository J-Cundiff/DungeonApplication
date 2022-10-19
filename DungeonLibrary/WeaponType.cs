using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public enum WeaponType
    {
        //We want the player's weapon type to be one of a preset list of options.
        //If you want to do you own items. do not set values in enums!!
        //enums = indexes only
        Sword,
        Knife,
        Projectile,
        Magical,
        Elemental
    }
}
