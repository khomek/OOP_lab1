using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Rational
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Rational(int num, int den) 
        {
            if (den == 0)
            {
                throw new ArgumentException("The denominator cannot be zero");
            }

            int del = Gcd(num, den);
            num /= del;
            den /= del;
            if (num * den > 0)
            {
                Numerator = Math.Abs(num);
                Denominator = Math.Abs(den);
            }
            else
            {
                Numerator = -Math.Abs(num);
                Denominator = Math.Abs(den);
            }
        }
        private static int Gcd(int num, int den)
        {
            var a = Math.Abs(num);
            var b = Math.Abs(den);
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }
        
        public override string ToString() 
        {
            if (Numerator == 0 || Denominator == 1) 
            {
                return $"{Numerator}"; 
            }
            return $"{Numerator}/{Denominator}";
        }

        public static Rational operator +(Rational a, Rational b)
        {
            var newNum = a.Numerator * b.Denominator + b.Numerator *a.Denominator;
            var newDen = a.Denominator * b.Denominator;
            return new Rational(newNum, newDen);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            var newNum =  a.Numerator*b.Denominator- b.Numerator*a.Denominator;
            var newDen = a.Denominator*b.Denominator;
            return new Rational(newNum, newDen);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            var newNum = a.Numerator * b.Numerator;
            var newDen = a.Denominator * b.Denominator;
            return new Rational(newNum, newDen);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            var newNum = a.Numerator* b.Denominator;
            var newDen = a.Denominator * b.Numerator;
            return new Rational(newNum, newDen);
        }
        public static Rational operator -(Rational a)
        {
            return new Rational(-a.Numerator, a.Denominator);
        }
        public static bool operator ==(Rational a, Rational b)
        {
            return (a.Numerator==b.Numerator)&&(a.Denominator==b.Denominator);
        }
        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        private static int Lcm(int d1, int d2)
        {
            int m = (d1 * d2) / Gcd(d1, d2);
            return m;
        }
        public static bool operator <(Rational a, Rational b)
        {
            int m = Lcm(a.Denominator, b.Denominator);
            return (a.Numerator * m < b.Numerator * m);
        }
        public static bool operator <=(Rational a, Rational b)
        {
            return a < b || a==b;
        }
        public static bool operator >(Rational a, Rational b)
        {
            int m = Lcm(a.Denominator, b.Denominator);
            return (a.Numerator * m > b.Numerator * m);
        }

        public static bool operator >=(Rational a, Rational b)
        {
            int m = Lcm(a.Denominator, b.Denominator);
            return a>b|| a==b;
        }
    }
}
