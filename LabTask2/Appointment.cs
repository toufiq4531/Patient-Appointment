using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Appointment
    {
        private readonly string NRIC;
        private string name;
        private double fees;
        private Date visit;
        private Date nextVisit;

        public Appointment(string NRIC = null, string name = null,
                            double fees = 0, Date visit = null, Date nextVisit = null) 
        {
            this.NRIC = NRIC;
            this.name = name;
            this.fees = fees;
            this.visit = visit;
            this.nextVisit = nextVisit;

        }

        public void setAppt(string nam, double fee, Date v, Date nV) 
        {
            this.name = nam;
            this.fees = fee;
            this.visit = v;
            this.nextVisit = nV;
        }

        public string getVisit 
        {
            get 
            {
                return "{visit.getDD} {visit.getMM} {visit.getYY}";
            }
        }

        public string getNextVisit
        {
            get
            {
                if(nextVisit.getYY == 0) return "-";
                return "{nextVisit.getDD} {nextVisit.getMM} {nextVisit.getYY}";
            }
        }

        public string getName
        {
            get { return name; }
        }

        public void displayAppt(string nric)
        {
            if (NRIC == nric)
            {
                Console.WriteLine("Patient ID: " + NRIC + ", " + name + ", $" + fees);
                Console.WriteLine("Date of Visit: " + visit.getDD + "/" + visit.getMM + "/" + +visit.getYY);
                Console.WriteLine("Date of Next Visit: " + nextVisit.getDD + "/" + nextVisit.getMM + "/" + nextVisit.getYY);
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Not Found");
            }
        }

        public void displayAppt()
        {
            Console.WriteLine("Patient ID: " + NRIC + ", " + name + ", $" + fees);
            Console.WriteLine("Date of Visit: " + visit.getDD + "/" + visit.getMM + "/" + +visit.getYY);
            Console.WriteLine("Date of Next Visit: " + nextVisit.getDD + "/" + nextVisit.getMM + "/" + nextVisit.getYY);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Date date1 = new Date(2, 3, 2015);
            Date date2 = new Date(3, 3, 2015);
            Date date3 = new Date(10, 3, 2015);
            Date date4 = new Date(31, 3, 2015);
            Date date5 = new Date(8, 6, 2015);
            Date date6 = new Date(31, 3, 2015);
            Date date7 = new Date(30, 4, 2015);

            Appointment appt1 = new Appointment("S12345", "Tan Ah Sam", 45.00, date1, date5);
            Appointment appt2 = new Appointment("S34567", "Lee Tao San", 60.00, date2, new Date());
            Appointment appt3 = new Appointment("S56783", "Sam Ting", 120.50, date3, date6);
            Appointment appt4 = new Appointment("S98761", "Anthony Chin", 78.50, date4, date7);

            //Showing All Appointments
            appt1.displayAppt();
            appt2.displayAppt();
            appt3.displayAppt();
            appt4.displayAppt();

            Console.WriteLine("\nPrint Single Appointment: S56783\n");
            appt3.displayAppt("S12345");

            Console.WriteLine("\nPress any key to continue . . . ");

            Console.ReadKey();
        }
    }
}
