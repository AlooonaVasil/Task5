using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    internal class Task5_6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача про Магический квадрат");
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine("Введите элементs массива (через Enter)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Массив выглядит так:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }

            int[] sumsI = new int[n];
            int[] sumsJ = new int[n];
            int sumD1 = 0;
            int sumD2 = 0;

            //считаем в разные массивы суммы строк,
            //суммы столбцов и сумму основной диагонали и побочной 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumsI[i] += array[i, j];
                    sumsJ[i] += array[j, i];
                    if ((i == j)) sumD1 += array[i, j];
                    if ((i + j == n - 1)) sumD2 += array[i, j];
                }
            }

            //объединяю в один общий массив найденные суммы            
            int[] sums = sumsI.Concat(sumsJ).ToArray();
            sums = sums.Append(sumD1).ToArray();
            sums = sums.Append(sumD2).ToArray();

            int oneSum = sums[0];
            int count = 0;
            foreach (var sum in sums)
            {
                if (oneSum == sum) count++;
            }
            if (count == n * 2 + 2)
                Console.WriteLine("Квадрат является магическим");
            else Console.WriteLine("Квадрат не является магическим");
            Console.ReadLine();
        }
    }
}

