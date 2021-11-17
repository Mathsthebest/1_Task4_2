using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int minus = 0;
            int plus = 0;
          
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a >= 0)
                {
                    plus++;
                }
                else
                {
                    minus++;
                }

            } while (a != 0);

            plus -= 1; 

            if (plus == minus)
            {
                Console.WriteLine("Количество отрицательных чисел совпадает с количеством положительных и равно {0}", plus);
                Console.ReadKey();
            }
            else
            {
                if (plus > minus)
                {
                    Console.WriteLine("Количество положительных чисел ({0}) больше, чем отрицательных ({1})", plus,minus);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Количество отрицательных чисел ({1}) больше, чем положительных ({0})", plus, minus);
                    Console.ReadKey();
                }
            }
            

        }
    }
}
