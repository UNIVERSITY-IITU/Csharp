using System;

/*
Proc10. Описать процедуру Swap(X, Y), меняющую содержимое 
переменных X и Y (X и Y — вещественные параметры, являющиеся 
одновременно входными и выходными). С ее помощью для данных 
переменных A, B, C, D последовательно поменять содержимое следующих 
пар: A и B, C и D, B и C и вывести новые значения A, B, C, D. 
*/

namespace task1
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
            int A = 10;
            int B = 15;
            int C = 25;
            int D = 25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"BEFORE : A = {A} B = {B} C = {C} D = {D}");
            _swap(ref A, ref B);
            _swap(ref C, ref D);
            _swap(ref B, ref C);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"AFTER : A = {A} B = {B} C = {C} D = {D}");
        }
    }
}
