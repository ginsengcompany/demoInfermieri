using DemoInfermieri.ModelView;
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
        private MainPageModelView z;
        public MainPageInfermiere ()
		{
			InitializeComponent ();
            z = new MainPageModelView(this);
            BindingContext = z;
        }
	}
}