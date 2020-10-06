using System;
/*
6)Дана квадратная матрица A порядка M. 
Найти сумму элементов ее главной диагонали, 
то есть диагонали, содержащей следующие элементы:
*/
namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2 = new int[4, 4] { 
                {1, 2, 4, 5}, 
                {3, 4, 2, 1}, 
                {5, 4, 5, 6 }, 
                {3, 5, 7, 4 }
            };

            Console.WriteLine("Matrix : ");
            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){
                    Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine("");
            }

            int sum = 0;
            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){
                    if(i == j){
                        sum += array2[i,j];
                    }
                }
            }
            Console.WriteLine($"\nSum of diagonal : {sum}");
            
        }
    }
}
