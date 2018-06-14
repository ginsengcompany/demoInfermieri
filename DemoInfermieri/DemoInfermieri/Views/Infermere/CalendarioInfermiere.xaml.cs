using DemoInfermieri.ModelView.Infermiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoInfermieri.Views.Infermere
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarioInfermiere : ContentPage
	{
        private CalendarioInfermiereModelView z;

        public CalendarioInfermiere ()
		{
			InitializeComponent ();
            z = new CalendarioInfermiereModelView(this);
            BindingContext = z;
            z.CreaGrid(gridOrari);
        }
	}
}