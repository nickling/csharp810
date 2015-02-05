using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Exercise05
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();
        private const int DUMMYARGUMENT = 0;
        static FlavorOps()
        {
            //_allFlavors = 
            foreach (Flavor flavor in Enum.GetValues(typeof(Flavor)))
            {
                _allFlavors.Add(flavor);
            }
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper().Trim();
            Flavor flavorEnumeral;
            if (Enum.TryParse<Flavor>(FlavorName, out flavorEnumeral))
            {
                Debug.WriteLine("Successfully converted string: {0} into Flavor enum: {1}", 
                    FlavorName, flavorEnumeral);
            }
            else
            {
                Debug.WriteLine("Error: attempt to convert unknown string value into enumeral: {0}", FlavorName, DUMMYARGUMENT);
            }
            return flavorEnumeral;
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
