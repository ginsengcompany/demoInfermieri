using DemoInfermieri.Views;
using DemoInfermieri.Views.Infermere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoInfermieri.ModelView.Infermiere
{
    class MainPageInfermiereModelView : INotifyPropertyChanged
    {
        #region DichiarazioneVariabili
        //Command utilizzato per il tentativo di accesso ai servizi da parte dell'utente
        public ICommand tapCalendario { protected set; get; }
        public ICommand tapAppuntamenti { protected set; get; }

        public event PropertyChangedEventHandler PropertyChanged; //evento che implementa l'interfaccia INotifyPropertyChanged
        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public MainPageInfermiereModelView(MainPageInfermiere MainPage)
        {
            tapCalendario = new Command(async () =>
            {
              await  App.Current.MainPage.Navigation.PushAsync (new CalendarioInfermiere()) ;
            });
            tapAppuntamenti = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AppuntamentiInfermieri());
            });
        }
    }
}
