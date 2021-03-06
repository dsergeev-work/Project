using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindPath(3, 3));
        }
           static int FindPath(int m, int n)
           {
                int[,] array = new int[m, n];

                for (int i = 0; i < m; i++)
                    array[i, 0] = 1;

                for (int j = 0; j < n; j++)
                    array[0, j] = 1;

                for (int i = 1; i < m; i++)
                {
                    for (int j = 1; j < n; j++)
                        array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
                   return array[m - 1, n - 1];
           }
           /*static int SecondMethode(int m, int n)
           {
              return ((m * n) - 2) - 1;
           }*/
    }
}
