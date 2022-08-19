using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascending_and_decending_order
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("aseccending order");

            // declaring and initialing the array 

            int[] arr = { 3, 56, 5, 6, 99, 45, 10, 7, 1, 63, 12 };

            // sort array in aseccending order .
            Array.Sort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine("deccending order");


            // reverse array
            Array.Reverse(arr);
            foreach (int value in arr)
            {

                Console.WriteLine(value + " ");

            }

        }

    }


}


