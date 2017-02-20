using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Hello, World!\n");

            int[] numArr = {1, 2, 3, 4, 5, 6};

            Console.Write(Equals(1, 2-2) ? "maybe\n" : "Nope\n");
            Console.Write(Equals(1, 2 - 1) ? "Of Course it's true!\n" : "This shouldn't happen\n");

            foreach (var n in numArr)
            {
                Console.Write(n);
            }
        }
    }
}
