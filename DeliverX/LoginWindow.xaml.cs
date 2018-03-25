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

namespace DeliverX
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
           

            // s= "Select * FROM KONTO WHERE Usr = @USR AND PASS = @PSW" ;
            // SqlCommand cmd = new SqlCommand(s, connect);
            // cmd.Parameters.AddWithValue("@USR", txtUsr.Text);
            // cmd.Parameters.AddWithValue("@PSW", txtPsw.Text);
            // cmd.ExecuteReader();
            // NewQuery();

            // Procedua składowana
            // s="CREATE PROCEDURE LB @USR varchar(16), @PSW varchar(16), @STK int AS SELECT * FROM BANK WHERE USR=@USR AND PSW=@PSW;
            // cmd = new SqlCommand(s,connect);
            // cmd.ExecuteNonQuery();
            // cmd = new SqlCommand(LB,connect)
            // cmd.Parameters.AddWithValue("@USR", txtUsr.Text);
            // cmd.Parameters.AddWithValue("@PSW", txtPsw.Text);
            //ExecuteReader();

            // var Q = cts.LB(txtUsr.Text, txtPass.Text)


            this.Hide();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            UserNameBox.Text = null;
            PasswordBox.Password = null;
        }
    }
}
