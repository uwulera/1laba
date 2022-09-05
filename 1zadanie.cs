using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix1
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 1, если нужно заполнить рандомными значениями матрицу");
            Console.WriteLine("введите 2, если нужно заполнить матрицу значениями с клавиатуры");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("целочисленная квадратная матрица порядка 5:");
                int n = 5;
                int m = 5;
                int[] sum = new int[n]; string t = ""; int SumMin = 0;
                Random r = new Random();
                int[] min = new int[n];
                int[,] M = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    min[i] = 100;
                    for (int j = 0; j < m; j++)
                    {

                        M[i, j] = r.Next(-1000, 1000);
                        min[i] = Math.Min(min[i], M[i, j]);
                        sum[i] = sum[i] + M[i, j];
                        t = t + "\t" + Convert.ToString(M[i, j]);
                    }
                    Console.WriteLine(t); t = "";
                }
                Console.WriteLine();
                int Min = 100;
                for (int i = 0; i < n; i++)
                {
                    //Console.WriteLine(sum[i] + "\t" + min[i]);
                    Min = Math.Min(Min, sum[i]);
                    SumMin = SumMin + min[i];
                }
                // Console.WriteLine();
                Console.WriteLine("Минимальная сумма строки матрицы ");
                Console.WriteLine(Min);
            }
            else if (d == 2)
            {

                Console.WriteLine("Заполнение матрицы");
                int n = 5;
                int m = 5;
                int[] sum = new int[n]; string t = ""; int SumMin = 0;
                int[] min = new int[n];
                int[,] M = new int[n, m];
                int[,] ara = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    min[i] = 100;
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Введите значение матрицы по одному через enter: ");
                        ara[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Целочисленная квадратная матрица номера 5, введенная с клавиатуры:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                       
                        min[i] = Math.Min(min[i], ara[i, j]);
                        sum[i] = sum[i] + ara[i, j];
                        t = t + "\t" + Convert.ToString(ara[i, j]);
                    }
                    Console.WriteLine(t); t = "";
                }
                Console.WriteLine();
                int Min = 100;
                for (int i = 0; i < n; i++)
                {
                    Min = Math.Min(Min, sum[i]);
                    SumMin = SumMin + min[i];
                }
                Console.WriteLine("Минимальная сумма строки матрицы ");
                Console.WriteLine(Min);
            }
            else
            {
                Console.WriteLine($"ошибка! вы что-то ввели не так, попробуйте снова");
            }
        }
    }
}
