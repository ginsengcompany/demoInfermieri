using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DemoInfermieri.Model;

namespace DemoInfermieri.ModelView
{
    public class RegistrazioneModelView:INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        private Utente utenteRegistrazione;

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public Utente UtenteRegistrazione
        {
            get { return this.utenteRegistrazione; }
            set { this.utenteRegistrazione = value; }
        }

        public RegistrazioneModelView()
        {
            this.utenteRegistrazione = new Utente();
        }

       
    }
}
