using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThreeApplication
{
    public class BowAndArrow : AttackingWeapon
    {
        public BowAndArrow()
        {
            //The light damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            LightDamage = 15;

            //The heavy damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            HeavyDamage = 20;
        }
    }
}