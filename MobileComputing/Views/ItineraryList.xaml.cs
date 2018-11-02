using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MobileComputing.Views
{
    public partial class ItineraryList : ContentPage
    {
        public ItineraryList()
        {
            InitializeComponent();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ItineraryAdd());
        }
    }
}
