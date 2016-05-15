using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigationDemo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime JoiningDate { get; set; }

    }
}