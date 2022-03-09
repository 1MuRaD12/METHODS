using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            if ( num % 7 == 0)
            {
                Console.WriteLine("Divide by 7");
            }
            else
            {
                Console.WriteLine(Divide(num));
            }


        }
        public static int Divide (int num )
        {
            
            for (int i = 0; i < num; i++)
            
                if (i % 7 == 1)
                {
                    Console.WriteLine(num);
                }
            {
                return num;
            }

            
        }
    }
}
