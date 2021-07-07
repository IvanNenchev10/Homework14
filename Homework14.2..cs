using System;
namespace Task14._2
{
    class Program
    {
        enum Season { Summer,Autumn,Winter,Spring}
        static DateTime Create()
        {
            int year, month, day;
            Console.WriteLine("Enter year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day:");
            day = int.Parse(Console.ReadLine());
            DateTime time = new DateTime(year, month, day);
            return time;
        }
        static void Print(DateTime time)
        {
            Console.Write("{0}.{1}.{2}", time.Year, time.Day, time.Month);
        }
        static Season GetMonth(DateTime time)
        {
            Season season = 0;
            if((time.Month==9 && time.Day>=23) ||  (time.Month==12 && time.Day<22) || time.Month==10 || time.Month==11)
            {
                season = Season.Autumn;
            }
            else if((time.Month==12 && time.Day>=22) || (time.Month==3 && time.Day<=21) || time.Month==1 || time.Month==2)
            {
                season = Season.Winter;
            }
            else if((time.Month==6 && time.Day>=22) || (time.Month==9 && time.Day<=22) || time.Month==7 || time.Month==8)
            {
                season = Season.Summer;
            }
            Console.Write("Season is:");
            return season;
        }
        static void Main()
        {
            DateTime time = Create();
            Print(time);
            Console.WriteLine();
            Console.WriteLine("{0}", GetMonth(time));
        }
    }
}
