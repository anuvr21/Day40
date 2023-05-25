using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int sum = 0;
            Console.WriteLine("enter number of rows");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of columns");
            int c = int.Parse(Console.ReadLine());
            int[,] arr = new int[r, c];
            Console.WriteLine("enter array elements");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < r - 2; i++)
            { 
                for (int j = 0; j < c - 2; j++)
                {
                    sum = arr[i, j] + arr[i, j + 1] + arr[i, j + 2] + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                    list.Add(sum);
                }
            }
            list.Sort();
            int n = list.Count;
            Console.WriteLine(list[n - 1]);
        }
    }
}