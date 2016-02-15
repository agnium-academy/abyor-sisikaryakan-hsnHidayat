using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_SisikaryakanHR
{
    public class Staff : Employee
    {
        protected string department
        { get; set; }

        protected string location
        { get; set; }

        protected string training
        { get; set; }

        protected string assignmentProject
        { get; set; }

        protected string allowanceType //staff + spv. + THR & Medical
        { get; set; }

        protected int allowanceFee
        { get; set; }


        #region Constructor
        public Staff() : base()
        {
            this.department = "<tbd>";
        }

        public Staff(string name, string gender, string department, string location) : base()
        {
            this.basicSalary = 4000000;
            this.department = department;
            this.location = location;
        }

        public Staff(string name, string gender, string department, string location, string training, string assignmentProject, string allowanceType, int allowanceFee) : base()
        {
            this.basicSalary = 4000000;
            this.department = department;
            this.location = location;
            this.training = training;
            this.assignmentProject = assignmentProject;
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
        }
        #endregion
    }
}
