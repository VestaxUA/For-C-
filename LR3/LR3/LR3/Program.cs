using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть координату x: ");
            string strx = Console.ReadLine();
            int x = int.Parse(strx);

            Console.Write("Введіть координату y: ");
            string stry = Console.ReadLine();
            int y = int.Parse(stry);

            bool ans;
            if (x > 0 && y > 0 || x < 0 && y < 0)
            {
                ans = true;
                Console.WriteLine(ans);
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Точка знаходиться в першому квадранті");
                } 
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Точка знаходиться в третьому квадранті");
                }
            }
            else
            {
                ans = false;
                Console.WriteLine(ans);
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Точка знаходиться в четвертому квадранті");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка знаходиться в четвертому квадранті");
                }
                else if (x == 0 || y == 0)
                {
                    Console.WriteLine("Точка лежить на осі");
                }
            }

            Console.ReadLine();
        }
    }
}