using DemoInfermieri.ModelView;
using DemoInfermieri.ModelView.Infermiere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoInfermieri.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageInfermiere : ContentPage
	{
        private MainPageInfermiereModelView z;
        public MainPageInfermiere ()
		{
			InitializeComponent ();
            z = new MainPageInfermiereModelView(this);
            BindingContext = z;
        }
	}
}