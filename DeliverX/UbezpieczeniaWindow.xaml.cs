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
    /// Interaction logic for UbezpieczeniaWindow.xaml
    /// </summary>
    public partial class UbezpieczeniaWindow : Window
    {
        public UbezpieczeniaWindow()
        {
            InitializeComponent();
            UbezpieczeniaFrame.Content = new WindowLogoPage();

        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            UbezpieczeniaFrame.Content = new UbezpieczeniaSprawdzPage();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            UbezpieczeniaFrame.Content = new UbezpieczeniaAktualizujPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            UbezpieczeniaFrame.Content = new UbezpieczeniaDodajPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            UbezpieczeniaFrame.Content = new UbezpieczeniaUsunPage();
        }
    }
}
