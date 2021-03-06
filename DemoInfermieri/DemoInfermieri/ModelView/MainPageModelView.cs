﻿using DemoInfermieri.Views;
using DemoInfermieri.Views.Infermere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using DemoInfermieri.Views.Utente;
using Xamarin.Forms;

namespace DemoInfermieri.ModelView
{
    class MainPageModelView : INotifyPropertyChanged
    {
        #region DichiarazioneVariabili
        //Command utilizzato per il tentativo di accesso ai servizi da parte dell'utente
        public ICommand tapDisponibilità { protected set; get; }
        public ICommand tapAppuntamenti { protected set; get; }
        public ICommand tapRichieste { protected set; get; }
        public ICommand tapProfilo { protected set; get; }

         
        public ICommand logout { protected set; get; }

        public event PropertyChangedEventHandler PropertyChanged; //evento che implementa l'interfaccia INotifyPropertyChanged
        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public MainPageModelView(MainPageInfermiere MainPage)
        {
            tapDisponibilità = new Command(async () =>
            {
              await  App.Current.MainPage.Navigation.PushAsync (new CalendarioInfermiere()) ;
            });
            tapAppuntamenti = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AppuntamentiInfermieri());
            });
            tapRichieste = new Command(async () =>
            {

            });
            tapProfilo = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new Profilo());
            });
            logout = new Command(async () =>
            {
                 App.Current.MainPage = new Login ();
            });
        }
        public MainPageModelView(MainPageUtente MainPage)
        {
            tapDisponibilità = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RichiestaUrgenza());
            });
            tapAppuntamenti = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RicercaInfermieriPage());
            });
            tapProfilo = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new Profilo());
            });
            logout = new Command(async () =>
            {
                App.Current.MainPage = new Login();
            });
        }
    }
}
