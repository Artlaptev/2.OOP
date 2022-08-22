using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FolderItem:Item,IItem
    {
        private DirectoryInfo _directory;
        
        public FolderItem(string path)
        {
            _directory = new DirectoryInfo(path);
        }

        public void CopyTo(string pathTo)
        {
            CopyContent(_directory, new DirectoryInfo(pathTo));
        }

        public void Creat()
        {
            _directory.Create();
        }

        public void Delete()
        {
            _directory.Delete();
        }

        public Dictionary<string, string> GetInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("Name", _directory.Name);
            info.Add("Size", GetSize(_directory)/1024+"Kb");
            info.Add("Created", _directory.CreationTime.ToString());
            return info;
        }

        public void MoveTo(string pathTo)
        {
            _directory.MoveTo(pathTo);
        }

        public void Open(string selectedDirectoryName, out DirectoryInfo selectedDirectory)
        {
            selectedDirectory = new DirectoryInfo($"{_directory}/{selectedDirectoryName}");
        }


        public void Rename(string newName)
        {
            string fullName = _directory.Parent + newName;
            this.MoveTo(fullName);
        }
        private static long GetSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += GetSize(di);
            }
            return Size;
        }
        private static void CopyContent(DirectoryInfo from, DirectoryInfo to)
        {
            if (Directory.Exists(to.FullName) == false)
            {
                Directory.CreateDirectory(to.FullName);
            }

            foreach (FileInfo fi in from.GetFiles())
            {
                fi.CopyTo(Path.Combine(to.ToString(), fi.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDir in from.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =to.CreateSubdirectory(diSourceSubDir.Name);
                CopyContent(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
