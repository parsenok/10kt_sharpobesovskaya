using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kt_sharpobesovskaya
{
    interface IComparer<T> where T : struct
    {
        int Compare(T x, T y);
    }
    struct ComplexNumber : IComparer<ComplexNumber>
    {
        public int Compare(ComplexNumber x, ComplexNumber y)
        {
            throw new NotImplementedException();
        }
    }
    struct RationalNumber : IComparer<RationalNumber>
    {
        public int Compare(RationalNumber x, RationalNumber y)
        {
            if (x is RationalNumber)
            {
                Console.WriteLine("объекты равны");
                return 0;
            }
            else
            {
                Console.WriteLine("объекты не равны");
                return 1;
            }
            if (y is RationalNumber)
            {
                Console.WriteLine("объекты равны");
                return 0;
            }
            else
            {
                Console.WriteLine("объекты не равны");
                return 1;
            }
        }
    }
}
