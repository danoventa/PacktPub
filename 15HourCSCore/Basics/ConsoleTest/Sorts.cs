using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleTest
{
    public static class Sorts
    {

        public static int[] MergeCookies(int[] aCookies, int[] bCookies)
        {

            var jCookies = new int[aCookies.Length + bCookies.Length];
            aCookies.CopyTo(jCookies, 0);
            bCookies.CopyTo(jCookies, aCookies.Length);

            Array.Sort(jCookies);
            return jCookies;
        }
    }
}