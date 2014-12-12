using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppAssociation_relationship
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
         public Salary aSalary { get; set; }
        public Employee(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public Employee()
        {
            aSalary = new Salary();
        }
    }
}
