using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_page_program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CarList = { "", "", "", "", "", "" };
            Console.WriteLine("Write down 6 of your favorite cars: ");
            for (int p = 0; p < 6; p++)
            {
                CarList[p] = (p + 1) + ". " + Console.ReadLine();
            }

            Console.WriteLine("\nUpdate. Here's the car list that you have provided: \n");
            for (int p = 0; p < 6; p++)
            {
                Console.WriteLine(CarList[p]);
            }

            Console.WriteLine("\nThank you for the list. please choose an even number between 1 and 100.");

            int evenNumber = 0;

            while (!int.TryParse(Console.ReadLine(), out evenNumber))
            {
                Console.WriteLine("Seems you didn't enter in a number.");
                Console.WriteLine("Please pick an even number between 1 and 100.");
            }

            while (evenNumber > 100 || evenNumber < 1)
            {
                Console.WriteLine("Try again. Pick a number between 1 and 100.");

                while (!int.TryParse(Console.ReadLine(), out evenNumber))
                {
                    Console.WriteLine("I think you didn't enter a number.");
                    Console.WriteLine("Please pick a number between 1 and 100.");
                }
            }

            Console.WriteLine("You should have picked number 100. Now it's going to print forever in an endless loop!\n");

            for (int p = 0; p > evenNumber; p++)
            {
                Console.WriteLine(evenNumber);
            }

            for (int p = 0; p < evenNumber; p++)
            {
                Console.WriteLine(evenNumber + "" + (p + 1));
            }
            Console.WriteLine("No it's not an endless loop. sorry");
            Console.ReadLine();

            for (int p = 1; p <= evenNumber; p++)
            {
                Console.WriteLine(evenNumber + "" + (p));
            }

            Console.WriteLine("This was an endless loop.");

            List<string> BrandsList = new List<string>();
            string[] Brands = { "Nike", "Addidas", "Gucci", "The NorthFace", "Jeezy" };
            BrandsList.AddRange(Brands);

            foreach (string Brand in BrandsList)
            {
                Console.WriteLine(Brands);
            }

            Console.WriteLine("Please type one of the Brands listed above.");
            string searchBrands = Console.ReadLine();

            foreach (string brand in BrandsList)
            {
                if (searchBrands == brand)
                {
                    Console.WriteLine(searchBrands + " is at index value: " + BrandsList.IndexOf(searchBrands));
                }
                if (!BrandsList.Contains(searchBrands))
                {
                    Console.WriteLine("That's not on the list. Please try again.");
                    searchBrands = Console.ReadLine();
                }
            }

            List<string> secondBrandList = new List<string>();
            string[] carBrands = { "Toyota", "BMW", "Mercedes", "Nissan", "Ferrari", "Cadillac", "Honda", "Audi" };
            secondBrandList.AddRange(carBrands);

            foreach (string brand in secondBrandList)
            {
                Console.WriteLine(carBrands);
            }

            Console.WriteLine("\nWe have another list of Brands here. Type in one of them to see how many indices it appears in.");
            searchBrands = Console.ReadLine();
            int i = 0;

            foreach (string brand in secondBrandList)
            {
                if (Brands == carBrands) 
                {
                    i++;
                }

            }

            if (!secondBrandList.Contains(searchBrands))
            {
                Console.WriteLine("That's not in the list. Please try again.");
                searchBrands = Console.ReadLine();
            }

            Console.WriteLine("It looks like " + searchBrands + " list " + i + " \n");
            Console.ReadLine();

            List<string> stocksList = new List<string>();
            string[] stocks = { "AMC", "GME", "NFLX", "SPY", "TSLA", "AAPL", "DOW" };
            stocksList.AddRange(stocks);
            foreach (string stock in stocksList)
            {
                Console.WriteLine(stock);
            }
            Console.WriteLine("\nHere's a list of drinks, let's see what the duplicates are.\n");

            int d = 0;
            List<string> checkList = new List<string>();



            foreach (string stock in stocksList)
            {
                if (checkList.Contains(stock))
                {
                    Console.WriteLine(stock + " has already appeared on this list!");
                    d++;
                }
                if (!checkList.Contains(stock))
                {
                    Console.WriteLine(stock + " has not yet appeared on this list!");
                    checkList.Add(stock);
                }

            }

            Console.WriteLine("Looks like there were " + d + " duplicates in there.");

            Console.ReadLine();

        }
    }
}
