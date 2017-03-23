using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new List<int>();
            var b = new List<int>();
            a.Add(2);
            a.Add(-7);
            a.Add(-13);

            b.Add(2);
            b.Add(1);
            b.Add(-9);

            Console.Write(Convert.ToString(coverPoints(a, b)));




        }
        public static int coverPoints(List<int> A, List<int> B) {
            int i = 0;
            int size = A[i];
            if(size <= 1){
                return 0;
            }

            i++;
            int x = A[i];
            int y = B[i];

            int counter = 0;

            int x_r = 0;
            int y_r = 0;
            i++;

            while(i <= size){
                x = x - A[i];
                x_r = abs(x);

                y = y - B[i];
                y_r = abs(y);

                if (x_r <= y_r){
                    counter += y_r;
                }else{
                    counter += x_r;
                }
                i++;
            }
            return counter;
        }
        public int abs(int a){
            if(a  < 0){
                a = a * -1;
            }
            return a;
        }
    }
}