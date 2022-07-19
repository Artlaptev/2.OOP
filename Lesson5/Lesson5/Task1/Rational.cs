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
            get { return this.ToString(); }
            set { _numerator = int.Parse(value.Split('/')[0]); }
        }


    }
}
