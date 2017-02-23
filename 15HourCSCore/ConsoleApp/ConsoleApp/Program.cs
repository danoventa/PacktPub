using System;
using System.Collections.Concurrent;
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
            int[] arr = new int[5];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length - i;
            }
            Quicksort(arr);

            Console.Write("Sorted Array [");
            foreach (var number in arr)
            {
                Console.Write(Convert.ToString(" " + number + " " ));
            }
            Console.Write("]");

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
            switch (nth)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
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

        public static void Quicksort(int[] arr)
        {
            Quicksort_r(arr, 0, arr.Length - 1);
        }

        public static void Quicksort_r(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int pivot = Partition(arr, lo, hi);
                Quicksort_r(arr, lo, pivot - 1);
                Quicksort_r(arr, pivot + 1, hi);
            }
        }

        public static int Partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[hi];
            int i = lo - 1;
            for (var j = lo; j < hi; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i+1, hi);
            return i + 1;
        }

        public static void Swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
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
            Console.Write(number + "\n");
        }
    }
}
