using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {

        try
        {
            Console.WriteLine("Select an index from 0 to 4. \nThen, the console will display the equal value of that index.");
            Console.WriteLine("Index Animals displayed: = Cat, Dog, Lion, Bear, Whale");
            string[] stringArray = { "Cat", "Dog", "Lion", "Bear", "Whale" };

            //Console.WriteLine("Index 0 = Cats");
            //Console.WriteLine("Index 1 = Dog");
            //Console.WriteLine("Index 2 = Lion");
            //Console.WriteLine("Index 3 = Bear");
            //Console.WriteLine("Index 4 = Whale");
            //Console.ReadLine();
            //Console.WriteLine(stringArray);
            int string1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("index string is: " + stringArray[string1]);
            Console.ReadLine();

            Console.WriteLine("Select an index from 0 to 4. \nThen, the console will display the equal value of that index picked. \nIndex numbers, 88, 505, 3, 47, 50 ");
            int[] numArray = { 88, 505, 3, 47, 50 };
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Index value is: " + numArray[input]);
            Console.ReadLine();

            Console.WriteLine("Select an index from 0 to 3. \nThen, the console displays your value of that index. \nIndex names: Peter, Aaron, Mikey, Yuriy");
            List<string> list1 = new List<string>() { "Peter", "Aaron", "Mikey", "Yuriy" };
            int list2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Index equals: " + list1[list2]);
            Console.ReadLine();

        }

        catch (System.IndexOutOfRangeException)

        {
            Console.WriteLine("No index in our data, sorry!");
        }

        Console.ReadLine();

        //List<int> intList1 = new List<int>();
        //intList1.Add(4);
        //Console.ReadLine();
        //intList1.Add(10);
        //Console.ReadLine();
        //intList1.Add(20);
        //Console.ReadLine();
        ////intList1.Remove(10);
        //Console.WriteLine("pick an idex please, from 0-2");
        //Console.WriteLine();
        //Console.ReadLine();




        //List<string> intList2 = new List<string>();
        //intList2.Add("Hello");
        //intList2.Add("Jesse"); //adding to list
        //intList2.Remove("Jesse");//remvoing from list

        //Console.WriteLine(intList2[0]);
        //Console.ReadLine();

        ////byte[] byteArray = new byte[50] storing large qaunintity of numbers

        //Console.WriteLine("Please select an index from the array");
        //int[] numArray = new int[5]; //set hard to change, storing large files in bianary
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;


        ////int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };// cleaner way to write array lists
        ////int index = Console.ReadLine();
        //Console.WriteLine("you picked index ");
        //Console.WriteLine(numArray[1]);
        //Console.ReadLine();

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };//adding more values and easiest one.

        //numArray2[5] = 650;//limited by size



        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
    }
