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
        private Dictionary<Flavor, int> rack = null;
        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            // initialize rack
            rack = new Dictionary<Flavor,int>();
            // iterate through each flavor value in the array
            foreach (Flavor flavorName in FlavorOps.AllFlavors)
            {                
                rack.Add(flavorName, BINSIZE);
            }
        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeAdded));   
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("*** Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                rack[FlavorOfCanToBeAdded]++;
            }
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeRemoved));
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("*** Failed attempt to remove a can of {0} from an empty rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
            else
            {
                Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                rack[FlavorOfCanToBeRemoved]--;
            }
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (Flavor flavorName in FlavorOps.AllFlavors)
            {
                rack[flavorName] = BINSIZE;
            }
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOps.ToFlavor(FlavorOfBinToBeEmptied));
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            //EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString().ToLower());
            if(Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied);
                rack[FlavorOfBinToBeEmptied] = EMPTYBIN;
            }
            else
            {
                Debug.WriteLine("Illegal attempt to empty bin of invalid flavor {0}", 
                    FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            }
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOps.ToFlavor(FlavorOfBinToBeChecked));
        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            //return IsFull(FlavorOfBinToBeChecked.ToString().ToLower()); 
            bool result = false;
            if (rack.ContainsKey(FlavorOfBinToBeChecked))
            {
                Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToBeChecked);
                result = rack[FlavorOfBinToBeChecked] == BINSIZE;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", 
                    FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOps.ToFlavor(FlavorOfBinToBeChecked));
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            bool result = false;
            if (rack.ContainsKey(FlavorOfBinToBeChecked))
            {
                Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToBeChecked);
                result = rack[FlavorOfBinToBeChecked] == EMPTYBIN;
            }
            else
            {
                Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", 
                    FlavorOfBinToBeChecked, DUMMYARGUMENT);
            }
            return result;
        }

        // write out the contents of the rack array
        // eg: one flavor per line with the flavor name and the # of cans of soda of that floavr
        public void DisplayCanRack()
        {
            Console.WriteLine(".NET C# Vending Machine contents");
            Console.WriteLine("________________________________");
            foreach (Flavor flavorName in FlavorOps.AllFlavors)
            {
                Console.WriteLine("{0}\t{1}", flavorName, rack[flavorName]);
            }
            Console.WriteLine("________________________________");
        }

    } //end Can_Rack

}
