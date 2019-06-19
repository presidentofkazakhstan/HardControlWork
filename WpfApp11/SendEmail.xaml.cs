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

        
    }
}
