using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace BetterForms.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion

        public Action DisplayInvalidLoginPrompt;

        private string emailAddress;

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmailAddress"));
            }
        }

        private string password;

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand SubmitCommand{ protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (emailAddress != "ben@brax.tv" || password != "letmein")
                DisplayInvalidLoginPrompt();
        }
    }
}

