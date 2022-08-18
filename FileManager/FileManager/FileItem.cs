using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileItem
    {
        private string _name;
        private string _path;
        FileInfo _file;
        public FileItem(string path)
        {
            FileInfo file = new FileInfo(path);

        }
    }
}
