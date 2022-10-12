using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа считает количество нечетных положительных элементов, стоящих на четных местах массива");
            int n = 20;
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(" {0}", array[i]);
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i < n; i += 2)
            {
                if (array[i] > 0 && array[i] % 2 > 0)
                    sum++;
            }
            Console.Write("Количество нечетных положительных элементов, стоящих на четных местах массива: {0}", sum);
            Console.ReadKey();
        }
    }
}


