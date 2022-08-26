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
using System.IO;

namespace FileManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Manager _ManagerLeft;
        private Manager _ManagerRight;
        public class Manager
        {
            private DirectoryInfo _curreantDirectory;
            private TextBox _path;
            private ListBox _mngr;
            Button _ok;
            Button _copy;
            Button _move;
            Button _delete;
            Button _create;
            public Manager(DirectoryInfo curreantDirectory, TextBox path, ListBox mngr, Button ok, Button copy, Button move, Button delete, Button create)
            {
                _curreantDirectory = curreantDirectory;
                _path = path;
                _mngr = mngr;
                _ok = ok;
                _copy = copy;
                _move = move;
                _delete = delete;
                _create = create;
                this.WriteContent(Commands.FileManagerCommand.GetContent(curreantDirectory.FullName));
            }
            internal void WriteSelectedItemInTextBox()
            {
                if (_mngr.SelectedItems.Count == 1)
                    _path.Text = _curreantDirectory.FullName + _mngr.SelectedItem.ToString();
            }
            private void WriteContent(List<string> content)
            {
                _mngr.Items.Clear();
                foreach (string item in content)
                    _mngr.Items.Add(item);
            }
            private void WriteDrives()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                    _mngr.Items.Add(drive.Name);
            }
            private void OKlogic (TextBox tb_forordoing)
            {
                Commands.FileManagerCommand command = new Commands.FileManagerCommand(_ok.Content.ToString(), _path.Text, tb_forordoing.Text);
                command.Execute();
                List<string> result = (List<string>)command.GetResult();
                if (result != null)
                {
                    WriteContent((List<string>)command.GetResult());
                    _curreantDirectory = new DirectoryInfo(_path.Text);
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void lb_leftmngr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*            if (lb_leftmngr.SelectedItems.Count==1)
                            tb_leftPath.Text = _curreantDirectoryLeft.FullName + lb_leftmngr.SelectedItem.ToString();*/

            _ManagerLeft.WriteSelectedItemInTextBox();
        }

        private void lb_rightmngr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _ManagerRight.WriteSelectedItemInTextBox();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*_curreantDirectoryLeft = new DirectoryInfo(tb_leftPath.Text);
            WriteContent(Commands.FileManagerCommand.GetContent(tb_leftPath.Text), lb_leftmngr);
            WriteContent(Commands.FileManagerCommand.GetContent(tb_rightPath.Text), lb_rightmngr);*/

            _ManagerLeft = new Manager(new DirectoryInfo(@"C:\"), tb_leftPath,lb_leftmngr, b_okL, b_copyL, b_moveL, b_deleteL, b_createL);
            _ManagerRight = new Manager(new DirectoryInfo(@"C:\"), tb_rightPath, lb_rightmngr, b_okL, b_copyR, b_moveR, b_deleteR, b_createR);
        }

        private void WriteContent(List<string> content,ListBox mngr)
        {
            mngr.Items.Clear();
            foreach (string item in content)
                mngr.Items.Add(item);
        }

/*        private void OK(Button b, TextBox tb_current,TextBox tb_forordoing, ListBox mngr )
        {
            Commands.FileManagerCommand command = new Commands.FileManagerCommand(b.Content.ToString(), tb_current.Text, tb_forordoing.Text);
            command.Execute();
            List<string> result = (List<string>)command.GetResult();
            if (result != null)
            {
                WriteContent((List<string>)command.GetResult(),mngr);
                _curreantDirectoryLeft = new DirectoryInfo(tb_leftPath.Text);
            }
        }*/

        private void b_okL_Click(object sender, RoutedEventArgs e)
        {
            /*OK(b_okL, tb_leftPath, tb_rightPath, lb_leftmngr);*/
        }
        private void b_okR_Click(object sender, RoutedEventArgs e)
        {
            /*OK(b_okR,tb_rightPath, tb_leftPath, lb_rightmngr);*/
        }
        private Commands.FileManagerCommand CreatCommand(Button b, string pathOfSelectedItem, string pathForDoing)
        {
            return new Commands.FileManagerCommand(b.Content.ToString(), pathOfSelectedItem, pathForDoing);
        }

        private void tb_leftPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*if (Directory.Exists(tb_leftPath.Text))*/
                
            
        }


    }
}
