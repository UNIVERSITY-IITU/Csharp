using System;
using System.Collections.Generic;
using System.Linq;
//5 Selection operator 

/*
Case20. Two integers are given: D (day) and M (month), which determine the correct date. 
Display the Zodiac sign corresponding to this date: "Aquarius" (20.1–18.2), "Fish" (19.2–20.3), 
"Aries" (21.3–19.4), Telets (20.4– 20.5), Gemini (21.5–21.6) Cancer (22.6–22.7), Lion (23.7–22.8), 
"Virgin" (23.8–22.9), Libra (23.9–22.10), Scorpio (23.10–22.11), "Sagittarius" (23.11–21.12), 
'Capricorn (22.12–19.1).
*/


namespace task5
{
    public class Zodiac{
        public int from_month {get;set;}
        public int to_month {get;set;}
        public int from_day {get;set;}
        public int to_day {get;set;}
        public string zodiac{get;set;}

        public string zodiac_name(List<Zodiac> zodiacs, int day, int month){
            var months = from zod in zodiacs
                            where zod.from_month == month 
                            || zod.to_month == month
                            select new {zod};
            if(months.First().zod.to_day >= day){
                return months.First().zod.zodiac;
            }
            return months.Last().zod.zodiac;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {   
            Zodiac zodiac = new Zodiac();
            List<Zodiac> zodiacs = new List<Zodiac>(){
                new Zodiac{from_month = 1,  to_month = 2,  from_day = 20, to_day = 18, zodiac = "Aquarius"   },
                new Zodiac{from_month = 2,  to_month = 3,  from_day = 19, to_day = 20, zodiac = "Fish"       },
                new Zodiac{from_month = 3,  to_month = 4,  from_day = 21, to_day = 19, zodiac = "Aries"      },
                new Zodiac{from_month = 4,  to_month = 5,  from_day = 20, to_day = 20, zodiac = "Telets"     },
                new Zodiac{from_month = 5,  to_month = 6,  from_day = 20, to_day = 20, zodiac = "Gemini"     },
                new Zodiac{from_month = 6,  to_month = 7,  from_day = 21, to_day = 21, zodiac = "Cancer"     },
                new Zodiac{from_month = 7,  to_month = 8,  from_day = 22, to_day = 22, zodiac = "Lion"       },
                new Zodiac{from_month = 8,  to_month = 9,  from_day = 23, to_day = 22, zodiac = "Virgin"     },
                new Zodiac{from_month = 9,  to_month = 10, from_day = 23, to_day = 22, zodiac = "Libra"      },
                new Zodiac{from_month = 10, to_month = 11, from_day = 23, to_day = 22, zodiac = "Scorpio"    },
                new Zodiac{from_month = 11, to_month = 12, from_day = 23, to_day = 21, zodiac = "Sagittarius"},
                new Zodiac{from_month = 12, to_month = 1,  from_day = 22, to_day = 19, zodiac = "Capricorn"  }
            };
            Console.Write("input day 1-31 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("input month 1-12 : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your zodiac name is : {zodiac.zodiac_name(zodiacs,day,month)}");
        }
    }
}
