using System;

/*
5)Дана матрица размера M × N. Преобразовать матрицу,
поменяв местами минимальный и максимальный элемент в каждой строке.
*/
namespace task5
{
    class Program
    {

        public static void reverse_matrix(ref int[,] array2, int i, int min_index, int max_index){
            int n = array2[i,min_index];
            array2[i,min_index] = array2[i,max_index];
            array2[i,max_index] = n;
        }
        static void Main(string[] args){
            int[,] array2 = new int[4, 4] { 
                {1, 2, 4, 5}, 
                {3, 4, 2, 1}, 
                {5, 4, 5, 6 }, 
                {3, 5, 7, 4 }
            };
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int max_i = 0;
            int min_i = 0;

            Console.WriteLine("Before : ");
            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){
                    Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine("s");
            }

            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){

                    if(array2[i,j] > max){
                        max = array2[i,j];
                        max_i = j;
                    }

                    if(array2[i,j] < min){
                        min = array2[i,j];
                        min_i = j;
                    }
                }
                reverse_matrix(ref array2, i, min_i, max_i);
                max = Int32.MinValue;
                min = Int32.MaxValue;
            }
            Console.WriteLine("\nAfter : ");
            for(int i=0; i<array2.GetLength(0); i++){
                for(int j=0; j<array2.GetLength(1); j++){
                    Console.Write(array2[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
