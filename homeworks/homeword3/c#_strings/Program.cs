using System;

namespace c__strings
{
    class Program
    {
        static void Main(string[] args){
            Console.ForegroundColor = ConsoleColor.Red;
            // 1) String constructor
            // char[] letters = { '1', '2', '3','h','e','l','l','o'};
            // string str = new string(letters);
            // Console.WriteLine(str);

            // 2) String Interpolation
            // var info = (firstname  : "Aqzhol", lastname : "Baqatay", born : 2001, city  : "Almaty");
            // Console.WriteLine("My name is {0} {1}", info.firstname, info.lastname);
            // Console.WriteLine("I was born in {0}, {1}", info.born, info.city);


            // 3) Substrings
            // String str = "I love C#";
            // Console.WriteLine(str.Substring(2,7));
            // Console.WriteLine($"{ str.IndexOf("C")} is index of C '{str}'");
            // Console.WriteLine(str.Replace("C#", "python"));
            // Console.WriteLine($"String in lowercase : {str.ToLower()}");
            // Console.WriteLine($"String in uppercase : {str.ToUpper()}");

            // 4) StartsWith and EndsWith
            // String str = "Almaty is the best city";
            // Console.WriteLine(str.StartsWith("Almaty"));
            // Console.WriteLine(str.StartsWith("is"));
            // Console.WriteLine(str.EndsWith("city"));
            
            // 5) Trim white space
            // String str = "   Hello IITU university    ";
            // Console.WriteLine($"{str}");
            // Console.WriteLine($"{str.TrimStart()}");
            // Console.WriteLine($"{str.TrimEnd()}");

            // 6) Remove text
            // String str = "Remove a substring from the middle of the string.";
            // int index = str.IndexOf("the");
            // String removed = str.Remove(index, "the".Length);
            // Console.WriteLine(str);
            // Console.WriteLine(removed);

            // 7) Concatenate multiple strings 
            // String str = "Concatenation is the process of appending one string to the end of another string." + 
            // "You concatenate strings by using the + operator." +
            // "For string literals and string constants, concatenation occurs at compile time; " +
            // "no run-time concatenation occurs. For string variables," + 
            // "concatenation occurs only at run time.";
            // Console.WriteLine(str);

            // String[] words = { "Hello", "world", "we", "are", "studing", "c#", "programming", "language", "csse", "groups"};
            
            // var without_space = String.Concat(words);
            // Console.WriteLine($"without_space : {without_space}");

            // var with_space = String.Join("  ", words);
            // System.Console.WriteLine($"with_space : {with_space}");

            // var with_start = String.Join(" * ", words);
            // System.Console.WriteLine($"with_start : {with_start}");


            // 8) String.Split
            // var str = "hello my name is Aqzhol";
            // Console.WriteLine(str);
            // String[] list = str.Split(" ");
            // foreach(var w in list){
            //     Console.WriteLine(w);
            // }

            // 9) Search strings
            // bool is_contains(String s1, String s2){
            //     return s1.Contains(s2, System.StringComparison.CurrentCultureIgnoreCase);
            // }
            // var str = "Does a string contain text?";
            // if (is_contains(str, "CONTAIN")){
            //     Console.WriteLine($"'{str}' contains 'CONTAIN'");
            // }
            

            // 10) Parse date and time strings
            // String date_string = "March 8, 2010";
            // var date = DateTime.Parse(date_string);
            // Console.WriteLine(date);


            // 11) Merge anonimous type using local function
            // string get_info(String s, int s2){
            //     try{
            //         return $"Student {s} {s2} years old";   
            //     }catch(Exception e){
            //         return Convert.ToString(e);
            //     }
            // }

            // var student = new {name = "Aqzhol", age = 20};
            // var teacher = new {name = "GGG", age = 34};
            // var merged = Tuple.Create(student, teacher);

            // Console.WriteLine(get_info(merged.Item2.name, merged.Item2.age));
            // Console.WriteLine(get_info(merged.Item1.name, merged.Item1.age));

            // 12) TryParse method
            // String[] values = {"123", "66", "88", "55" ,"aqzhol"};

            // bool is_even(int num){
            //     return num % 2 == 0;
            // }

            // foreach(var v in values){
            //     int num;
            //     bool success = Int32.TryParse(v, out num);
            //     if(success && is_even(num)){
            //         Console.WriteLine(num);
            //     }
            // }

            // 13) Copy method
            // var a = "hello world";
            // var b = "Say hi";
            // b = System.String.Copy(a);
            // a = "Do not Say hi";
            // Console.WriteLine($"a : {a}");
            // Console.WriteLine($"b : {b}");

            // 14) Insert method
            // var str = "My name is A";
            // Console.WriteLine(str);
            // str = str.Insert(str.Length,"qzhol");
            // Console.WriteLine(str);

            // 15) PadLeft PadLeft Methods
            var str = " x repeated";
            char pad = '.';
            Console.WriteLine(str.PadLeft(16, pad));
            Console.WriteLine(str.PadRight(15, pad));
        }
    }
}
