﻿using DataHelp.Services;
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

namespace Chat_Project
{
    /// <summary>
    /// Interaction logic for WindowRegister.xaml
    /// </summary>
    public partial class WindowRegister : Window
    {
        public WindowRegister()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            bool registered = false;

            if (TbPassword.Password == TbRePassword.Password)
            {
                registered = RegisterService.RegisterUser(TbEmail.Text, TbUsername.Text, TbPassword.Password);
            }

            if (registered)
			{
                WindowLogin windowLogin = new WindowLogin();
                windowLogin.Show();
                this.Hide();
            }
			else 
            {
                LblEmail.Foreground = Brushes.Red;
                LblEmail.Text = "Check your email or password!";
            };
            
        }
    }
}
