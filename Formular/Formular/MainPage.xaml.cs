﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formular
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Save_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("New member", "New member has been saved", "Close");
        }
    }
}
