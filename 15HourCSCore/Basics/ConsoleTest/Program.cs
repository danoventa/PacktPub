using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static ConsoleTest.Sorts;


namespace ConsoleTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var aCookies = new int[3];
            var bCookies = new int[4];
            MergeCookies(aCookies, bCookies);
            foreach (var i in aCookies)
            {
                Console.Write(Convert.ToString(i));
            }



            var li = new List<int>();
            li.Add(5);
            li.Add(1);
            li.Add(3);
            li.Add(2);
            li.Add(4);

            wave(li);
            for (var i = 0;
                i < li.Count;
                i++)
                    {
                        Console.Write(Convert.ToString(li[i]) + " " );
                    }
                }
        public static List<int> wave(List<int> A) {
            bool toggle = false;
            int temp;

            if(A.Count < 2){
                return A;
            }

            for(var i = 0; i < A.Count - 1; i++){

                print("Current index");
                print(i);
                if(toggle){
                    if(A[i] > A[i + 1]){
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i+1] = temp;
                    }
                    toggle = false;
                }else{
                    if(A[i] < A[i + 1]){
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i+1] = temp;
                    }
                    toggle = true;
                }
                print(A[i]);

            }
            return A;
        }

        public static void print(object mess)
        {
            Console.Write(Convert.ToString(mess) + "\n");
        }
    }
}