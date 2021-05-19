using static System.Math;
using System;
namespace MyApplication
{
    class program
    {
        static void Main(string[] args)
        {
            string[] planets ={"Venus","Mars","Jupiter","Neptune"};
            float [] time = {0.61519726f,1.8808158f,11.862615f,164.79132f};
            int  space_time=631154000;
            //int space_time=1000000000;
            int Earth_time=31557600;
            float  Age1=space_time/Earth_time;
            float Age2;
            for (int i = 0; i <planets.Length; i++)
            {
                Age2=Age1/time[i];
                Console.WriteLine("Earth age:"+Age1+"Earth-years old"+"\t"+planets[i]+"\t"+"age:"+Age2+"Earth-years old");
            }
            
        }
    }
}