using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppAssociation_relationship
{
    class Salary
    {
        public double Basic { get;private set; }
        public double Medical { get; set; }
        public double Conveyance { get; set; }
        public int NoOfIncrements { private set; get; }
       public Salary(double basis, double medical, double conveyance):this()
        {
            Basic = basis;
            Medical = medical;
            Conveyance = conveyance;
        }
       public Salary()
       {
           NoOfIncrements = 0;
       }
      public double GetTotal()
       {
           
           return (Basic + GetMedicalAmount() + GetConveyanceAmount());
       }

      private double GetConveyanceAmount()
        {
            return (Basic * Conveyance) / 100;
        }

      private double GetMedicalAmount()
        {
            return (Basic * Medical) / 100;
        }

      public void Increase(double abasic)
      {
          Basic += (Basic*(abasic/100));
          NoOfIncrements++;
      }
    }
}
