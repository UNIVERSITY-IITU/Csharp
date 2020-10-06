using System;

/*
String29◦. Дан символ C и строки S, S0. 
Перед каждым вхождением символа C в строку S 
вставить строку S0. 
*/

namespace practice2
{
    class Program
    {
        // public static string ReplaceXwithY(string str){
        //     return str.ToLower().Replace("y", "x");
        // }
        static void Main(string[] args)
        {
            Char c = 'c';
            String s = Convert.ToString(Console.ReadLine());
            char[] _s = s.ToCharArray();
            String s0 = "S";

            for(int i=0; i<_s.Length; i++){
                if(_s[i] == c){
                    _s[i] = Convert.ToChar(s0);
                }
            }
            Console.WriteLine(String.Join(" ", _s));
        }
    }
}
