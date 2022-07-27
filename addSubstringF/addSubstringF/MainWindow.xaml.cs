using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TSM = Tekla.Structures.Model;
using TSMUI = Tekla.Structures.Model.UI;

namespace addSubstringF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_go_Click(object sender, RoutedEventArgs e)
        {
            Go(tb_subString.Text);
        }
        public static void Go(string subStr)
        {
            TSM.Model model = new TSM.Model();
            TSM.ModelObjectEnumerator enumerator = new TSMUI.ModelObjectSelector().GetSelectedObjects();
            while (enumerator.MoveNext())
            {
                TSM.Part part = enumerator.Current as TSM.Part;
                if(part!=null)
                {
                    part.AssemblyNumber.Prefix += subStr;
                    part.Modify();
                }
            }
            model.CommitChanges();
        }
    }
}
