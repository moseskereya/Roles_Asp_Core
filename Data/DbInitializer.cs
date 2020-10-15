using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HospitalContext context)
        {
            context.Database.EnsureCreated();

            if (context.Doctors.Any()) 
            {
                return;
            }
            var doctors = new Doctor[]
            {
                new Doctor
                {
                    FirstName = "Moses",
                    LastName = "Lazaro",
                    Age = 26,
                },
                 new Doctor
                 {
                     FirstName = "Scott",
                     LastName = "Cate",
                     Age = 56
                 },
                  new Doctor
                  {
                      FirstName = "John",
                      LastName = "Doe",
                      Age =  56
                  },
                   new Doctor
                   {
                       FirstName = "Maria",
                       LastName = "John",
                       Age = 23
                   },
                    new Doctor
                    {
                        FirstName = "Swigger",
                        LastName = "Moses",
                        Age = 46
                    },
                     new Doctor
                     {
                         FirstName = "Lee",
                         LastName = "John",
                         Age = 46
                     }

            };
            foreach (Doctor  d in doctors)
            {
                context.Doctors.Add(d);
            }

            context.SaveChanges();


            var departments = new Department[]
            {
                new Department
                {
                    DepartmentName = "Cardiology",
                    Patients = 45
                },
                new Department
                {
                    DepartmentName = "Chaplaincy",
                    Patients = 56,
                },
                new Department
                {
                    DepartmentName = "Gynecology",
                    Patients = 2
                },
                new Department
                {
                    DepartmentName = "Haematology",
                    Patients = 88
                },
                 new Department
                 {
                     DepartmentName = "Nephrology",
                     Patients = 56
                 }
            };

            foreach (Department s in departments)
            {
                context.Departments.Add(s);
            }
            context.SaveChanges();
        }
    }
}
