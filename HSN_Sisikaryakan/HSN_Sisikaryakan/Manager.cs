using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_SisikaryakanHR
{
    public class Manager:Employee
    {
        protected string department
        { get; set; }        

        private int _supervisorNumber = 0;
        protected int ssupervisorNumber
        {
            get
            {
                return _supervisorNumber;
            }
            set
            {
                _supervisorNumber = value;
            }
        }
        protected Supervisor[] arrSupervisor = new Supervisor[3];

        protected string allowanceType //staff + spv. + THR & Medical
        { get; set; }        

        protected int allowanceFee
        { get; set; }

        protected string comparativeStudyName //staff + spv. + THR & Medical
        { get; set; }

        protected int comparativeStudyFee
        { get; set; }

        #region Method
        public void addSpv(Supervisor spv)
        {
            arrSupervisor[_supervisorNumber] = spv;
            _supervisorNumber++;
        }
        #endregion

        #region Constructor
        public Manager() : base()
        {
            this.department = "<tbd>";
        }
        public Manager(string name, string gender, string department) : base()
        {
            this.basicSalary = 10000000;
            this.department = department;
        }

        public Manager(string name, string gender, string department, string allowanceType, int allowanceFee, string comparativeStudyName, int comparativeStudyFee) : base()
        {
            this.basicSalary = 10000000;
            this.department = department;
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
            this.comparativeStudyName = comparativeStudyName;
            this.comparativeStudyFee = comparativeStudyFee;
        }
        #endregion
    }
}
