using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FileManagerLogic
    {
        public void Creat()
        {

        }
        public void Delete()
        {

        }
        public void Rename()
        {

        }
        public void Move()
        {

        }
        public void CopyTo()
        {

        }
        public void Paste()
        {

        }
        public void GetContent(string dir)
        {
            List<string> content = new List<string>();
            List<string> dirs = Directory.GetDirectories(dir).ToList();
            foreach (string contentDir in dirs)
            {
                content.Add(contentDir);
            }
            List<string> files=Directory.GetFiles(dir).ToList();
            foreach(string file in files)
            {
                content.Add(file);
            }
        }
    }
}
