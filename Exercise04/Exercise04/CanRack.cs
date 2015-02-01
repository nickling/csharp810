using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Exercise04
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
            rack[0] = BINSIZE;
            rack[1] = BINSIZE;
            rack[2] = BINSIZE;
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
                Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
                if (FlavorOfCanToBeAdded == "regular")      rack[0] += 1;
                else if (FlavorOfCanToBeAdded == "orange")  rack[1] += 1;
                else if (FlavorOfCanToBeAdded == "lemon")   rack[2] += 1;
                else Debug.WriteLine("Error: attempt to add a can of unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
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
                Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                if (FlavorOfCanToBeRemoved == "regular")        rack[0] -= 1;
                else if (FlavorOfCanToBeRemoved == "orange")    rack[1] -= 1;
                else if (FlavorOfCanToBeRemoved == "lemon")     rack[2] -= 1;
                else Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
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
        public void EmptyCanRackOf(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "regular")        rack[0] = EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange")    rack[1] = EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon")     rack[2] = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToCheck)
        {
            EmptyCanRackOf(FlavorOfBinToCheck.ToString().ToLower());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular") result =       rack[0] == BINSIZE;
            else if (FlavorOfBinToCheck == "orange") result =   rack[1] == BINSIZE;
            else if (FlavorOfBinToCheck == "lemon") result =    rack[2] == BINSIZE;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        public Boolean IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString().ToLower()); 
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular") result =       rack[0] == EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange") result =   rack[1] == EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon") result =    rack[2] == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
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
            int count = 0;
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Console.WriteLine("{0} {1} cans remaining.", rack[count], flavorName);
                count++;
            }
        }

    } //end Can_Rack

}
