using System;

namespace assignment1
{
    class Program
    {
// M A I N
        private static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers 50 down to 35, EXCEPT 43 and 37.");

            int ReturnFifty = Return50();
            int ReturnThirtyFive = Return35();
            
            Program p = new Program();
            p.Print50to35(ReturnFifty, ReturnThirtyFive);
        }


// R E T U R N   5 0
        private static int Return50()
        {
            return 50;
        }


// R E T U R N   3 5
        private static int Return35()
        {
            return 35;
        }


// P R I N T   5 0   T O   3 5
        private void Print50to35(int start, int end)
        {
            for (int i = start; i >= end; i --)
            {
                if (i != 43 && i != 37)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    // End of Program class
    }
}
