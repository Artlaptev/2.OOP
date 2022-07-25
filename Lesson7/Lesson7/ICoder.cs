using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ICoder
    {
        public string Encode(string str);
        public string Decode(string str);
    }
}
