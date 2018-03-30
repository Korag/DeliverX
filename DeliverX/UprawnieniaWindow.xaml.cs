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
using DeliverX.Pages;

namespace DeliverX
{
    /// <summary>
    /// Interaction logic for UprawnieniaWindow.xaml
    /// </summary>
    public partial class UprawnieniaWindow : Window
    {
        public UprawnieniaWindow()
        {
            InitializeComponent();
            UprawnieniaFrame.Content = new WindowLogoPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            UprawnieniaFrame.Content = new UprawnieniaDodajPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            UprawnieniaFrame.Content = new UprawnieniaUsunPage();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            UprawnieniaFrame.Content = new UprawnieniaAktualizujPage();
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            UprawnieniaFrame.Content = new UprawnieniaSprawdzPage();
        }
    }
}
