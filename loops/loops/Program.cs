using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////this program uses switch statements cases breaks and do statements along with a while loop 
            //Console.WriteLine("Guess a number");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //switch (number1) //switch statement.
            //{
            //    case 62:
            //        Console.WriteLine("You guessed 62. Try again");
            //        break;
            //    case 29:
            //        Console.WriteLine("You guessed 29. Try again");
            //        break;
            //    case 55:
            //        Console.WriteLine("You guessed 55. Try again");
            //        break;
            //    case 12:
            //        Console.WriteLine("you guessed the number 12. You are correct!");
            //        break;
            //    default:
            //        Console.WriteLine("You are wrong.");
            //        break;
            //}

            //Console.ReadLine();


            ////this program uses switch statements cases breaks and do statements along with a while loop 
            //Console.WriteLine("Guess a number");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            ////while loop
            //bool isGuessed2 = number2 == 12;

            //while (isGuessed2)
            //{
            //    switch (number2)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again");
            //            Console.WriteLine("Guess a number");
            //            number2 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again");
            //            Console.WriteLine("Guess a number");
            //            number2 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again");
            //            Console.WriteLine("Guess a number");
            //            number2 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("you guessed the number 12. You are correct!");
            //            isGuessed2 = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number");
            //            number2 = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}


            //Console.ReadLine();


            //this program uses switch statements cases breaks and do statements along with a while loop 
            Console.WriteLine("Guess a number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed3 = number3 == 12;

            do //do loop
            {
                switch (number3)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess a number");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again");
                        Console.WriteLine("Guess another number");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("Guess another number");
                        number3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("you guessed the number 12. You are correct!");
                        isGuessed3 = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        //Console.WriteLine("Guess a number");
                        //number3 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed3);




            //switch (number)
            //{
            //    case 62:
            //        Console.WriteLine("You guessed 62. Try again");
            //        break;
            //    case 29:
            //        Console.WriteLine("You guessed 29. Try again");
            //        break;
            //    case 55:
            //        Console.WriteLine("You guessed 55. Try again");
            //        break;
            //    case 12:
            //        Console.WriteLine("you guessed the number 12. You are correct!");
            //        break;
            //    default:
            //        Console.WriteLine("You are wrong.");
            //        break;


            //}
            Console.ReadLine();
        }
    }
}
