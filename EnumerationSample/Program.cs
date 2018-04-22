using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationSample
{
    public enum TimeOfDay
    {
        Morning=0,
        AfterNone=1,
        Evening=2
    }
    public enum Color:short
    {
        Red,
        Green,
        Blue
    }
    [Flags]
    public enum DaysOfWeek
    {
        Monday=1,
        Tuseday=2,
        Wednesday=4,
        Thussday=8,
        Frdiday=16,
        Saturday=32,
        Sunday=64,
        Weekend=Saturday|Sunday,
        workday=31,
        AllWeek=workday|Weekend
    }

    class Program
    {
        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good Morning");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good Evening");
                    break;
                case TimeOfDay.AfterNone:
                    Console.WriteLine("Good AfterNone");
                    break;
                default:
                    Console.WriteLine("hello");
                    break;

            }
        }

        static void Main(string[] args)
        {
            WriteGreeting(TimeOfDay.Morning);
            //Print Enum Value:
            TimeOfDay time = TimeOfDay.Evening;
            Console.WriteLine(time);


            //Color Printed to console :
            Color c1 = Color.Red;
            Console.WriteLine($"Color : {c1}");

            //Convert from int to color and then from color to short
            Color c2 =(Color) 1;
            short number =(short) c2;
            Console.WriteLine($"Color : {c2}");
            Console.WriteLine($"Color As Number : {number}");
            //Convert String To Color Value
            string strColor = "Black";
            Color black;
            if(Enum.TryParse<Color>(strColor,out  black ))
            {
                Console.WriteLine($"string {strColor} successfuly parsed to color value {black}");
            }
        }
    }
}
