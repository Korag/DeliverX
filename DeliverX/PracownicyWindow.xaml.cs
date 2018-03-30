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
    /// Interaction logic for PracownicyWindow.xaml
    /// </summary>
    public partial class PracownicyWindow : Window
    {
        public PracownicyWindow()
        {
            InitializeComponent();
            PracownicyFrame.Content = new Logo();
        }

        private void SprawdzButton_Click(object sender, RoutedEventArgs e)
        {
            PracownicyFrame.Content = new PracownicySprawdzPage();
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            PracownicyFrame.Content = new PracownicyAktualizujPage();
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            PracownicyFrame.Content = new PracownicyDodajPage();
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            PracownicyFrame.Content = new PracownicyUsunPage();
        }
    }
}
