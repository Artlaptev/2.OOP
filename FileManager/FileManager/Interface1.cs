using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public interface IItem
    {
        public void Creat();
        public void Delete();
        public void Rename();
        public void Move();
        public void Copy();
        public void Paste();
    }
}
