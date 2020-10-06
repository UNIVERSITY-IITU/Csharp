using System;

//4 The conditional operator 

/*
If20. There are three points on the numeric axis: A, B, and C. 
Determine which of the last two points (B or C) is closest to A, 
and print this point and its distance from point A. 
*/

namespace task4
{
    class Program
    {
        public static int check_nearest(int A, int B, int C){
            if (Math.Abs(A - B) > Math.Abs(A - C)){
                return C;
            }
            return B;
        }
        static void Main(string[] args)
        {
            Console.Write("input A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("input B : ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("input C : ");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{check_nearest(A, B, C)} is nearest value to {A}");
        }
    }
}
