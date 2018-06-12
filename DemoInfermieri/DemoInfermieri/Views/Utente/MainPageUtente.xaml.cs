﻿using DemoInfermieri.ModelView;
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
	public partial class MainPageUtente : ContentPage
    {
        private MainPageModelView z;
        public MainPageUtente ()
		{
			InitializeComponent ();
            z = new MainPageModelView(this);
            BindingContext = z;
        }
	}
}