using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method4
{
    class Program
    {
        public static object StaticClass { get; private set; }

        static void Main(string[] args)
        {
            Class1 mathObject = new Class1(); // Instantiating an object

            Console.WriteLine("Select a number: ");
            string user = Console.ReadLine();
            int One = Convert.ToInt32(user);

            mathObject.MyMethod(One); // Calling the method
            Console.ReadLine();


            Class1 mathObject2 = new Class1();
            // local variable defintion
            int operation1, operation2;

            // Calling a method to get the values
            mathObject2.GetValue(out operation1, out operation2);

            Console.WriteLine("After our first method call, returning the value of a : {0}", operation1);
            Console.WriteLine("After  our second method call, returns the value of b : {0}", operation2);
            Console.ReadLine();



            // Calling static method
            StaticClass.ToString();



        }
        class Test
        {
            static void Foo(int One)
            {
                Console.WriteLine("Foo(int One)");
            }

            static void Foo(string Two)
            {
                Console.WriteLine("Foo(string Two)");
            }

            static void Main()
            {
                Foo("text");
            }
        }
    }
}