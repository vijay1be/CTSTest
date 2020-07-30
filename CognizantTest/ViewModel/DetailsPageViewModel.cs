using System;
using System.Collections.ObjectModel;
using CognizantTest.Helper;
using CognizantTest.Models;
using SQLite;
using Xamarin.Forms;

namespace CognizantTest.ViewModel
{
    public class DetailsPageViewModel : ObservableObject
    {
        SQLConnection conn;
        public ObservableCollection<Data> EmployeDetail { get; set; }
        RestServices RequestData;
        public DetailsPageViewModel(INavigation navigation)
        {
          try
          { 
            EmployeDetail = new ObservableCollection<Data>();
            RequestData = new RestServices();
            conn = new SQLConnection();
            RequestData.RetrieveData();
            var _userlist = conn.GetAllUsers();
            EmployeDetail = new ObservableCollection<Data>(_userlist);
           }
            catch (Exception ex)
            {

            }
        }
    }
}
