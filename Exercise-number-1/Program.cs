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

            PrintResult(CalculateSequence(p));

            Console.ReadLine();
        }
        public static int[] CalculateSequence(int sequenceLength)
        {
            if (sequenceLength <= 0)
            {
                Console.WriteLine($"Sequence length should be greateer than 0");
            }

            int[] result = new int[sequenceLength];

            for (int i = 0; i < sequenceLength; i++)
            {
                if (i > 1)
                {
                    result[i] = result[i - 1] + result[i - 2];
                }
                else
                {
                    result[i] = i;
                }
            }

            return result;
        }

        public static void PrintResult(int[] result)
        {
            foreach (int i in result)
            {
                Console.Write($" {i}");
            }
        }
    }
}
