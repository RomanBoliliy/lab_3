﻿using System;
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
       public SignIn()
        {
            InitializeComponent();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
        
            string log = TextBoxLogin.Text.Trim();
            string pas = PasswordBox.Password.Trim();

            User user = null;
            using (ApplicationContext context = new ApplicationContext()) {
                user = context.Users.Where(b => b.Login == log && b.Password == pas).FirstOrDefault();
            
            }

            if (user != null)
            {
                MessageBox.Show("Ви успішно ввійшли!");
            }
            else { 
                MessageBox.Show("Не вірний логін, або пароль."); 
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
