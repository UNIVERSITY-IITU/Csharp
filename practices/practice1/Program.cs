using System;

namespace practice1
{
    class Program
    {
        public static double find_n(int n){
            double counter = 0;
            for(int i = 1; i <= n; i++){
                counter += Math.Pow(i,i);
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Result is {find_n(n)}");   
        }
    }
}
