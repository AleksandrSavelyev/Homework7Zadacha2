using System;

namespace Homework7Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое делимое:");
            int dividend1 = DividendInput();
            Console.Write("введите второе делимое:");
            int dividend2 = DividendInput();
            int GCD = ComGCD(dividend1, dividend2);

            Console.WriteLine("наибольший общий делителт равен " + GCD);

        }
        static int DividendInput()
        {
            int dividend = 0;
            bool i = false;
            while (i == false)
            {
                try
                {
                    dividend = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("неверные данные повторите ввод:");
                }
            }
            return dividend;
        }
        static int ComGCD(int dividend1, int dividend2)
        {
            if (dividend1 == 0 || dividend2 == 0)
            {
                return dividend1 + dividend2;
            }
            else if (dividend1 > dividend2)
            {
                dividend1 %= dividend2;
                return ComGCD(dividend1, dividend2);
            }
            else
            {
                dividend2 %= dividend1;
                return ComGCD(dividend1, dividend2);
            }
        }

    }
}
