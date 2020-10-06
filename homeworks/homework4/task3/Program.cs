using System;

/*
3) Array114. Дан массив A размера N (≤6). Упорядочить его по возрастанию методом 
сортировки простыми вставками: сравнить элементы A1 и A2 и, при необходимости меняя их местами, добиться того, 
чтобы они оказа- лись упорядоченными по возрастанию; затем обратиться к элементу A3 и переместить его в левую (уже упорядоченную) часть массива, сохранив ее упорядоченность; повторить этот процесс для остальных элементов, выводя содержимое массива после обработки каждого элемента (от 2- го до N-го). При выполнении описанных действий удобно использовать прием «барьера», записывая очередной элемент перед его обработкой в
дополнительный элемент массива A0.
*/

namespace task3
{
    class Program
    {

    static void selectoin_sort(ref int []array){ 
        int n = array.Length; 
  
        for (int i = 0; i < n - 1; i++) 
        {
            int index_min = i; 
            for (int j = i + 1; j < n; j++) 
                if (array[j] < array[index_min]) 
                    index_min = j; 
  
            
            
            int temp = array[index_min]; 
            array[index_min] = array[i]; 
            array[i] = temp; 
        } 
    } 
        static void Main(string[] args)
        {
            int[] array   = {8,5,5,2,7,1,5,3,3,12,67,334,55,55,32};
            selectoin_sort(ref array);

            foreach(int n in array){
                Console.Write(n + " ");
            }Console.WriteLine();
           
        }
    }
}
