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
            Manager HSN = new Manager("HSN", "Male", "General Affair", "Tunjangan Penginapan", 30000000);
            HSN.entryLayoffInfo("15/2/2015", "15/2/2016");
            Tegar.entryLayoffInfo("15/2/2010");
            Haidar.entryLayoffInfo("1/1/2010");
            Sani.entryLayoffInfo("15/2/2010");
            Tegar.entryLayoffInfo("1/2/2010");
            Adi.entryLayoffInfo("5/5/2010");

            //Supervisor(string name, string gender, string department, string location, string allowanceType, int allowanceFee)
            Supervisor Iqbal = new Supervisor("Iqbal", "Male", "Drilling", "RIAU");
            Supervisor Ucu = new Supervisor("Ucu", "Male", "Drilling", "LUWUK");
            Supervisor Dani = new Supervisor("Dani", "Male", "Refinery", "RIAU", "Tunjangan Internet", 300000);
            Supervisor Aca = new Supervisor("Aca", "Male", "Drilling", "JKT");
            Iqbal.entryLayoffInfo("31/1/2014");
            Ucu.entryLayoffInfo("20/3/2014");
            Dani.entryLayoffInfo("2/2/2014");
            Aca.entryLayoffInfo("1/1/2014", "15/2/2016");

            Tegar.addSpv(Iqbal);
            Tegar.addSpv(Ucu);
            Sani.addSpv(Dani);

            //Staff(string name, string gender, string department, string location, string training, string assignmentProject, string allowanceType, int allowanceFee)
            Staff Dwi = new Staff("Dwi", "Female", "Drilling", "RIAU");
            Staff Trio = new Staff("Trio", "Male", "Drilling", "RIAU");
            Staff Agus = new Staff("Agus", "Female", "Drilling", "LUWUK","Tunjangan Penginapan", 1000000);
            Staff Shofi = new Staff("Shofi", "Female", "Refinery", "BALIKPAPAN", "Tunjangan Penginapan", 1000000);
            Staff Seta = new Staff("Seta", "Male", "General Affair", "-", "Tunjangan Transportasi", 2000000);
            Dwi.entryLayoffInfo("1/1/2016");
            Trio.entryLayoffInfo("1/2/2016");
            Agus.entryLayoffInfo("10/1/2016");
            Shofi.entryLayoffInfo("20/1/2016");
            Seta.entryLayoffInfo("31/12/2015");

            Tegar.addStaff(Dwi);
            Tegar.addStaff(Trio);
            Tegar.addStaff(Agus);
            Haidar.addStaff(Dwi);
            Haidar.addStaff(Trio);
            Haidar.addStaff(Agus);
            Sani.addStaff(Shofi);
            Adi.addStaff(Seta);

            Iqbal.addStaff(Dwi);
            Iqbal.addStaff(Trio);
            Ucu.addStaff(Agus);
            Dani.addStaff(Shofi);


        }
    }
}
