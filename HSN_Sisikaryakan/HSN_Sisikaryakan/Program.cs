using HSN_SisikaryakanHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSN_Sisikaryakan
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Manager(string name, string gender, string department)y
            //Manager(string name, string gender, string department, string allowanceType, int allowanceFee, string comparativeStudyName, int comparativeStudyFee) : base()
            Manager Tegar = new Manager("Tegar", "Male", "Drilling");
            Manager Haidar = new Manager("Haidar", "Male", "Drilling", "Tunjangan Kesehatan", 3000000, "Study banding", 10000000);
            Manager Sani = new Manager("Tegar", "Male", "Refinery");
            Manager Adi = new Manager("Haidar", "Male", "General Affair", "Tunjangan Internet", 300000);

            //Supervisor(string name, string gender, string department, string location, string allowanceType, int allowanceFee)
            Supervisor Iqbal = new Supervisor("Iqbal", "Male", "Drilling", "RIAU");
            Supervisor Ucu = new Supervisor("Ucu", "Male", "Drilling", "LUWUK");
            Supervisor Dani = new Supervisor("Dani", "Male", "Refinery", "RIAU", "Tunjangan Internet", 300000);

            //Staff(string name, string gender, string department, string location, string training, string assignmentProject, string allowanceType, int allowanceFee)
            Staff Dwi = new Staff("Dwi", "Female", "Drilling", "RIAU");
            Staff Trio = new Staff("Trio", "Male", "Drilling", "RIAU");
            Staff Agus = new Staff("Agus", "Female", "Drilling", "LUWUK","Tunjangan Penginapan", 1000000);
            Staff Shofi = new Staff("Shofi", "Female", "Refinery", "BALIKPAPAN", "Tunjangan Penginapan", 1000000);
            Staff Seta = new Staff("Seta", "Male", "General Affair", "-", "Tunjangan Transportasi", 2000000);

        }
    }
}
