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
    /// Interaction logic for HistoriaPrzesylekWindow.xaml
    /// </summary>
    public partial class HistoriaPrzesylekWindow : Window
    {
        public HistoriaPrzesylekWindow()
        {
            InitializeComponent();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            HistoriaFrame.Content = new HistoriaPrzesylekAktualizujPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            HistoriaFrame.Content = new HistoriaPrzesylekDodajPage();
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            HistoriaFrame.Content = new HistoriaPrzesylekSprawdzPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            HistoriaFrame.Content = new HistoriaPrzesylekUsunPage();
        }
    }
}
