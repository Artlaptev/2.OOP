using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager.Factory
{
    public class UI
    {
        IItem item;
        public UI(string path)
        {
            CreateItemByTYPE(path);
        }
        private void CreateItemByTYPE(string path)
        {
            if(File.Exists(path))
                item=new FileItem(path);
            else
                item=new FolderItem(path);
        }
        public static List<string> GetContent(string directoryString)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryString);
            List<string> content = new List<string>();
            List<string> dirs = Directory.GetDirectories(directory.FullName).ToList();
            foreach (string contentDir in dirs)
            {
                content.Add(contentDir.Replace(directoryString, ""));
            }
            List<string> files = Directory.GetFiles(directory.FullName).ToList();
            foreach (string file in files)
            {
                content.Add(file.Replace(directoryString, ""));
            }
            return content;
        }
    }
}
