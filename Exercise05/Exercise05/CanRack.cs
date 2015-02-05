using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Exercise05
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).


    class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            // iterate through each flavor value in the array
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = BINSIZE;
            }
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("*** Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
            else
            {
                // convert the string Flavor into the appropriate int value
                Flavor flavorEnumeral;
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded) &&
                    Enum.TryParse<Flavor>(FlavorOfCanToBeAdded, out flavorEnumeral))
                {
                    Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                    int flavorIndex = (int)flavorEnumeral;
                    rack[flavorIndex]++;
                }
                else
                {
                    Debug.WriteLine("Error: attempt to add a can of unknown flavor {0}", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                }
            }      
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString().ToLower());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("*** Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                // convert the string Flavor into the appropriate int value
                Flavor flavorEnumeral;
                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved) &&
                    Enum.TryParse<Flavor>(FlavorOfCanToBeRemoved, out flavorEnumeral))
                {
                    Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                    int flavorIndex = (int)flavorEnumeral;
                    rack[flavorIndex]--;
                }
                else
                {
                    Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0}", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                }
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString().ToLower());
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavorValue] = BINSIZE;
            }
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied);
                Flavor f = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeEmptied);
                rack[(int)f] = EMPTYBIN;
            }
            else
            {
                Debug.WriteLine("Illegal attempt to empty bin of invalid flavor {0}",
                    FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString().ToLower());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            Boolean result = false;
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeChecked) &&
                Enum.TryParse<Flavor>(FlavorOfBinToBeChecked, out flavorEnumeral))
            {
                Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToBeChecked);
                int flavorIndex = (int)flavorEnumeral;
                result = rack[flavorIndex] == BINSIZE;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString().ToLower()); 
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            bool result = false;
            // convert the string Flavor into the appropriate int value
            Flavor flavorEnumeral;
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeChecked) &&
                Enum.TryParse<Flavor>(FlavorOfBinToBeChecked, out flavorEnumeral))
            {
                Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked);
                int flavorIndex = (int)flavorEnumeral;
                result = rack[flavorIndex] == EMPTYBIN;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            return IsEmpty(FlavorOfBinToCheck.ToString().ToLower());
        }

        // write out the contents of the rack array
        // eg: one flavor per line with the flavor name and the # of cans of soda of that floavr
        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Vending Machine contents");
            Console.WriteLine("________________________________");
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnumeral = (Flavor)Enum.Parse(typeof(Flavor), flavorName);
                int flavorIndex = (int)flavorEnumeral;
                Console.WriteLine("{0}\t{1}", flavorName, rack[flavorIndex]);
            }
            Console.WriteLine("________________________________");
        }

    } //end Can_Rack

}
