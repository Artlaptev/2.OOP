using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileItem:Item,IItem
    {
        FileInfo _file;
        public FileItem(string path)
        {
            _file=new FileInfo(path);
        }

        public void CopyTo(string path)
        {
            _file.CopyTo(path);
        }

        public void Creat()
        {
            _file.Create();
        }

        public void Delete()
        {
            _file.Delete();
        }

        public Dictionary<string, string> GetInfo()
        {
            Dictionary<string, string> info = new Dictionary<string,string>();
            info.Add("Name", _file.Name);
            info.Add("Type", _file.Name.Substring(_file.Name.IndexOf('.')));
            info.Add("Size", (_file.Length/1024)+"Kb");
            info.Add("Created", _file.CreationTime.ToString());
            return info;
        }

        public void MoveTo(string pathTo)
        {
            _file.MoveTo(pathTo);
        }

        public void Open(string selectedDirectoryName, out DirectoryInfo selectedDirectory)
        {
            selectedDirectory = null;
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName =_file.FullName;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        public void Rename(string newName)
        {
            string fullName=_file.DirectoryName + newName;
            this.MoveTo(fullName);
        }
    }
}
