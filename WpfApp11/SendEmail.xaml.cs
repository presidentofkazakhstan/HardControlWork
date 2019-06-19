using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для SendEmail.xaml
    /// </summary>
    public partial class SendEmail : Window
    {
        public SendEmail()
        {
            InitializeComponent();

            EmailInformation email=  new EmailInformation
            {
                Recipient = recipientTextBox.Text,
                Header = headerTextBox.Text,
                Body = new TextRange(bodyRichBox.Document.ContentStart, bodyRichBox.Document.ContentEnd).Text
            };
        }

        private void EmailSend(string toEmail, string header, string body)
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


    }
}
