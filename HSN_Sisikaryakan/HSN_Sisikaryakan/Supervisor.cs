using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_SisikaryakanHR
{
    public class Supervisor : Employee
    {
        protected string department
        { get; set; }

        protected string location
        { get; set; }
        
        protected string allowanceType //staff + spv. + THR & Medical
        { get; set; }

        protected int allowanceFee
        { get; set; }

        private int _staffNumber = 0;
        protected int staffNumber
        {
            get
            {
                return _staffNumber;
            }
            set
            {
                _staffNumber = value;
            }
        }
        protected Staff[] arrStaf = new Staff[5];

        #region Method
        public void addStaff(Staff stf)
        {
            arrStaf[_staffNumber] = stf;
            _staffNumber++;
        }

        public override void entryLayoffInfo(string _entryDate)
        {
            this.entryDate = _entryDate;
            //_employeeNumber++;
        }

        public override void entryLayoffInfo(string _entryDate, string _layoffDate)
        {
            this.entryDate = _entryDate;
            this.layoffDate = _entryDate;
            this.employeeStatus = "INACTIVE";
        }
        #endregion


        #region Constructor
        public Supervisor() : base()
        {
            this.department = "<tbd>";
        }

        public Supervisor(string name, string gender, string department, string location) : base()
        {
            this.basicSalary = 7000000;
            this.department = department;
            this.location = location;
        }

        public Supervisor(string name, string gender, string department, string location, string allowanceType, int allowanceFee) : base()
        {
            this.basicSalary = 7000000;
            this.department = department;
            this.location = location;
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
        }
        #endregion
    }
}
