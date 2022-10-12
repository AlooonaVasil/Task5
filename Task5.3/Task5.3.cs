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
            Console.WriteLine("Программа упорядочивает первые 5 членов массива по возрастанию, вторые 5 по убыванию");
            int n = 10;
            Random random = new Random();
            int[] array = new int[n];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,3} ", array[i]);
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i + 1; j < n / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Упорядоченный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}

