using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager.Commands.Base
{
    public abstract class FileManagerCommands
    {
        IItem item;

        public FileManagerCommands(string command, string path)
        {
            switch(command)
            {
                case "Ok":
                    item.Open(path, out DirectoryInfo dir);
                    break;
                case "Copy":
                    item.CopyTo(path);
                    break;
                case "Move":
                    item.MoveTo(path);
                    break;
                case "Delete":
                    item.Delete();
                    break;
                case "Create":
                    item.Creat();
                    break;
                case "Get Info":
                    item.GetInfo();
                    break;
                        
            }
        }
    }
}
