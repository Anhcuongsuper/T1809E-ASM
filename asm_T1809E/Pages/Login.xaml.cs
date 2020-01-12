﻿using asm_T1809E.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace asm_T1809E.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        private AuthenticationService _service = new AuthenticationService();
        public static string Token;
        public Login()
        {

            this.InitializeComponent();
        }

        private async void loGin_Click(object sender, RoutedEventArgs e)
        {
            var email = Username.Text;
            var password = Password.Password;

            Token = await this._service.LoginTask(email, password);
            Frame.Navigate(typeof(Pages.MemberInformation));    
            Debug.WriteLine(Token);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Pages.RegisterForm));


        }
    }
}
