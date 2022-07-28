using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TSM = Tekla.Structures.Model;
using TSMUI = Tekla.Structures.Model.UI;

namespace GetAllLevels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.EnumerateFileSystemEntries(@"C:\Users\Laptev_AR\Desktop\TSSupport").ToList();
            TSM.Model model = new TSM.Model();
            TSM.ModelObjectEnumerator enumer = new TSMUI.ModelObjectSelector().GetSelectedObjects();
            int level =0;
            while(enumer.MoveNext())
            {
                TSM.Assembly assembly = enumer.Current as TSM.Assembly;
                
                GetAssemblyPosAndLevel(assembly, ref level);
                
            }
            Console.WriteLine($"готово");
            
            Console.ReadKey();
        }
        public static void GetAssemblyPosAndLevel(TSM.Assembly assembly,ref int level)
        {
            string assPos = "";
            assembly.GetReportProperty("ASSEMBLY_POS", ref assPos);
            Console.WriteLine($"{level} {assPos}");
            ArrayList array = assembly.GetSubAssemblies();
            if(array.Count>0)level++;
            foreach (TSM.Assembly sub in array)
            {
                GetAssemblyPosAndLevel(sub,ref level) ;
            }   
        }
         
    }
}
