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
using System.IO;
using System.Runtime.InteropServices;

namespace DeliverX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
            InitializeComponent();


            var handle = NativeMethods.GetConsoleWindow();
            NativeMethods.ShowWindow(handle, NativeMethods.SW_SHOW);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("logs.txt");

            using (var command = new DeliverXEntities())
            {

                command.Database.Log = sw.WriteLine;


                var pracownik = command.Pracownik.Where(x => x.id_Pracownik == 1);
                sw.WriteLine("cos");
                sw.WriteLine(pracownik);
            }
        }
    }
}
