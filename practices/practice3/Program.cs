using System;
 
class Program {
    
    

    static void _Spiral(int A, int[,] a)
    {
        int r = 0, l = 0; //right   left
        int d = A, u = A; //down    up
        int size =  A * A;
        int position = 0;
 
        while (r < d && l < u) {

            if(position == size){
                break;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            // down
            for (int i = r; i < d; i++){
                Console.Write(a[i, l] + " ");
                position++;
            }Console.WriteLine();
            l++;

            //---------------------------------
            if(position == size){
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            // down to right
            for (int i = l; i < u; i++){
                Console.Write(a[d-1, i] + " ");
                position++;
            }Console.WriteLine();
            d--;
            //---------------------------------
 
            if(position == size){
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            if (r < d) {
                for (int i = d - 1; i >= r; i--){
                    Console.Write(a[i,u-1] + " ");
                    position++;
                }Console.WriteLine();
                u--;
            }
            //---------------------------------
 
            if(position == size){
                break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (l < u) {
                for (int i = u - 1; i >= l; i--){
                    Console.Write(a[r, i] + " ");
                }Console.WriteLine();
                r++;
            }
        }
        //---------------------------------
    }
 
    public static void Main(){
        
        const int A = 5;
        
        int[,] a = { 
            {1, 7, 6, 5, 4},
            {2, 7, 6, 5, 3},
            {3, 8, 2, 4, 2},
            {4, 9, 1, 3, 1},
            {5, 6, 7, 8, 9},
        };

        /*
        1 2 3 4 5 
        6 7 8 9 
        1 2 3 4 
        5 6 7 
        7 8 9 
        1 3 
        4 5 
        6 
        2 
        */
        
        _Spiral(A,a);
    }
}
 