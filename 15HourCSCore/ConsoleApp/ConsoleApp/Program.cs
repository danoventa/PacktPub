using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GolderFibo(35);
            Fibonacci(35);
            RecFibo(35);

            var firstCharacter = Console.Read();
            if(firstCharacter == '#'){
                Print("DERP");
            }else if(firstCharacter == null){
                Print("OH no");
            }else{
                Print(Convert.ToChar(firstCharacter) + Console.ReadLine());
            }
            var dict = new Dictionary<string, List<string[]>>();
            var lis = new List<string[]>();
            string[] stl = {"a"};
            lis.Add(stl);
            dict.Add("1", lis);
            dict.Add("3", lis);
            dict.Add("2", lis);
            dict.Add("5", lis);
            var unsortedArr = dict.Keys.ToArray();
            Print("unsorted");
            foreach (var st in unsortedArr)
            {
                Print(st);
            }
            Print("sorted");
            Array.Sort(unsortedArr);
            foreach (var st in unsortedArr)
            {
                Print(st);
            }


            int[] numbers =
            {
                1,
                2,
                3,
                4,
                5
            };
            Console.Write("Hai Der, insert Gerter!");
            // var bloop = Console.Read().ToString();
            // Console.Write(bloop.ToString() + "\n");
            var test = Console.ReadLine();
            Console.Write(test + "\n");

            int rolling = 0;
            foreach(var n in numbers){
                rolling += n;
            }

            Console.Write(rolling);
            int ind = 5;
            for(int i = 0; i < ind; i++){
                string blanks = "";
                string hash = "";
                for(int j = 0; j < (ind-i-1); j++){
                    blanks += " ";

                }
                for(int k = 0; k < (i + 1); k++){
                    hash += "#";
                }
                Console.Write(blanks + hash + "\n");
            }

            Console.Write("Hello, World!\n");

            int[] numArr = {2, 5, 4, 3, 9, 11};

            Console.Write(Equals(1, 2-2) ? "maybe\n" : "Nope\n");
            Console.Write(Equals(1, 2 - 1) ? "Of Course it's true!\n" : "This shouldn't happen\n");

            for (int i = 0; i < numArr.Length; i++)
            {
                Console.Write(i);
                Console.Write("\n");
            }

            Array.Sort(numArr);
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.Write(i);
                Console.Write('\n');
            }

            foreach (var n in numArr)
            {
                Console.Write(n);
            }
        }

        public static int Fibcursion(int nth, Dictionary<int, int> holster)
        {


            if (nth == 0)
            {
                return 0;
            }else if (nth == 1)
            {
                return 1;
            }
            else
            {
                int val;
                if (holster.TryGetValue(nth, out val))
                {
                    return val;
                }
                val = Fibcursion(nth - 1, holster) + Fibcursion(nth - 2, holster);
                holster[nth] = val;
                return val;
            }
        }

        public static void RecFibo(int nth)
        {
            Print(Convert.ToString(Fibcursion(nth, new Dictionary<int, int>())));
        }

        public static void GolderFibo(int nth)
        {
            const double phi = 1.618034;
            Print(Convert.ToString(Math.Round((Math.Pow(phi, nth) - Math.Pow((1 - phi), nth)) / Math.Sqrt(5))));
        }

        public static void Fibonacci(int nth)
        {
            var lead = 0;
            var trail = 1;

            for (var i = 0; i < nth; i++)

            {
                var temp = lead;
                lead = trail;
                trail = temp + trail;
            }
            Print(Convert.ToString(lead));
        }

        public static void Print(string number)
        {
            Console.Write(number  + "\n");
        }
    }
}
