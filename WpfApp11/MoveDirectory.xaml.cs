using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MoveDirectory.xaml
    /// </summary>
    public partial class MoveDirectory : Window
    {
        public MoveDirectory()
        {
            InitializeComponent();


            MoveDirectoryInformation moveDirectory = new MoveDirectoryInformation
            {
                From = fromTextBox.Text,
                To = toTextBox.Text
            };

           
        }

        private void FromFindDirectoryButtonClick(object sender, RoutedEventArgs e)
        {
           
            OpenFileDialog openDialog = new OpenFileDialog();

            bool? result = openDialog.ShowDialog();

            if (result == true)
            {
                //fromTextBox.Text = openDialog.SelectedPath.ToString();
            }
        }

        private void ToFindDirectoryButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            bool? result = openDialog.ShowDialog();

            if (result == true)
            {
                //toTextBox.Text = openDialog.SelectedPath.ToString();
            }
        }
    }
}
