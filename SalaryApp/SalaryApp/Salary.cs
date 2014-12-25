using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    class Salary
    {
        private string employeeName;
        private double basic;
        private double houseRentPercent;
        private double medicalAllowancePercent;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double Basic
        {
            set { basic = value; }
        }

        public double HouseRentPercent
        {
            set { houseRentPercent = value; }
        }

        public double MedicalAllowancePercent
        {
            set { medicalAllowancePercent = value; }
        }


        public double CalculateSalary()
        {
            return basic + GetHouseRent()  + GetMedicalAllowance();
        }

        public double GetHouseRent()
        {
            return basic*houseRentPercent/100;
        }

        public double GetMedicalAllowance()
        {
            return basic*medicalAllowancePercent/100;
        }
    }
}
