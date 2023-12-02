using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection _connection = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Vhid_Click(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            Hide();

        }

        private void Button_Regester_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

            _connection.Open();
            if (_connection.State == ConnectionState.Open) 
            {
                MessageBox.Show("Connection opened");
            }

        }
    }
}