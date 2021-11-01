using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Here are a list of numbers that will be divided in each equation. Your input will be, first divided by 2, then 4, and your final will divide by 8");
            //Console.WriteLine(intList[2]);
            Console.ReadLine();
            //Console.WriteLine("Please pick a number from index list!");
            //Console.WriteLine("2, 4, 8");
            //int[] numArray1 = new int[] { 2, 4, 8, };
            int numOne = 2;
            int numTwo = 4;
            int numThree = 8;
            Console.ReadLine();

            try
            {

                Console.WriteLine("First Part");
                Console.WriteLine("Pick a number Your first equation will divided your answer by 2.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Pick a Second number.");
                //int numberTwo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Divide the two numbers by 2...");
                int numberThree = numberOne / numOne;
                Console.WriteLine("Your answer is " + numberOne + " divide by " + numOne + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write down a whole number.");//(ex.Message);//error message
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero, error message!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
            try
            {

                Console.WriteLine("Second Part");
                Console.WriteLine("Pick a number Your Second equation will divided your answer by 4.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Pick a Second number Master.");
                //int numberTwo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Divide the two numbers by 2...");
                int numberFour = numberOne / numTwo;
                Console.WriteLine("Your answer is " + numberOne + " divide by " + numTwo + " equals " + numberFour);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write down a whole number.");//(ex.Message);//error message
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero, error message!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }

            try
            {

                Console.WriteLine("Third Part");
                Console.WriteLine("Pick a number Your first equation will divided your answer by 8.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Pick a Second number Master.");
                //int numberTwo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Divide the two numbers by 2...");
                int numberEight = numberOne / numThree;
                Console.WriteLine("Your answer is " + numberOne + " divide by " + numThree + " equals " + numberEight);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write down a whole number.");//(ex.Message);//error message
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero, error message!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }

            try
            {

                Console.WriteLine("Users input of two numbers choosen, dividing them as an equation, resulting in an answer");
                Console.WriteLine("Pick a number?");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a Second number?");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two numbers by 2...");
                int numberAnswer = numberOne / numberTwo;
                Console.WriteLine("Your answer is " + numberOne + " divide by " + numTwo + " equals " + numberAnswer);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write down a whole number.");//(ex.Message);//error message
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero, error message!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
