using System;
/*
Удалить из массива все соседние одинаковые элементы, 
оставив их первые вхождения
*/
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array   = {8,5,5,2,7,1,5,3,3,12,67,334,55,55,32};

           int k = 0;
        for(int i = 1; i<array.Length; i++){
            if(array[i] != array[k])
            array[++k] = array[i];
        }
        Array.Resize(ref array, ++k);

        foreach(int n in array){
                Console.Write(n + " ");
            }Console.WriteLine();
        }
    }
}
