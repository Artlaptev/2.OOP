using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Complex
    {
        int Real;
        int Imaginary;

        private string  PropComplex
        {

            set
            {
                value = value.Trim('i');
                string [] elements = value.Split('+');
                Real = int.Parse(elements[0]);
                Imaginary = int.Parse(elements[1]);
            }
            
        }
        public Complex(string complexNumber)
        {
            PropComplex = complexNumber;
        }
        private Complex (int real,int img)
        {
            Real = real;
            Imaginary = img;
        }
        public override string ToString()
        {
            return $"{Real}+{Imaginary}i";
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex((c1.Real * c2.Real- c1.Imaginary * c2.Imaginary), c1.Real * c2.Imaginary - c1.Imaginary * c2.Real);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex((c1.Real * c2.Real - c1.Imaginary * c2.Imaginary)/(c2.Imaginary*c2.Imaginary+c2.Real*c2.Real), (c1.Real * c2.Imaginary - c1.Imaginary * c2.Real)/ (c2.Imaginary * c2.Imaginary + c2.Real * c2.Real));
        }

    }
}
