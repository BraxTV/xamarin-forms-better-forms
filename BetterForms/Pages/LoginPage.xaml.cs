using System;
using System.Collections.Generic;

using Xamarin.Forms;
using BetterForms.ViewModels;
using XLabs.Forms.Validation;
using System.Diagnostics;

namespace BetterForms.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage ()
        {
            var vm = new LoginViewModel ();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert ("Sorry", "The credentials you supplied are incorrect.", "Ok");
            InitializeComponent ();

            EmailEntry.Completed += (object sender, EventArgs e) => {
                PasswordEntry.Focus ();
            };

            PasswordEntry.Completed += (object sender, EventArgs e) => {
                vm.SubmitCommand.Execute (null);
            };



        }
    }
}

