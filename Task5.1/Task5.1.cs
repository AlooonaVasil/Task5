using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисления среднего арифметического элементов массива");
            Console.WriteLine("Введите 7 целых чисел");
            int n = 7;
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое элементов массива = {0:f2}", (double)sum / n);
            Console.ReadKey();
        }

    }
}
