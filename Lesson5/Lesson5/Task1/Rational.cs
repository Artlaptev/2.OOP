using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rational
    {
        int _numerator;
        int _denominator;
        private string Fraction
        {
            set 
            {
                string[] middleArray = value.Split('/');
                _numerator= int.Parse(middleArray[0]);
                _denominator= int.Parse(middleArray[1]);   
            }
        }

        public Rational (string fractionString)
        {
            Fraction = fractionString;
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
        public override bool Equals(object? obj)
        {
            obj=obj as Rational;
            return this==obj;
        }

        public static implicit operator float(Rational r)=>r._numerator/r._denominator;
        public static explicit operator Rational(float r)
        {
            int denominator = 10;
            string[] splitedFraction = r.ToString().Split('.');
            int part1 = (int)r;
            string part2 =splitedFraction[1];
            foreach(char ch in part2)
            {
                denominator *= 10;
            }

            return new Rational($"{denominator * int.Parse(part2) + part1}/{denominator}");
        }
        public static implicit operator int(Rational r) => (int)(r._numerator / r._denominator);
        public static explicit operator Rational(int r)
        {
            return new Rational("1/1");
        }
        public static Rational operator %(Rational r1,Rational r2)
        {
            bool flag = true;
            Rational remainder=new Rational($"{r1._numerator}/{r1._denominator}");
            while (flag)
            {
                if (remainder <= r2)
                {
                    return r1;
                    flag = false;
                }
                remainder = remainder - r2;
            }
            return null;

        }


        public static bool operator ==(Rational r1, Rational r2)
        {
            return (float)r1== (float)r2;
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return (float)r1 != (float)r2;
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            return (float)r1 < (float)r2;
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            return (float)r1 > (float)r2;
        }
        public static bool operator <=(Rational r1, Rational r2)
        {
            return (float)r1 <= (float)r2;
        }
        public static bool operator >=(Rational r1, Rational r2)
        {
            return (float)r1 >= (float)r2;
        }
        public static Rational operator +(Rational r1,Rational r2)
        {
            if(r1._denominator==r2._denominator)
            {
                return new Rational($"{r1._numerator + r2._numerator}/{r2._denominator}");
            }
            int commonDenominator=r1._denominator*r2._denominator;
            return new Rational($"{commonDenominator / r1._denominator * r1._numerator + commonDenominator / r2._denominator * r2._numerator}/{commonDenominator}");
        }
        public static Rational operator ++(Rational r1)
        {
            Rational newrat = new Rational($"{ r1._denominator}/{r1._denominator}");
            return r1+newrat;
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            if (r1._denominator == r2._denominator)
            {
                return new Rational($"{r1._numerator - r1._numerator}/{r2._denominator}");
            }
            int commonDenominator = r1._denominator * r2._denominator;
            return new Rational($"{commonDenominator / r1._denominator * r1._numerator - commonDenominator / r2._denominator * r2._numerator}/{commonDenominator}");
        }
        public static Rational operator --(Rational r1)
        {
            Rational newrat = new Rational($"{ r1._denominator}/{r1._denominator}");
            return r1 - newrat;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational($"{r1._numerator*r2._numerator}/{r1._denominator*r2._denominator}");
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return r1 * new Rational($"{r2._denominator}/{r2._numerator}");
        }
        


    }
}
