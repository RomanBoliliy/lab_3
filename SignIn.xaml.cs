using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        private SqlConnection _connection = null;
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Login FROM [table]", _connection);
            command.ExecuteNonQuery();
            if (TextBoxLogin.Text ==  && PasswordBox.Password == )
            {
                MessageBox.Show("Успішно авторизовано!");
            }
            else 
            {
                MessageBox.Show("Авторизація не вдалася, повторіть спробу.");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

            _connection.Open();
        }
    }
}
