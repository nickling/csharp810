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


    // When using the Enumeration, can we use the enumeration like:
    // Flavor.REGULAR
    // or do we have to create a Can instance for each flavor?
    // Can reg = new Can(Flavor.Regular);
    // then use this for all the comparisons?


    class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        private int _regulr = EMPTYBIN;
        private int _orange = EMPTYBIN;
        private int _lemon = EMPTYBIN;

        private const int DUMMYARGUMENT = 0;

        // Constructor for a can rack. The rack starts out full
        // (i.e., BINSIZE cans of each flavor).
        public CanRack()
        {
            _regulr = BINSIZE;
            _orange = BINSIZE;
            _lemon = BINSIZE;
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
                if (FlavorOfCanToBeAdded == "regular")      _regulr += 1;
                else if (FlavorOfCanToBeAdded == "orange")  _orange += 1;
                else if (FlavorOfCanToBeAdded == "lemon")   _lemon  += 1;
                else Debug.WriteLine("Error: attempt to add a can of unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
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
                if (FlavorOfCanToBeAdded == Flavor.REGULAR)     _regulr += 1;
                else if (FlavorOfCanToBeAdded == Flavor.ORANGE) _orange += 1;
                else if (FlavorOfCanToBeAdded == Flavor.LEMON)  _lemon  += 1;
                else Debug.WriteLine("Error: attempt to add a can of unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            }
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
                if (FlavorOfCanToBeRemoved == "regular")        _regulr -= 1;
                else if (FlavorOfCanToBeRemoved == "orange")    _orange -= 1;
                else if (FlavorOfCanToBeRemoved == "lemon")     _lemon  -= 1;
                else Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
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
                if (FlavorOfCanToBeRemoved == Flavor.REGULAR)       _regulr -= 1;
                else if (FlavorOfCanToBeRemoved == Flavor.ORANGE)   _orange -= 1;
                else if (FlavorOfCanToBeRemoved == Flavor.LEMON)    _lemon  -= 1;
                else Debug.WriteLine("Error: attempt to remove a can of unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            }
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            _regulr = BINSIZE;
            _orange = BINSIZE;
            _lemon = BINSIZE;

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
            if (FlavorOfBinToCheck == "regular")        _regulr = EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange")    _orange = EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon")     _lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == Flavor.REGULAR)       _regulr = EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.ORANGE)   _orange = EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.LEMON)    _lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular")        result = _regulr == BINSIZE;
            else if (FlavorOfBinToCheck == "orange")    result = _orange == BINSIZE;
            else if (FlavorOfBinToCheck == "lemon")     result = _lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == Flavor.REGULAR)       result = _regulr == BINSIZE;
            else if (FlavorOfBinToCheck == Flavor.ORANGE)   result = _orange == BINSIZE;
            else if (FlavorOfBinToCheck == Flavor.LEMON)    result = _lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "regular") result =       _regulr == EMPTYBIN;
            else if (FlavorOfBinToCheck == "orange") result =   _orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "lemon") result =    _lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == Flavor.REGULAR)       result = _regulr == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.ORANGE)   result = _orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == Flavor.LEMON)    result = _lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;           
        }

    } //end Can_Rack

}
