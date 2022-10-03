using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть кількість рядків масиву (M) : ");
            string strm = Console.ReadLine();
            int m = int.Parse(strm);

            Console.Write("Введіть кількість стовпців масиву (N) : ");
            string strn = Console.ReadLine();
            int n = int.Parse(strn);

            Console.Write("Введіть номер стовпцю, який ви бажаєте прибрати (K) : ");
            string strk = Console.ReadLine();
            int k = int.Parse(strk);

            int[,] arr = new int[m, n];
            Random randNum = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = randNum.Next(1, 8);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Початковий масив");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                        Console.Write(arr[i, j] + "  ");
                        if (j == n - 1)
                        {
                            Console.WriteLine();
                        }
                    
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == k)
                    {
                        arr[i, j] = default(int);
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("Масив з видаленним стовпцем {0}", k);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (arr[i, j] != 0)
                    {
                        Console.Write(arr[i, j] + "  ");
                        if (j == n - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }

           
            Console.ReadLine();
        }
    }
}
