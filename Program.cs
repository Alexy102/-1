using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
            if (x < -1)
            {
                y = 1 / x;
            }
            if (x >= -1 && x <= 4)
            {
                y = x * x;
            }
            else
            {
                y = 4;
            }
            Console.WriteLine("Значение функции равно = " + y);
        }
    }
}
