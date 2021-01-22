using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers 50 down to 35, EXCEPT 43 and 37.");

            int ReturnFifty = Return50();
            int ReturnThirtyFive = Return35();
            
            Program p = new Program();
            p.Print50to35(ReturnFifty, ReturnThirtyFive);
        }

        public static int Return50()
        {
            return 50;
        }

        public static int Return35()
        {
            return 35;
        }

        public void Print50to35(int start, int end)
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
