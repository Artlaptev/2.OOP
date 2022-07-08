using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Operations
    {
         public static void GetReverse()
        {
            Console.Write("Введите строку: ");
            string inputStr = Console.ReadLine();
            char[] chars = inputStr.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
            Console.ReadKey(true);
        }
    }
}
