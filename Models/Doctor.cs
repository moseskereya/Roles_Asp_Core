using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Department> Departments  { get; set; }
    }
}
