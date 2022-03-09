using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("first");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("opperator");
            char opperator = Convert.ToChar(Console.ReadLine());


            Console.WriteLine(total(num, num2, opperator));

        }
        public static int total(int num, int num2, char opperator)
        {
            int sum = 0;
            if (opperator == '+')
            {
                sum = num + num2;
                Console.WriteLine(sum);

            }
            else if (opperator == '-')
            {
                sum = num - num2;
                Console.WriteLine(sum);
            }
            else if (opperator == '*')
            {
                sum = num * num2;
                Console.WriteLine(sum);
            }
            else if (opperator == '/')
                sum = num / num2;
            Console.WriteLine(sum);
            {
                return sum;
            }








        }
    }
}
