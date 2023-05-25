using System;
using System.Collections.Generic;

using System.Linq;

using System.Security.Cryptography;

using System.Text;

using System.Threading.Tasks;

namespace codingPractise

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter size of array");

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter array elements");

            for (int i = 0; i < n; i++)

            {

                arr[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine(arr[i]);

            }

        }

    }

}


