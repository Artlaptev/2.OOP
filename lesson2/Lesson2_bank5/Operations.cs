using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_bank
{
    public static class Operations
    {
        static string StringReverse(string mystriing)
        {
            char[] chars = mystriing.ToCharArray();
            Array.Reverse(chars);
            return chars.ToString();
        }
    }
}
