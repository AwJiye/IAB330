using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileComputing.Views
{
    public partial class BucketList : ContentPage
    {
        public BucketList()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BucketAdd());
        }
    }
}
