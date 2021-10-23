using System;

namespace Daily_Student_Report_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            //asking the console to write with the writeline the two strings.
            Console.WriteLine("the tech academy");
            Console.WriteLine("student daily report");
            //console asking what your name is

            //console question for your name.
            Console.WriteLine("what is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("hello" + " " + yourname);
            //console reading answers and storing


            //requesting input of current course.
            Console.WriteLine("what course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("you currently are on course " + course);


            //requesting input of page number currently on.
            Console.WriteLine("what page number are you on:?");
            string pagenum = Console.ReadLine();
            int pagenumber = Convert.ToInt32(pagenum);//perfroms a caste conversion string to int
            Console.WriteLine("you are currently on page number " + pagenumber);


            //requesting input of help needed? boolian would be done to perform the data type statement returning true or false



            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool helpIsNeeded = Convert.ToBoolean(Console.ReadLine());
           

            //if statement
            if (helpIsNeeded == true)
            {
                Console.WriteLine("Student needs help! "); //returns our boolean statement as true help is needed
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Student does not need help! "); //returns boolean statement as false does not need help
                Console.ReadLine();

            }
            


            //requesting input of possitive expierences
            Console.WriteLine("Were there any posistive experiences you'd like to share? Please give specific.");
            string experience = Console.ReadLine();
            Console.WriteLine("Thank you for your submission of positive experiences: " + experience);

            //requesting input of feedback to your instructor
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback! " + feedback);


            //requesting input of hrs study
            Console.WriteLine("How many hours did you study today?");
            //string hoursStudys = Console.ReadLine();
            //int hoursStudy = Console.ReadLine();
            Console.WriteLine("Hour: {0}");

            //int hoursStudy =  Console.ReadLine();
            //string final = ("today your studies accounts for" + hoursStudy);
           // Console.WriteLine(final);
            //Console.ReadLine("Great job, Today your total study hours are" + hoursStudy);


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

            int num7 = 10; //simple math equation delacring int num7 and num8 with a difference of the two. division
            int num8 = 8;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);
            Console.ReadLine();


            //% sign is a modulus operator
            int num9 = 7;
            int num10 = 3;
            int remainders = num9 % num10;
            Console.WriteLine(remainders);
            Console.ReadLine();

            //odd or even remainder 1 is odd 0 is even
            int number = 57;
            int remainderz = number % 2;
            Console.WriteLine(remainderz);
            Console.ReadLine();

            //float is specific to decimals
            int num11 = 7;
            float num12 = 5.5f;
            float totals = num11 + num12;
            Console.WriteLine(totals);
            Console.ReadLine();
            //casting int totals = num11 + (Int32)num12;

            //correct way to cast a double and float variables
            double num13 = 7.03230923;
            float num14 = 5.9f;//f for decimal
            double totaal = num13 + num14;//total spelled wrong because we used (total) already.
            Console.WriteLine(totaal);
            Console.ReadLine();
            // float is a 32-bit 7 digits long and a double is a 64-bit 15-16 digits long
            //when a compiler converts a "float" to a "double" without told to, this is called
            //(implicit conversion)


            //if we wanted to convert a "double" into a "float" we would do an 
            // (explicit conversion)
            double num15 = 7.0320923;
            float num16 = 5.9f;
            float finall = (float)num15 + num16;
            Console.WriteLine(finall);
            Console.ReadLine();


        }
    }
}
