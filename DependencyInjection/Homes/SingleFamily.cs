using System;

namespace Homes
{
    public class SingleFamily:IHome
    {
        

        public Home BuildHome()
        {
            Home sf = new Home() { stories = 2, bedrooms = 3, bathrooms=4 };
            return sf;
        }

    }


    public class MatryoshkaDoll
    {
        private readonly MatryoshkaDoll containedDoll;

        public MatryoshkaDoll() { }

        public MatryoshkaDoll(MatryoshkaDoll containedDoll)
        {
            this.containedDoll = containedDoll;
        }

        public int NumberOfSmallerDolls
        {
            get
            {
                return containedDoll.NumberOfSmallerDolls;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(new MatryoshkaDoll(new MatryoshkaDoll()).NumberOfSmallerDolls);
        }
    }


}
