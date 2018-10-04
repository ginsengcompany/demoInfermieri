using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoInfermieri.ModelView;
using Syncfusion.XForms.DataForm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoInfermieri.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrazione : ContentPage
    {
        private RegistrazioneModelView modelview;
        public Registrazione()
        {
            InitializeComponent();
            modelview= new RegistrazioneModelView();
            BindingContext = modelview;
        }

        private void registrazioneEvent(object sender, EventArgs e)
        {
        }
    }
}