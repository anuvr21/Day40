using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerof2
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            Inner.Private obj = new Inner.Private();
            obj.isPowerof2(n);
        }
        public class Inner
        {
            public class Private
            {
                public void isPowerof2(int n)
                {
                    bool result = false;
                    int rem;
                    if (n == 1)
                    {
                        result = true;
                    }
                    while (n > 1)
                    {
                        rem = n % 2;
                        if (rem != 0)
                        {
                            break;
                        }
                        n = n / 2;
                    }
                    if (n == 1)
                    {
                        result = true;
                    }
                    if (result == true)
                    {
                        Console.WriteLine("the number is a power of 2");
                    }
                    if (result == false)
                    {
                        Console.WriteLine("the number is not a power of 2");
                    }
                }
            }
        }
    }
}