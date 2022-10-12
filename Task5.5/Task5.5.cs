using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать двумерный массив, где 1 и 0 располагаются в шахматном порядке");
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i % 2.0 == 0 && j % 2.0 == 0) || (i % 2.0 != 0 && j % 2.0 != 0))
                        array[i, j] = 1;
                    else
                        array[i, j] = 0;

                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
