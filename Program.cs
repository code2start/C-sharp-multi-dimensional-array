using System;

namespace multidimensionalarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   int[,] numbers;//array declaration
              numbers = new int[3,2];//array instantiation */
            /* int[,] numbers = new int[3, 2];
            //initialization
            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[1, 0] = 3;
            numbers[1, 1] = 4;
            numbers[2, 0] = 5;
            numbers[2, 1] = 6; */
            //int[,] numbers = new int[3,2]{{1,2},{3,4},{5,66}};
            int[,] numbers = {{1,2},{3,4},{55,66}};
            //Console.WriteLine(numbers[0,1]);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
            int[,,] y = new int[2,3,3];
        }
    }
}
