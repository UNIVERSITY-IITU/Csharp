using System;
/*
. Дан целочисленный массив размера N. Увеличить все четные числа,
содержащиеся в массиве, на исходное значение первого четного числа. 
Если четные числа в массиве отсутствуют, то оставить массив без изме- нений.
*/

namespace homework4
{
    class Program
    {
        public static void ChangeEven(ref int [] array){
            int even = 0;
            foreach(int n in array){
                if(n%2==0){
                    even = n;
                    break;
                }
            }

            for(int i=0; i<array.Length; i++){
                if(array[i]%2==0){
                    array[i] = even;
                }
            }
        } 
        static void Main(string[] args)
        {
            int[] array   = {8,5,2,7,1,5,3,12,67,334,55,32};
            ChangeEven(ref array);
            foreach(int n in array){
                Console.Write(n + " ");
            }Console.WriteLine();
        }
    }
}
