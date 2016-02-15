using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_SisikaryakanHR
{
    abstract class allowance
    {
        protected string[] namaEmployee;
        protected string allowanceType
        { get; set; }

        private int _allowanceNumber = 0;
        protected int allowanceNumber
        {
            get
            {
                return _allowanceNumber;
            }
            set
            {
                allowanceNumber = value;
            }
        }

        protected int allowanceFee
        { get; set; }

        public abstract void countTotalAllowanceNumber();

        #region Method
        #endregion

        #region Constructor
        //method
        public allowance()
        {
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
        }

        public allowance(string allowanceType, int allowanceFee)
        {
            this.allowanceType = allowanceType;
            this.allowanceFee = allowanceFee;
        }
        #endregion


    }
}
