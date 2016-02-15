using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_SisikaryakanHR
{
    public class Employee
    {
        private int _employeeNumber = 0;
        protected int employeeNumber
        {
            get
            {
                return _employeeNumber;
            }
            set
            {
                _employeeNumber = value;
            }
        } 
        protected string entryDate
        { get; set; }

        protected string layoffDate
        { get; set; }

        protected string employeeStatus
        { get; set; }

        protected string name
        { get; set; }

        protected string gender
        { get; set; }

        protected int basicSalary
        { get; set; }

        protected int totalSalary
        { get; set; }

        protected void entryLayoffInfo()
        {
            this.entryDate = "February, 15 2016";
            this.layoffDate = "-";
            this.employeeStatus = "ACTIVE";
            _employeeNumber++;
        }

        protected void entryLayoffInfo(string _entryDate)
        {
            this.entryDate = _entryDate;
            _employeeNumber++;
        }

        protected void entryLayoffInfo(string _entryDate, string _layoffDate)
        {
            this.entryDate = _entryDate;
            this.layoffDate = _entryDate;
            this.employeeStatus = "INACTIVE";
        }

        public Employee()
        {
            this.name = "anonymous";
            this.gender = "?";
            this.basicSalary = 0;
            this.employeeStatus = "?";
        }

        public Employee(string name, string gender)
        {
            this.name = name;
            this.gender = gender;
            this.basicSalary = 0;
            this.employeeStatus = "?";
        }

    }
}
