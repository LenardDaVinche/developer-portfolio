using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThreeApplication
{
    public class LongSword : AttackingWeapon
    {

        public LongSword()
        {
            //The light damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            LightDamage = 20;

            //The Heavy damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            HeavyDamage = 35;
        }

        public override void Attack()
        {

        }

    }
}