using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;

namespace Task1
{
    public class ACoder: ICoder
    {
        private static List<char> Codelist = Enumerable.Range(' ', 'я' - ' ' + 1).Select(c => (char)c).ToList();

        public string Encode(string str)
        {
            string result = string.Empty;
            foreach(char sym in str)
            {
                result += Codelist[Codelist.IndexOf(sym) + 1];
            }
            return result;
        }
        public string Decode(string str)
        {
            string result = string.Empty;
            foreach (char sym in str)
            {
                result += Codelist[Codelist.IndexOf(sym) - 1];
            }
            return result;
        }

    }
}
