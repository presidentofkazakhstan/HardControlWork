using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для DownloadFile.xaml
    /// </summary>
    public partial class DownloadFile : Window
    {
        public DownloadFile()
        {
            InitializeComponent();

             DownloadInformation  download = new DownloadInformation
             {
                 Url = urlTextBox.Text,
                 To = toTextBox.Text
             };
        }
        private void FileDownload(DownloadInformation information)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri(information.Url), information.To);
            }
        }


    }
}
