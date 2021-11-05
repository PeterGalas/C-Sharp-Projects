using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var
{
    public class Student
    {
        public Student() : this("", "")//public student class
        {
        }

        public Student(string name, string city)
        {
            const string studentName = "Peter Galas";//student name
            var State = "Floria";//const variable State lived in
            var City = "North Port";//var const doesnt change = City
            Console.WriteLine("Student name = {0}, State = {1}, City = {2}", studentName, State, City);//connecting everything relatiable together gives answers to our variables
        }
    }
}
