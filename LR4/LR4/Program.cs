using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int sum = 1;
            int seriesNumber = -1;

            Console.Write("Введіть кількість елементів масиву (N) : ");
            string strn = Console.ReadLine();
            int n = int.Parse(strn);

            int[] arr = new int[n + 1];
            int[] series = new int[n];
            Random randNum = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = randNum.Next(1, 3);
                if (i == n - 1)
                {
                    arr[i] = 0;
                }
            }

            for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        sum += 1;
                    }
                    else
                    {
                        seriesNumber++;
                        series[seriesNumber] = sum;
                        sum = 1;
                    }
                }
            

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + "  ");
                }
                }

                Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (series[i] != 0)
                {
                    Console.Write(series[i] + "  ");
                }
               }

                Console.ReadLine();
        }
    }
}
