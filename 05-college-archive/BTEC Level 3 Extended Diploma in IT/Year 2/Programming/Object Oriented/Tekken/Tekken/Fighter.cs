using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tekken
{
    public class Fighter
    {
        // Properties (attributes) 
        public string Name;
        public int Damage;
        public int Hitpoints;

        // You can use the following to store more
        //  info about the fighter
        public String FightingStyle;
        public List<String> FightingStyleList;
        public List<String> SpecialAttributes;

        // Constructor (gets called upon instance creation)
        public Fighter()
        {
            FightingStyleList = new List<String> { } ;
            SpecialAttributes = new List<String> { };

        }

        // Override the ToString() method so 
        //  it returns extra information
        public override string ToString()
        {
            return this.Name + " (" + this.Damage.ToString() + "D," + this.Hitpoints.ToString() + "H)";
        }

        // You could add some special functionality in
        //  here, which could be overridden in one
        // or more of the derived classes (eg MarshallLaw)
        //  (change the method name to something more
        //  descriptive)
        public virtual void SomeMethod()
        {
            // Do something
        }


    }
}
