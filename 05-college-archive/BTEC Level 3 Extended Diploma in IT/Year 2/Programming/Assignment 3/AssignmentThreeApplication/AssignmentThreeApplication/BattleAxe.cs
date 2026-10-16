using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThreeApplication
{
    public class BattleAxe : AttackingWeapon
    {

        public BattleAxe()
        {
            //The light damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            LightDamage = 40;

            //The Heavy damage variable which is used within the Battle form to reduce the progress bar
            //For both opponent and player
            HeavyDamage = 50;
        }

    }
}