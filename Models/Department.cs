using System.Collections.Generic;

namespace Hospital.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int Patients { get; set; }
        public Doctor Doctors { get; set; }
    }
}