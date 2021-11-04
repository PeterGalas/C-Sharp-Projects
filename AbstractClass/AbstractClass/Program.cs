using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
            static void Main(string[] args)
            {
                Employee<string> sampleEmployee = new Employee<string>();
                sampleEmployee.FirstName = "Sample";
                sampleEmployee.LastName = "Student";
                sampleEmployee.Id = 1;
                sampleEmployee.things = new List<string>() { "Mac Book", "Keyboard", "Mouse", "Windows", "Internet" };
                sampleEmployee.SayName();
                Console.WriteLine("Employee ID: " + Convert.ToString(sampleEmployee.Id));
                Console.WriteLine("First Employee's  wish List is :");
                foreach (string tool in sampleEmployee.things)
                {
                    Console.WriteLine(tool);
                }

                Employee<string> employeeTwo = new Employee<string>();
                employeeTwo.Id = 1;
                bool sameIDs = employeeTwo == sampleEmployee;
                Console.WriteLine("sampleEmployee and employeeTwo have identical IDs: " + Convert.ToString(sameIDs));
                Employee<int> employeeThree = new Employee<int>();
                employeeThree.things = new List<int>() { 7, 21, 14 };
                Console.WriteLine("Employee Three's Favorite Numbers:");
                foreach (int num in employeeThree.things)
                {
                    Console.WriteLine(Convert.ToString(num));
                }

                sampleEmployee.Quit();

                ExitProgram quitTime = new Employee<double>();


            Console.WriteLine("It's time to go...");
            quitTime.Quit();

            }
        
    }
}
