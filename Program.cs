using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disekto_etos
{
    class Program
    {
        private static bool LeapYearCalculatorMain()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------Leap Year Calculator---------------------------------------\n");

            Console.WriteLine("To calculate if the year is leap, Press '1': ");
            Console.WriteLine("To 'Exit', Press '2': ");

            switch (Console.ReadLine())
            {
                case "1":
                    LeapYearCalculator();
                    Console.WriteLine("Press a kay to return to main menu");
                    Console.ReadKey();
                    return true;
                case "2":
                    return false;
                default:
                    return true;
            }

         }

        private static void LeapYearCalculator()
        {
            int year = 1;
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"\nYear {year} is Leap");

            }
            else
            {
                Console.WriteLine($"\nYear {year} is not Leap");
            }

            

        }


        static void Main(string[] args)
        {
            

            while (LeapYearCalculatorMain());

        }
    }
}
