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
        public override string ToString()
        {
            return $"{Real}+{Imaginary}i";
        }
    }
}
