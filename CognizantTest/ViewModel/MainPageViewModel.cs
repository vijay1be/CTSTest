using System;
using System.Windows.Input;
using CognizantTest.Helper;
using CognizantTest.View;
using Xamarin.Forms;

namespace CognizantTest.ViewModel
{
    public class MainPageViewModel : ObservableObject
    {
        private INavigation _navigation;

        public INavigation Navigation
        {
            get { return _navigation; }
            set { _navigation = value; }
        }
        public ICommand LoginCommand { get; set; }
        public MainPageViewModel(INavigation navigation)
        {
            try
            {
                Navigation = navigation;
                LoginCommand = new Command(async () => await Navigation.PushModalAsync(new DetailsPage()));
            }
            catch(Exception ex)
            {

            }
        }
    }
}
