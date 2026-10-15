using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_5._4
{
    internal class Program
    {
        
        
            static int Factorial(int n)
            {
                // Базовый случай: факториал 0 или 1
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial(n - 1);
                }
            }

            static void Main()
            {
                Console.WriteLine(Factorial(6));
            }
     
























    }
}

