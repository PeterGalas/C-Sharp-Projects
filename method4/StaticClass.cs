using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method4
{ 
    static class StaticClass
{ 
     
    static string F_Name = "Peter Jr.";
    static string L_Name = "Galas";

    public static void details()
    {
        Console.WriteLine("First name: " + F_Name);
        Console.WriteLine("Last name: " + L_Name);
        Console.ReadLine();
    }


}
}