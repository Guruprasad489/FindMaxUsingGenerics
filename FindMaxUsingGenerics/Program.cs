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

            while (true)
            {
                Console.Write("Please choose an option: ");
                Console.WriteLine("\n1. Find Max Of Three Int Number \n2. Find Max Of Three Float Number \n3. Find Max Of Three strings \n4. Exit");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int intnum1 = 66, intnum2 = 78, intnum3 = 56;
                        int intMax = new Maximum<int>(intnum1, intnum2, intnum3).GetMax();
                        Console.WriteLine("Maximum out of {0}, {1}, {2} integers is: {3}", intnum1, intnum2, intnum3, intMax);
                        Console.ReadLine();
                        break;
                    case 2:
                        float floatnum1 = 66.25f, floatnum2 = 24.55f, floatnum3 = 56.78f;
                        float floatMax = new Maximum<float>(floatnum1, floatnum2, floatnum3).GetMax();
                        Console.WriteLine("Maximum out of {0}, {1}, {2} floating values is: {3}", floatnum1, floatnum2, floatnum3, floatMax);
                        Console.ReadLine();
                        break;
                    case 3:
                        string str1 = "Apple", str2 = "Peach", str3 = "Banana";
                        string stringMax = new Maximum<string>(str1, str2, str3).GetMax();
                        Console.WriteLine("Maximum out of {0}, {1}, {2} strings is: {3}", str1, str2, str3, stringMax);
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }

        }
    }
}
