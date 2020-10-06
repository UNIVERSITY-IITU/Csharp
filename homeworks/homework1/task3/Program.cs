using System;
//3 Logical expression 

/*
Boolean25◦ . Given the numbers x, y. Check the truth of the statement: 
"The point with coordinates (x, y) lies in the second coordinate quarter." 
*/
namespace task3
{
    class Program
    {
        public static bool second_coordinate(int x, int y){
            if (x < 0 && y > 0){
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Input x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(second_coordinate(x,y)){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Coordinates ({x}, {y}) lies in 2 coordinate quarter.");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Coordinates ({x}, {y}) not lies in 2 coordinate quarter.");
            }
        }
    }
}
