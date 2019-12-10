using System;

namespace Task14._1
{
    class Program
    {
       enum Month { January,February,March,April,May,June,July,August,September,October,November,December};
       static Month findMonth(int n)
        {
            Month month = 0;
            n--;
            switch(n)
            {
                case 0:
                    month = Month.January;
                    break;
                case 1:
                    month = Month.February;
                    break;
                case 2:
                    month = Month.March;
                    break;
                case 3:
                    month = Month.April;
                    break;
                case 4:
                    month = Month.May;
                    break;
                case 5:
                    month = Month.June;
                    break;
                case 6:
                    month = Month.July;
                    break;
                case 7:
                    month = Month.August;
                    break;
                case 8:
                    month = Month.September;
                    break;
                case 9:
                    month = Month.October;
                    break;
                case 10:
                    month = Month.November;
                    break;
                case 11:
                    month = Month.December;
                    break;
                default:
                    Console.WriteLine("No such month");
                    break;
            }
            return month;
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter month:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Month number {0} is:{1}", n, findMonth(n));
        }
    }
}
