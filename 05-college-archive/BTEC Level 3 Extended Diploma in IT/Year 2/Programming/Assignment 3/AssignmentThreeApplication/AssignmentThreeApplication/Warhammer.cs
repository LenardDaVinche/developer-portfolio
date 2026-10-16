using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThreeApplication
{
    public class Warhammer : AttackingWeapon
    {

        public Warhammer()
        {
            //The light damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            LightDamage = 35;

            //The Heavy damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            HeavyDamage = 45;
        }
    }
}