using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    public class Employee<T> : Names, ExitProgram
    {
    

        public int Id { get; set; }

        public List<T> things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Do you want to exit? (y/n)");
            char yesOrNo = Convert.ToChar(Console.ReadLine());
            if (yesOrNo == 'y')
            {
                Console.WriteLine("Alright See you later!");
                System.Environment.Exit(0);
            }
            else if (yesOrNo == 'n')
            {
                Console.WriteLine("No problem...");
            }
        }
        public static bool operator ==(Employee<T> firstEmployee, Employee<T> secondEmployee)
        {
            if (firstEmployee.Id == secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee<T> firstEmployee, Employee<T> secondEmployee)
        {
            if (firstEmployee.Id != secondEmployee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
