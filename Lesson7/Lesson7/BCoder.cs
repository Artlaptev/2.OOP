using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;

namespace Task1
{
    public class BCoder: ICoder
    {
        private static List<char> Codelist = Enumerable.Range('А', 'я' - 'А' + 1).Select(c => (char)c).ToList();

        public string Encode(string str)
        {
            string result = string.Empty;
            foreach(char sym in str)
            {
                if (sym == ' ')
                    result += sym;
                else
                {
                    int indexOfSymbol = Codelist.IndexOf(sym);
                    result += Codelist[Codelist.Count - 1 - indexOfSymbol];
                }
            }
            return result;
        }
        public string Decode(string str)
        {
            return Encode(str);
        }

    }
}
