using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Divide(num));
        }
        public static int Divide(int num)
        {
            int divide = 0;
            if (num < 50)
            {
                divide = 3;
                seek(num, divide);
            }
            else if (num >= 50 && num <= 100)
            {
                divide = 5;

                seek(num, divide);
            }
            else if (num > 100)
            {
                divide = 8;

                seek(num, divide);
            }
            {
                return seek(num, divide);
            }



        }
        public static int seek(int num, int number)
        {
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % number == 0)
                    count++;

            }
            {
                return count;
            }
        }

    }
}