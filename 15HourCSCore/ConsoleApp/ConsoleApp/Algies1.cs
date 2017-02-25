using System;

namespace ConsoleApp
{
    public class Algies1
    {
        public static int GCD(int first, int second)
        {

            int hi = Math.Max(first, second);
            int lo = Math.Min(first, second);
            int reso = 0;

            while(lo != 0)
            {
                reso = lo;
                lo = hi % lo;
                hi = reso;
            }

            return hi;
        }
    }
}