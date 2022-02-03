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
                        int[] intArray = { 24, 36, 09, 21 };
                        int intMax = new Maximum<int>(intArray).GetMax();
                        Console.WriteLine("Maximum out of integers is: " + intMax);
                        Console.ReadLine();
                        break;
                    case 2:
                        float[] floatArray = { 24.36f, 36.24f, 09.21f, 21.09f };
                        float floatMax = new Maximum<float>(floatArray).GetMax();
                        Console.WriteLine("Maximum out of floating values is: " + floatMax);
                        Console.ReadLine();
                        break;
                    case 3:
                        string[] strArray = { "Apple", "Peach", "Banana", "Mango" };
                        string stringMax = new Maximum<string>(strArray).GetMax();
                        Console.WriteLine("Maximum out of strings is: "+ stringMax);
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
