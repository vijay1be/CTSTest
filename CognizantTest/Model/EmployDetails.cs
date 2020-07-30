using CognizantTest.Helper;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantTest.Models
{
    public class EmployDetails : ObservableObject
    {
        public string status { get; set; }
        public List<Data> data { get; set; }

    }

    public class Data
    {
        [PrimaryKey]
        public string id { get; set; }
        public string employee_name { get; set; }
        public string employee_salary { get; set; }
        public string employee_age { get; set; }
        public string profile_image { get; set; }
    }
}
