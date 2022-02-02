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
            int intmax = maximum.GetMaxOfThree(66, 55, 78);
            Console.WriteLine("Maximum of three integers is: "+ intmax);
        }
    }
}
