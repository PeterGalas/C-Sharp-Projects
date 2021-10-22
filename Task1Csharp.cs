using System;

namespace Daily_Student_Report_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            //asking the console to write with the WriteLine the two strings.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
           //console asking what your name is

            //console question for your name.
            Console.WriteLine("What is your name?");
            //console reading answers and storing
            Console.ReadLine();

            //requesting input of current course.
            Console.WriteLine("What Course are you on?");
            Console.ReadLine();

            //requesting input of page number currently on.
            Console.WriteLine("What Page Number?");
            Console.ReadLine();

            //requesting input of help needed? boolian would be done to perform the data type statement
            Console.WriteLine("Do you need help with anything? please answer true or false");
            Console.ReadLine();

            //requesting input of possitive expierences
            Console.WriteLine("Were there any posistive experiences you'd like to share? Please give specific.");
            Console.ReadLine();

            //requesting input of feedback to your instructor
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();

            //requesting input of hrs study
            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();

            //console stating that an instructor will get back to you shortly!
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();
            //end of program.

            int num1 = 97; //int dont take "" simple math equation delacring int num1 and 2 with a total of both
            int num2 = 43; //if you want to do subrtaction -, (difference)  insteady of total
            int total = num1 + num2; //multiply = math operator * replace total with (product)
            Console.WriteLine(total); // same / replace with (quotient)
            Console.ReadLine();

            int num3 = 10; //simple math equation delacring int num3 and num4 with a difference of the two. subtraction
            int num4 = 8; 
            int difference = num3 - num4; 
            Console.WriteLine(difference);
            Console.ReadLine();

            int num5 = 10; //simple math equation delacring int num5 and num6 with a Multiplying the two. Multiply
            int num6 = 8;
            int product = num5 * num6;
            Console.WriteLine(product);
            Console.ReadLine();

            int num7 = 10; //simple math equation delacring int num3 and num4 with a difference of the two. subtraction
            int num8 = 8;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            Console.ReadLine();


            //% sign is a modulus operator
            int num9 = 7;
            int num10 = 3;
            int remainders = num5 % num6;
            Console.WriteLine(remainders);
            Console.ReadLine();

            //odd or even remainder 1 is odd 0 is even
            int number = 57;
            int remainderz = number % 2;
            Console.WriteLine(remainderz);
            Console.ReadLine();
        }
    }
}
