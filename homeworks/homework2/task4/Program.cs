using System;

/*
Дано целое число N (>2) и набор из N чисел. 
Найти два наименьших элемента из данного набора и 
вывести эти элементы в порядке возрастания их значений. 
*/

namespace task4
{
    class Program
    {
        public static void _swap(ref int x, ref int y){
            x = x + y;
            y = x - y;
            x = x - y;
        }
        static void Main(string[] args)
        {
            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue-1;
            Console.Write("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < n; i++){
                Console.Write($"input {i}'s value : ");
                int _input = Convert.ToInt32(Console.ReadLine());
                
                if (_input < min2){
                    min2 = _input;
                }
                if (min2 < min1){
                    _swap(ref min1, ref min2);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"1 min = {min1}\n2 min = {min2}");
        }
    }
}
