using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoInfermieri.Views.Utente
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RicercaInfermieriPage : ContentPage
	{
        private List<string> listaInfermieri = new List<string>();
		public RicercaInfermieriPage ()
		{
			InitializeComponent ();
            InserimentoInfermieri();
		}

	    public void InserimentoInfermieri()
	    {
            listaInfermieri.Add("Sommo 3km 23/06/2018, 5 euro");
	        listaInfermieri.Add("Alessio 0.5km 15/06/2018, 9.99 euro");
	        listaInfermieri.Add("Aldo 0.7km 16/06/2018, 10 euro");
	        listaInfermieri.Add("Antonio 2km 30/06/2018, 20 euro");
	        listaInfermieri.Add("Bombolone 2.5km 20/06/2018, 12.35 euro");
	        listaInfermieri.Add("Marco 3km 23/06/2018, 15 euro");
	        listaInfermieri.Add("Francesco 4km 13/06/2018, 10 euro");
        }
	    private void RicercaAvviata(object sender, EventArgs e)
	    {
	        ListaRisultatiRicerca.ItemsSource = listaInfermieri;
	        ListaRisultatiRicerca.IsVisible = true;

	    }
	}
}