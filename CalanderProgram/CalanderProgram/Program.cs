using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalanderProgram
{
    class Program
    {
            static void Main(string[] args)
            {

                try
                {
                    Console.WriteLine("Select a day of the week.");
                Console.WriteLine("Choices : Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");


                    var enumAsName = Console.ReadLine();
                    var enumFromString = Enum.Parse(typeof(weekDays), enumAsName);



                    Console.WriteLine(enumFromString);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter in a actual day of the week.");
                    Console.ReadLine();

                }

            }
            public enum weekDays
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }
        
    }
}
