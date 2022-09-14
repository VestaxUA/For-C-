using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LR_2
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = Encoding.Unicode;

            int nn; int nk;

            Console.Write("Введіть початок ряду : ");
            string strnn = Console.ReadLine();
            nn = int.Parse(strnn);

            Console.WriteLine();

            Console.Write("Введіть кінець ряду : ");
            string strnk = Console.ReadLine();
            nk = int.Parse(strnk);

            Console.WriteLine();

            if (nn > nk || nn <= 0)
            {
                if (nn > nk)
                {
                    Console.WriteLine("Помилка : початок ряду не може бути більшим за його кінець");
                    Console.WriteLine();
                    Console.WriteLine("Рішення : ");
                    Console.Write("Введіть нові дані");
                    Console.WriteLine();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Помилка : початок ряду не може дорівнювати нулю чи бути меншим за нього");
                    Console.WriteLine();
                    Console.WriteLine("Рішення : ");
                    Console.Write("Введіть новий початок ряду, менший за {0} : ", nk);
                    strnn = Console.ReadLine();
                    nn = int.Parse(strnn);
                }
            }

            double result = 0;

            for (; nn <= nk; nn++)
            {
                result += (Math.Pow(-1, (Math.Pow(nn, 2)) + nn + 1) * Math.Pow(nn, 2)) / (2 * Math.Pow(nn, 2) + 1);
            }
            Console.WriteLine();
            Console.Write($"Добуток ряду : {result:n3}");


            Console.ReadLine();
        }
    }
}
