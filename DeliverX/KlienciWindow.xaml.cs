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
    /// Interaction logic for KlienciWindow.xaml
    /// </summary>
    public partial class KlienciWindow : Window
    {
        public KlienciWindow()
        {
            InitializeComponent();
            KlienciFrame.Content = new Logo();
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            KlienciFrame.Content = new KlienciSprawdzPage();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            KlienciFrame.Content = new KlienciAktualizujPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            KlienciFrame.Content = new KlienciDodajPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            KlienciFrame.Content = new KlienciUsunPage();
        }
    }
}
