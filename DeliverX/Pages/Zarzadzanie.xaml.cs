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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeliverX.Pages
{
    /// <summary>
    /// Interaction logic for Zarzadzanie.xaml
    /// </summary>
    public partial class Zarzadzanie : Page
    {
        public Zarzadzanie()
        {
            InitializeComponent();
        }

        private void PojazdyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TypyPojazdowButton_Click(object sender, RoutedEventArgs e)
        {
            TypyPojazdowWindow TypyPojazdowWindow = new TypyPojazdowWindow();
            TypyPojazdowWindow.Show();
        }

        private void UbezpieczeniaPojazdowButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FirmyUbezpieczenioweButton_Click(object sender, RoutedEventArgs e)
        {
            FirmyUbezpieczenioweWindow FirmyUbezpieczenioweWindow = new FirmyUbezpieczenioweWindow();
            FirmyUbezpieczenioweWindow.Show();
        }

        private void TypyUbezpieczenButton_Click(object sender, RoutedEventArgs e)
        {
            TypyUbezpieczenWindow TypyUbezpieczenWindow = new TypyUbezpieczenWindow();
            TypyUbezpieczenWindow.Show();
        }

        private void TypyPrzesylekButton_Click(object sender, RoutedEventArgs e)
        {
            TypyPrzesylekWindow TypyPrzesylekWindow = new TypyPrzesylekWindow();
            TypyPrzesylekWindow.Show();
        }

        private void TypyStatusowPrzesylekButton_Click(object sender, RoutedEventArgs e)
        {
            TypyStatusowPrzesylekWindow TypyStatusowPrzesylekWindow = new TypyStatusowPrzesylekWindow();
            TypyStatusowPrzesylekWindow.Show();
        }

        private void TypyPlatnosciButton_Click(object sender, RoutedEventArgs e)
        {
            TypyPlatnosciWindow TypyPlatnosciWindow = new TypyPlatnosciWindow();
            TypyPlatnosciWindow.Show();
        }

        private void PracownicyButton_Click(object sender, RoutedEventArgs e)
        {
            PracownicyWindow PracownicyWindow = new PracownicyWindow();
            PracownicyWindow.Show();
        }

        private void UprawnieniaPracownikowButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
