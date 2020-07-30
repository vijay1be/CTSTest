using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CognizantTest.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace CognizantTest.Helper
{
    public class RestServices
    {
        private const string ConnectionURL = "http://dummy.restapiexample.com/api/v1/";
        private HttpClient client;
        public EmployDetails Items { get; private set; }
        SQLConnection Conn;
        public RestServices()
        {
            Conn = new SQLConnection();
            Conn.CreateTable();
        }

        public async void RetrieveData()
        {
            client = new HttpClient();
            Uri uri = new Uri(ConnectionURL +  "employees");
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<EmployDetails>(content);
            }

                foreach (var item in Items.data)
                    Conn.AddNewUser(item);

        }

        public  void AddData()
        {
            
        }

        public void DeleteData()
        {
           
        }
    }
}
