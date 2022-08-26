using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public interface IItem
    {
        public void Creat();
        public void Delete();
        public void Rename(string newName);
        public void MoveTo(string pathTo);
        public void CopyTo(string pathTo);
        public void Open(out string SelectedDirectory);
        public Dictionary<string, string> GetInfo();
    }
}
