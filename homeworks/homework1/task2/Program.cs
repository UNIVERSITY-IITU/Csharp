using System.Collections.Generic;
using System;

/*
All input and output data in tasks in this group are integers. 
All numbers for which the number of digits is specified 
(two-digit number, three-digit number, etc.) are considered positive.
*/

/*
The days of the week are numbered as follows: 1-Monday, 2-Tuesday,..., 6-Saturday, 7-Sunday. 
Given an integer K in the range 1-365. Determine the number of the day of the week for the 
K-th day of the year, if you know that January 1 was a Tuesday in this year.
*/

namespace task2
{
    class Program
    {
        public static string find_weekday(int day){
            Dictionary<int,string> weekdays = new Dictionary<int, string>(7);
            weekdays.Add(1,"Monday");
            weekdays.Add(2,"Tuesday");
            weekdays.Add(3,"Wednesday");
            weekdays.Add(4,"Thursday");
            weekdays.Add(5,"Friday");
            weekdays.Add(6,"Saturday");
            weekdays.Add(0,"Sunday");
            return weekdays[day];
        }
        static void Main(string[] args)
        {
            Console.Write("Enter day 0-365 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            int weekday = (day + 1) % 7;
            Console.WriteLine($"{day} of 365 is {find_weekday(weekday)}");
        }
    }
}
