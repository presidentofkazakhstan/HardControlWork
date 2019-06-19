using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace WpfApp11
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

        private void SendEmail(string toEmail, string header, string body)
        {
            SmtpClient client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("atynyshbayev@inbox.ru", "*Step123")
            };
            MailMessage mailMessage = new MailMessage("atynyshbayev@inbox.ru", toEmail, header, body)
            {
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            client.Send(mailMessage);
        }


        private void DownloadFile(DownloadInformation information)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync( new Uri(information.Url), information.To);
            }
        }

        private void sendEmailClick(object sender, RoutedEventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.Show();
        }

        private void dowloadFileClick(object sender, RoutedEventArgs e)
        {
            DownloadFile downloadFile = new DownloadFile();
            downloadFile.Show();
        }

        private void moveDirectoryClick(object sender, RoutedEventArgs e)
        {
            MoveDirectory moveDirectory = new MoveDirectory();

            moveDirectory.Show();
        }
    }
}
