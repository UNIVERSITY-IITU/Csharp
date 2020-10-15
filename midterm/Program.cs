using System.Text.RegularExpressions;
using System.Net.Mime;
using System;
using System.Collections.Generic;  
using System.IO;


namespace midterm
{
    class Program{

        public static string extracts_html(string text){
            if(text.IndexOf("<")==-1){
                return text;
            }

            int x = text.IndexOf("<");
            int y = text.IndexOf(">", x+1);
            int length = text.Substring(x,y-x+1).Length;
            text = text.Remove(x,length);

            return extracts_html(text);
        }

        public static void extracts_email(string text, ref List<string> emails){
            if(text.IndexOf("@")==-1){
                return;
            }
            int x = text.IndexOf("@");
            int y = text.LastIndexOf(" ", x);
            int z  = text.IndexOf(" ", x);
            emails.Add(text.Substring(y+1, z-y-1));
            text = text.Remove(y, text.Substring(y+1, z-y-1).Length);
            extracts_email(text, ref emails);
        }

        public static void extract_date(string text, ref List<string> dates){
            String[] list = text.Split(" ");
            foreach(var w in list){
                if(w.Split(".").Length - 1 == 2){
                    dates.Add(w);
                }
            }
        }


        static void Main(string[] args){
            // using (FileStream fstream = File.OpenRead($"/Users/aggressiveghostsgmail.com/Desktop/Lesson/C.#/midterm/file.txt"))
            // {
            //     byte[] array = new byte[fstream.Length];
                
            //     fstream.Read(array, 0, array.Length);
                
 
            //     string text = System.Text.Encoding.Default.GetString(array);
            //     text = extracts_html(text);  
            //     Console.WriteLine(text);
                
            // }



            

            // String text = "by email at example@gmail.com or at aqzhol@gmail.com ";
            // List<string> emails = new List<string>();
            // extracts_email(text, ref emails);
            // foreach(string s in emails){
            //     Console.WriteLine(s);
            // }


            // String text = "at 14.06.1980 . My sister 28.06.2000 was born at 3.7.1984 . In";
            // List<string> dates = new List<string>();
            // extract_date(text, ref dates);

            // foreach(string s in dates){
            //     Console.WriteLine(s);
            // }
        }
    }
}
