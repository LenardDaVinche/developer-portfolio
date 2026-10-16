using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFirstLookAtOOP
{
    class Giant
    {
        // Properties
        public string Name;
        public int Level;
        public int HitPoints;
        public int Damage;

        // Methods
        public void Move()
        {

        }

        public bool Attack(Giant Defender)
        {
            if (this.Level > Defender.Level)
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
