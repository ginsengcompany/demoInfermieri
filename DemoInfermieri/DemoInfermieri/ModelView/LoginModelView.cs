using DemoInfermieri.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoInfermieri.ModelView
{
    class LoginModelView : INotifyPropertyChanged
    {
        #region DichiarazioneVariabili

        public event PropertyChangedEventHandler PropertyChanged; //evento che implementa l'interfaccia INotifyPropertyChanged

        private string username;
        private string password;
        private bool isVisibleProcessBar;

        //Command utilizzato per il tentativo di accesso ai servizi da parte dell'utente
        public ICommand effettuaLogin { protected set; get; }
        #endregion

        #region Proprietà

        public string _username
        {
            get { return username; }
            set
            {
                OnPropertyChanged();
                username = value;
            }
        }
        public string _password
        {
            get { return password; }
            set
            {
                OnPropertyChanged();
                password = value;
            }
        }
        public bool _isVisibleProcessBar
        {
            get { return isVisibleProcessBar; }
            set
            {
                OnPropertyChanged();
                isVisibleProcessBar = value;
            }
        }

        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public LoginModelView(Login loginPage)
        {
            effettuaLogin = new Command(async () => //Definisce il metodo del Command effettuaLogin che gestisce il tentativo di login da parte dell'utente
            {
                _isVisibleProcessBar = true;
                if (username == "ale" && password == "ciao")
                {
                    _isVisibleProcessBar = false;
                    App.Current.MainPage = new NavigationPage(new MainPageUtente()); //Avvia la pagina MenuPrincipale
                }
                if(username=="alex" && password == "ciao")
                {
                    _isVisibleProcessBar = false;
                    App.Current.MainPage = new NavigationPage(new MainPageInfermiere()); //Avvia la pagina MenuPrincipale
                }
            });
        }
    }
}
