using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class Maximum<T> where T : IComparable                   //Generic class
    {
        public T num1, num2, num3;

        public Maximum(T num1, T num2,T num3)                      //Constructor
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        //Using generic Method to find Max out of three values
        private static T GetMaxOfThree(T num1, T num2, T num3)       
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            return default;
        }
        public T GetMax()
        {
            T maxValue = Maximum<T>.GetMaxOfThree(this.num1, this.num2, this.num3);
            return maxValue;
        }

    }
}
