using System;

namespace Exercise_number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int sum;

            Console.WriteLine("Enter the number");

            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i <= p; i++)
            {
                if (p > 0)
                {
                    sum = a;
                    a = b;
                    b = b + sum;

                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("The number printed by you must be at least zero!");
                }
            }
        }
    }
}
