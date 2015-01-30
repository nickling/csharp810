using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    // Enum of Flavors.
    public enum Flavor { REGULAR, ORANGE, LEMON }

    class Can
    {

        public readonly Flavor _flavor = Flavor.REGULAR; 
        // readonly can be assigned upon declaration (here) or in the constructor

        public Can()
        {
            // Defaults to _flavor.
        }

        // Define a flavor.
        public Can (Flavor AFlavor)
        {
            _flavor = AFlavor;
            // please note, we are not using this class to create new flavors (at this time!). we're sticking with 3 flavors
        }
    }
}
