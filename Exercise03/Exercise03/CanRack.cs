using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Exercise03
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
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
                if (FlavorOfCanToBeAdded == "regular") regular = regular + 1;
                else if (FlavorOfCanToBeAdded == "orange") orange = orange + 1;
                else if (FlavorOfCanToBeAdded == "lemon") lemon = lemon + 1;
                else Debug.WriteLine("Error: attempt to add a can of unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            // TODO add a can
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
                if (FlavorOfCanToBeRemoved == "regular") regular = regular - 1;
                else if (FlavorOfCanToBeRemoved == "orange") orange = orange - 1;
                else if (FlavorOfCanToBeRemoved == "lemon") lemon = lemon - 1;
                else Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            // TODO remove a can
           
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;

            // TODO: do we need to fill all of them? how do we find all the instances?

            // TODO : this will be useful code for comparison.
            Flavor AFlavor;
            string myInput = Console.ReadLine();
            bool success = Enum.TryParse<Flavor>(myInput, out AFlavor);

            // conversion when using the enumerator;
            // string.ToUpper(); string.ToLower(); string.Trim(). string.collapse();
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "regular") regular = EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange") orange = EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon") lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);

            // TODO: we need to be able to find all the instances of 
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular") result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == "orange") result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == "lemon") result = lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon") result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == Flavor.REGULAR) result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.ORANGE) result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.LEMON) result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;           
        }

    } //end Can_Rack

}
