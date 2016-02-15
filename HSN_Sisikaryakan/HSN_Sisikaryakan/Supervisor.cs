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

        public Supervisor() : base()
        {
            this.department = "<tbd>";
        }

        protected string allowanceType //staff + spv. + THR & Medical
        { get; set; }

        protected int allowanceFee
        { get; set; }


        #region Constructor
        public Supervisor(string name, string gender, string department) : base()
        {
            this.basicSalary = 10000000;
            this.department = department;
        }

        public Supervisor(string name, string gender, string department, string allowanceType, int allowanceFee) : base()
        {
            this.basicSalary = 7000000;
            this.department = department;
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
        }
        #endregion
    }
}
