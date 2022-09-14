using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            double speed; double acceler; double time;

            Console.Write("Введіть початкову швидкість (у м/с) : ");
            string strspeed = Console.ReadLine();
            speed = double.Parse(strspeed);
            Console.WriteLine();

            if (speed < 0)
            {
                Console.WriteLine("Помилка : початкова швидкість не може бути від'ємною");
                Console.Write("Введіть початкову швидкість, яка є додатнім числом (у м/с) : ");
                strspeed = Console.ReadLine();
                speed = double.Parse(strspeed);
                Console.WriteLine();
            }

            Console.Write("Введіть час (у секундах) : ");
            string strtime = Console.ReadLine();
            time = double.Parse(strtime);
            Console.WriteLine();

            if (time <= 0)
            {
                Console.WriteLine("Помилка : час не може дорівнювати нулю або бути менше нього");
                Console.Write("Введіть час, що є додатним числом (у секундах) : ");
                strtime = Console.ReadLine();
                time = double.Parse(strtime);
                Console.WriteLine();
            }

            Console.Write("Введіть прискорення : ");
            string stracceler = Console.ReadLine();
            acceler = double.Parse(stracceler);
            Console.WriteLine();

            double distance;

            distance = (speed * time) + ((acceler * Math.Pow(time, 2)) / 2);

            Console.Write($"Відстань, яку пробіг спринтер зі швидкістю {speed} м/с з " +
                $"прискоренням {acceler} м/с^2 за {time} секунд : {distance} метрів.");

            Console.ReadLine();
        }
    }
}
