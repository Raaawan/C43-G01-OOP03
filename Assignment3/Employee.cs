using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Employee : IComparable<Employee>
    {
        #region properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        private string? role;

        public string? Role {
            get {
                return role;
            }
            set
            {
                role = value;
            }

        }

        //public HiringDate HireDate { get; set; }
        private char gender;
        public char Gender
        {
            get {
                return gender;

            }
            set
            {
                if (value != 'M' && value != 'F')
                {
                    Console.WriteLine("Gender Values are Male or Female only ");
                }
                else
                {
                    gender = value;
                }
            }
        }
        //public Gender Gender { get; set; }
        
        #endregion

        #region constructor
        public Employee(int id, string? name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        

        #endregion

        #region Methods
        public override string ToString()
        {
            CultureInfo usCulture = new CultureInfo("en-US");
         
                return $"Employee ID: {Id} \nEmployee Name: {Name} \nEmployee Security Level: {SecurityLevel} \nEmployee Salary: {Salary.ToString("C", usCulture)}\nEmployee Hire Date: {HireDate}\nEmployee Gender:{Gender}";
        }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return new DateTime(HireDate.Year, HireDate.Month, HireDate.Day)
                .CompareTo(new DateTime(other.HireDate.Year, other.HireDate.Month, other.HireDate.Day));
        }
        #endregion
    }
}
