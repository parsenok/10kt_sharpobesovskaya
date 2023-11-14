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
        double A { get; }
        double B { get; }
        public ComplexNumber (double a, double b)
        {
            A = a; B = b;
        }
        public int Compare(ComplexNumber x, ComplexNumber y)
        {
            double First = x.A* x.A+x.B* x.B;
            double Second = y.A * y.A + y.B * y.B;
            if (First>Second)
            {
                return -1;
            }
            else if(First < Second)
            {
                
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    struct RationalNumber : IComparer<RationalNumber>
    {
        public double A { get; }
        public double B { get; }
        public RationalNumber(double a, double b)
        {
            A = a; B = b;
        }
        public int Compare(RationalNumber x, RationalNumber y)
        {
            double First = x.A / x.A;
            double Second = x.B / x.B;
            if (First > Second)
            {
                return -1;
            }
            else if (First < Second)
            {

                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber1 = new ComplexNumber(2.2,4.6);
            ComplexNumber complexNumber2 = new ComplexNumber(1.2, 3.6);
            RationalNumber rationalNumber1 = new RationalNumber(5, 4);
            RationalNumber rationalNumber2 = new RationalNumber(15, 43);
            ComplexNumber foranswer = new ComplexNumber();
            RationalNumber foranswer2 = new RationalNumber();
            var answer = foranswer.Compare(complexNumber1,complexNumber2);
            var answer2 = foranswer2.Compare(rationalNumber1, rationalNumber2);
            Console.WriteLine(answer);
            Console.WriteLine(answer2);
        }
    }
}
