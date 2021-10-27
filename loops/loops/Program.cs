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
            //this program uses switch statements cases breaks and do statements along with a while loop 
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again");
                        Console.WriteLine("Guess another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("Guess another number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("you guessed the number 12. You are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            


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
