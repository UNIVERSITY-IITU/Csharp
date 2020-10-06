using System;

// 1 Data input and output, assignment operator 

/*
Begin22◦ . Swap the contents of variables A and B and output new values of A and B.
*/



namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1 = 123;
            Console.WriteLine($"Before variable 1: {variable1}");

            int variable2 = 321;
            Console.WriteLine($"Before variable 2: {variable2}");
            variable1 = variable1 + variable2;

            variable2 = variable1 - variable2;
            variable1 = variable1 - variable2;

            Console.WriteLine($"After variable 1: {variable1}");
            Console.WriteLine($"After variable 2: {variable2}");
            
        }
    }
}
