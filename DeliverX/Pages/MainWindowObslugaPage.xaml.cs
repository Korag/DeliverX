﻿using System;
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
    /// Interaction logic for Obsluga.xaml
    /// </summary>
    public partial class MainWindowObslugaPage : Page
    {
        public MainWindowObslugaPage()
        {
            InitializeComponent();
        }

        private void PrzesylkaButton_Click(object sender, RoutedEventArgs e)
        {
            PrzesylkiWindow PrzesylkiWindow = new PrzesylkiWindow();
            PrzesylkiWindow.Show();
        }

        private void KursyButton_Click(object sender, RoutedEventArgs e)
        {
            KursyWindow KursyWindow = new KursyWindow();
            KursyWindow.Show();
        }

        private void KlienciButton_Click(object sender, RoutedEventArgs e)
        {
            KlienciWindow KlienciWindow = new KlienciWindow();
            KlienciWindow.Show();
        }

        private void StatusyPrzesylekButton_Click(object sender, RoutedEventArgs e)
        {
            HistoriaPrzesylekWindow HistoriaPrzesylekWindow = new HistoriaPrzesylekWindow();
            HistoriaPrzesylekWindow.Show();
        }
    }
}
