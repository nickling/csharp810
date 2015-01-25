using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exercise02
{
    class CanRack
    {
        private const int binCapacity = 3;
        private int regularCans;
        private int orangeCans;
        private int lemonCans;

        // Constructor for a can rack. The rack starts out full
        public CanRack()
        {
            Debug.WriteLine("CanRack: Constructing CanRack object. All bins filled to {0} cans", binCapacity);
            regularCans = binCapacity;
            orangeCans = binCapacity;
            lemonCans = binCapacity;
        }

        // This method adds a can of the specified flavor to the rack.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("FlavorOfCanToBeAdded: {0}", FlavorOfCanToBeAdded);
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("AddACanOf: {0} bin is full.", FlavorOfCanToBeAdded);
            }
            else
            {
                switch (FlavorOfCanToBeAdded)
                {
                    case Flavor.Regular:
                        regularCans++;
                        Debug.WriteLine("AddACanOf: Adding a can of Regular to the Rack. {0}/{1}", regularCans, binCapacity);
                        break;
                    case Flavor.Orange:
                        orangeCans++;
                        Debug.WriteLine("AddACanOf: Adding a can of Orange to the Rack. {0}/{1}", regularCans, binCapacity);
                        break;
                    case Flavor.Lemon:
                        lemonCans++;
                        Debug.WriteLine("AddACanOf: Adding a can of Lemon to the Rack. {0}/{1}", lemonCans, binCapacity);
                        break;
                }
            }
        }

        // This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("RemoveACanOf: {0} bin is empty. Cannot remove.", FlavorOfCanToBeRemoved);
            }
            else
            {
                switch (FlavorOfCanToBeRemoved)
                {
                    case Flavor.Regular:
                        regularCans--;
                        Debug.WriteLine("RemoveACanOf: Removing a can of Regular from the Rack. {0}/{1}", regularCans, binCapacity);
                        break;
                    case Flavor.Orange:
                        orangeCans--;
                        Debug.WriteLine("RemoveACanOf: Removing a can of Orange from the Rack. {0}/{1}", orangeCans, binCapacity);
                        break;
                    case Flavor.Lemon:
                        lemonCans--;
                        Debug.WriteLine("RemoveACanOf: Removing a can of Lemon from the Rack. {0}/{1}", lemonCans, binCapacity);
                        break;
                }
            }
        }

        // This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("FillTheCanRack: Refilling all bins.");
            regularCans = binCapacity;
            orangeCans = binCapacity;
            lemonCans = binCapacity;
        }

        // This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("This is a message you need to take out");
            switch (FlavorOfBinToBeEmptied)
            {
                case Flavor.Regular:
                    Debug.WriteLine("EmptyCanRackOf: Emptying the Regular bin.");
                    regularCans = 0;
                    break;
                case Flavor.Orange:
                    Debug.WriteLine("EmptyCanRackOf: Emptying the Orange bin.");
                    orangeCans = 0;
                    break;
                case Flavor.Lemon:
                    Debug.WriteLine("EmptyCanRackOf: Emptying the Lemon bin.");
                    lemonCans = 0;
                    break;
            }
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public bool IsFull(string FlavorOfBinToCheck)
        {
            switch (FlavorOfBinToCheck)
            {
                case Flavor.Regular:
                    Debug.WriteLine("IsFull: Check if Regular bin is full.");
                    return (regularCans.Equals(binCapacity));
                case Flavor.Orange:
                    Debug.WriteLine("IsFull: Check if Orange bin is full.");
                    return (orangeCans.Equals(binCapacity));
                case Flavor.Lemon:
                    Debug.WriteLine("IsFull: Check if Lemon bin is full.");
                    return (lemonCans.Equals(binCapacity));
            }
            return false;
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise
        public bool IsEmpty(string FlavorOfBinToCheck)
        {
            switch (FlavorOfBinToCheck)
            {
                case Flavor.Regular:
                    Debug.WriteLine("IsEmpty: Check if Regular bin is empty.");
                    return (regularCans.Equals(0));
                case Flavor.Orange:
                    Debug.WriteLine("IsEmpty: Check if Orange bin is empty.");
                    return (orangeCans.Equals(0));
                case Flavor.Lemon:
                    Debug.WriteLine("IsEmpty: Check if Lemon bin is empty.");
                    return (lemonCans.Equals(0));
            }
            return false;
        }



        //public int RegularBinSupply
        //{
        //    get
        //    {
        //        return regularBinSupply;
        //    }
        //    set
        //    {
        //        regularBinSupply = value;
        //    }
        //}

        //public int OrangeBinSupply
        //{
        //    get
        //    {
        //        return orangeBinSupply;
        //    }
        //    set
        //    {
        //        orangeBinSupply = value;
        //    }
        //}

        //public int LemonBinSupply
        //{
        //    get
        //    {
        //        return lemonBinSupply;
        //    }
        //    set
        //    {
        //        lemonBinSupply = value;
        //    }
        //}

        // CanRack
        // 3 Can Bins
        // each bin holds all the cans of a particular flavor
        // INT Bin.
        // the number in the bin represents all the cans of that flavor.
        // 
        public class Flavor
        {
            public const string Regular = "Regular";
            public const string Orange = "Orange";
            public const string Lemon = "Lemon";
        }
    }
}
//Add a can rack class to your vending machine project. 
//A can rack will be composed of three can bins 
//(one can bin holds all the cans of a particular flavor
//and all three can bins together comprise the can rack).
//Each bin holds a maximum of three cans of a given flavor.

