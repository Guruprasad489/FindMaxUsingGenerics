using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Find Max of three numbers using generics\" program\n");

            Maximum maximum = new Maximum();

            Console.Write("Please choose an option: ");
            Console.WriteLine("\n1. Find Max Of Three Int Number \n2. Find Max Of Three Float Number \n3. Find Max Of Three strings");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int intnum1 = 66, intnum2 = 78, intnum3 = 56;
                    int intMax = maximum.GetMaxOfThree(intnum1, intnum2, intnum3);
                    Console.WriteLine("Maximum of three integers is: " + intMax);
                    break;
                case 2:
                    float floatnum1 = 66.25f, floatnum2 = 24.55f, floatnum3 = 56.78f;
                    float floatMax = maximum.GetMaxOfThree(floatnum1, floatnum2, floatnum3);
                    Console.WriteLine("Maximum of three floating values is: " + floatMax);
                    break;
                case 3:
                    string str1 = "Apple", str2 = "Peach", str3 = "Banana";
                    string stringMax = maximum.GetMaxOfThree(str1, str2, str3);
                    Console.WriteLine("Maximum of three strings is: " + stringMax);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
        }
    }
}
