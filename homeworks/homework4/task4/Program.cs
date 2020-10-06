using System;

/*
4) Matrix20. Дана матрица размера M × N. 
Для каждого столбца матрицы найти произведение его элементов.
*/
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int sum = 1;
            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){
                    sum *= array2[i,j];
                }
                Console.WriteLine($"mult of {i+1} col is {sum}");
                sum = 1;
            }
        }
    }
}
