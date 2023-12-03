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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {

        ApplicationContext db;

        public SignUp()
        {
            InitializeComponent();
            db = new ApplicationContext();

        }

        private void Button_SignUp_Click(object sender, RoutedEventArgs e)
        {
            string log = TextBoxLogin.Text.Trim();
            string pas = PasswordBox.Password.Trim();
            string pas2 = PasswordBox2.Password.Trim();
            if (log.Length < 3) { MessageBox.Show("Занадто короткий логін"); PasswordBox2.Clear(); TextBoxLogin.Clear(); }
            else if (log.Length > 10) { MessageBox.Show("Занадто довгий логін"); TextBoxLogin.Clear(); PasswordBox2.Clear(); }
            else if(pas.Length < 3) { MessageBox.Show("Занадто короткий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if(pas.Length > 10) { MessageBox.Show("Занадто довгий пароль"); PasswordBox.Clear(); PasswordBox2.Clear(); }
            else if(pas == pas2)
            {
                User user = new User(log, pas);

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Ви успішно зареєстровані!");

            }
            else {
                PasswordBox2.Clear();
                MessageBox.Show("Паролі не співпадають"); 
            }

        }


        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Hide();
        }

    }
}
