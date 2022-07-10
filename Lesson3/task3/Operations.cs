using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB
{
    public class Operations
    {
        public static void GetMail(ref string line)
        {
            string[] item = line.Split('&');
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = item[i].Trim(' ');
            }
            line=item[1];
        }
    }
}
