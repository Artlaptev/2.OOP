using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Shapes;

namespace FileManager.Commands
{
    public class FileManagerCommand
    {
        private string _commandName;
        private string _pathForDoing;
        private IItem _item;
        private object _result;

        public object GetResult()
        {
            return _result;
        }
        public FileManagerCommand(string command, string pathOfItem, string pathForDoing)
        {
            _commandName = command;
            _pathForDoing = pathForDoing;
            CreateItemByTYPE(pathOfItem);
        }
        private void CreateItemByTYPE(string path)
        {
            if (File.Exists(path))
                _item = new FileItem(path);
            else
                _item = new FolderItem(path);
        }
        public void Execute()
        {
            switch (_commandName)
            {
                case "OK":
                    _item.Open(out string dir);
                    if(!string.IsNullOrEmpty(dir))
                        _result = GetContent(dir);
                    break;
                case "Copy":
                    _item.CopyTo(_pathForDoing);
                    break;
                case "Move":
                    _item.MoveTo(_pathForDoing);
                    break;
                case "Delete":
                    _item.Delete();
                    break;
                case "Create":
                    _item.Creat();
                    break;
                case "Get Info":
                    _item.GetInfo();
                    break;
            }

        }
        public static List<string> GetContent(string directoryString)
        {

            DirectoryInfo directory = new DirectoryInfo(directoryString);
            if (directory == null) return new List<string>();

            List<string> content = new List<string>();
            string[] dirs = Directory.GetDirectories(directory.FullName);
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
