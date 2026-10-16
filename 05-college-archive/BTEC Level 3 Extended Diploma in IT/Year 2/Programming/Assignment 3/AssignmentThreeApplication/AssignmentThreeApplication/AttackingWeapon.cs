using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThreeApplication
{
    public abstract class AttackingWeapon
    {
        private int Weapon;

        //The light damage variable which is used within the Battle form to reduce the progress bar
        //For both opponent and player
        public int LightDamage = 10;

        //The Heavy damage variable which is used within the Battle form to reduce the progress bar
        //For both opponent and player
        public int HeavyDamage = 15;

        public virtual void Attack()
        {
            
        }

        public virtual void Attack(string a)
        {
            
        }

    }
}