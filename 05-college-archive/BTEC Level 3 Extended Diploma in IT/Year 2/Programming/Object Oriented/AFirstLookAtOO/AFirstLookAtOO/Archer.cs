using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFirstLookAtOO
{
    class Archer
    {
        public string Name;
        public int Level;
        public int Hitpoints;
        public int Damage;

        public void Move()
        {

        }

        public bool Attack(Archer Defender)
        {
            if(this.Level > Defender.Level)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}
