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
    /// Interaction logic for KursyWindow.xaml
    /// </summary>
    public partial class KursyWindow : Window
    {
        public KursyWindow()
        {
            InitializeComponent();
            KursyFrame.Content = new WindowLogoPage();
        }

        private void DodajPaczkeButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyDodajPaczkePage();
        }

        private void UsunPaczkeButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyUsunPaczkePage();
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursySprawdzPage();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyAktualizujPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyDodajPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyUsunPage();
        }

        private void GenerujListeButton_Click(object sender, RoutedEventArgs e)
        {
            KursyFrame.Content = new KursyListaPage();
        }
    }
}
