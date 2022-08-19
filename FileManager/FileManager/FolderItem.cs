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
            
        }

        public void Creat()
        {
            _directory.Create();
        }

        public void Delete()
        {
            _directory.Delete();
        }

        public void GetContent(string dir)
        {
            List<string> content = new List<string>();
            List<string> dirs = Directory.GetDirectories(dir).ToList();
            foreach (string contentDir in dirs)
            {
                content.Add(contentDir);
            }
            List<string> files = Directory.GetFiles(dir).ToList();
            foreach (string file in files)
            {
                content.Add(file);
            }
        }

        public Dictionary<string, string> GetInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("Name", _directory.Name);
            info.Add("Size", GetSize(_directory)/1024+"Kb");
            info.Add("Created", _directory.CreationTime.ToString());
            return info;
            _directory.GetDirectories();
        }

        public void MoveTo(string pathTo)
        {
            _directory.MoveTo(pathTo);
        }

        public FolderItem Open(string dir)=>GetContent(dir);

        public void Rename(string newName)
        {
            throw new NotImplementedException();
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
        private static void CopyAll(DirectoryInfo from, DirectoryInfo to)
        {
            if (Directory.Exists(to.FullName) == false)
            {
                Directory.CreateDirectory(to.FullName);
            }

            foreach (FileInfo fi in from.GetFiles())
            {
                // Выводим информацию о копировании в консоль
                Console.WriteLine(@"Copying {0}\{1}", to.FullName, fi.Name);
                fi.CopyTo(Path.Combine(to.ToString(), fi.Name), true);
            }

            // Копируем рекурсивно все поддиректории
            foreach (DirectoryInfo diSourceSubDir in from.GetDirectories())
            {
                // Создаем новую поддиректорию в директории
                DirectoryInfo nextTargetSubDir =
                  to.CreateSubdirectory(diSourceSubDir.Name);
                // Опять вызываем функцию копирования
                // Рекурсия
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }
}
