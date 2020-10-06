using System;

/*
Дано целое число N и набор из N целых чисел. 
Найти номера первого минимального и последнего 
максимального элемента из данного набора и вывести их в указанном порядке.
*/

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int max_index = 0;
            int min_index = 0;
            Console.Write("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < n; i++){
                Console.Write($"input {i}'s value : ");
                int _input = Convert.ToInt32(Console.ReadLine());
                if (_input > max){
                    max = _input;
                    max_index = i;
                }

                if (_input < min){
                    min = _input;
                    min_index = i;
                }
            }

            Console.WriteLine($"max = {max} index : {max_index}");
            Console.WriteLine($"min = {min} index : {min_index}");
        }
    }
}
