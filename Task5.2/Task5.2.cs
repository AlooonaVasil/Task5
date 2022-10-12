using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прога вычисления суммы max и min элементов массива");
            int n = 15;
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(" {0}", array[i]);
            }
            int max = array[0];
            int min = array[0];
            foreach (int j in array)
            {
                if (j > max)
                    max = j;
                if (j < min)
                    min = j;
            }
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массива = {0}", max);
            Console.WriteLine("Минимальный элемент массива = {0}", min);
            Console.WriteLine("Сумма максимального и минимального элементов массива = {0}", (max + min));
            Console.ReadKey();
        }
    }
}
