using System;

/*
Proc35. Описать функцию Fact2(N) вещественного типа, вычисляющую двойной факториал: 
N!! = 1·3·5·...·N, если N — нечетное; N!! = 2·4·6·...·N, если N — четное (N > 0 — параметр 
целого типа; вещественное возвращаемое значение используется для того, чтобы избежать 
целочисленного переполнения при больших значениях N). С помощью этой функции найти 
двойные факториалы пяти данных целых чисел. 
*/

namespace task2
{
    class Program
    {
        public static int fact(int n){
            if (n==2 || n == 1){
                Console.Write($"{n} = ");
                return n;
            }
            Console.Write($"{n} * ");
            return n * fact(n-2);
        }
        static void Main(string[] args)
        {   
            for (int i=5; i <=10; i++){
                Console.WriteLine(fact(i));
            }   
        }
    }
}
