using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise05
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {

        }

        // 
        public static Flavor ToFlavor(string FlavorName)
        {
            
            
            return Flavor.LEMON;
        }

        // property to return a List<Flavor> of all the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }
    }
}
