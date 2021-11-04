using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
            class Program
        {
            static void Main(string[] args)
            {
                List<Employee> Roster = new List<Employee>();

                Employee Luke_A = new Employee() { Id = 1, FirstName = "Luke", LastName = "Bowwer" };
                Employee Bruce_B = new Employee() { Id = 2, FirstName = "Bruce", LastName = "Lee" };
                Employee Ivan_C = new Employee() { Id = 3, FirstName = "Ivan", LastName = "TheGreat" };
                Employee Bruce_D = new Employee() { Id = 4, FirstName = "Bruce", LastName = "Wayne" };
                Employee Jim_E = new Employee() { Id = 5, FirstName = "Jim", LastName = "Plaz" };
                Employee Jeffery_F = new Employee() { Id = 6, FirstName = "Jeffery", LastName = "Knock" };
                Employee Ken_G = new Employee() { Id = 7, FirstName = "Ken", LastName = "Block" };
                Employee Zack_H = new Employee() { Id = 10, FirstName = "Zack", LastName = "Ronold" };
                Employee Germy_I = new Employee() { Id = 8, FirstName = "Germy", LastName = "Hilldon" };
                Employee Keeth_J = new Employee() { Id = 9, FirstName = "Keeth", LastName = "Richard" };
                Employee Zack_K = new Employee() { Id = 10, FirstName = "Zack", LastName = "Lemme" };

                Roster.Add(Luke_A);
                Roster.Add(Bruce_B);
                Roster.Add(Ivan_C);
                Roster.Add(Bruce_D);
                Roster.Add(Jim_E);
                Roster.Add(Jeffery_F);
                Roster.Add(Ken_G);
                Roster.Add(Zack_H);
                Roster.Add(Germy_I);
                Roster.Add(Keeth_J);
                Roster.Add(Zack_K);

                //create list of Joes using a foreach loop
                Console.WriteLine("Here is a list of all Zacks on the employee roster, found using a foreach loop:");
                List<Employee> JoeList = new List<Employee>();
                foreach (Employee employee in Roster)
                {
                    if (employee.FirstName == "Zack")
                    {
                        JoeList.Add(employee);
                        employee.SayName();
                    }
                }

                //now perform same Joe list creation using lambda expression
                Console.WriteLine("Here is a list of all Zacks on the employee roster, found using a lambda expression:");
                List<Employee> newZackList = Roster.Where(x => x.FirstName == "Zack").ToList();
                foreach (Employee employee in newZackList)
                {
                    employee.SayName();
                }

                //make list of all employees with Id number greater than 5 using lambda expression
                Console.WriteLine("Here is a list of all employees with ID greater than 5 on the roster, found using a lambda expression:");
                List<Employee> newEmployees = Roster.Where(x => x.Id > 5).ToList();
                foreach (Employee employee in newEmployees)
                {
                    employee.SayName();
                    employee.ShowID();

                }

                Console.ReadLine();

            }
        }
}
