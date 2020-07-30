using System;
using System.Collections.Generic;
using CognizantTest.ViewModel;
using Xamarin.Forms;

namespace CognizantTest.View
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            BindingContext =  new DetailsPageViewModel(Navigation);
        }
    }
}
