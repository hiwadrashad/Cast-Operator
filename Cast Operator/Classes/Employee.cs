using System;
using System.Collections.Generic;
using System.Text;

namespace Cast_Operator.Classes
{
    public enum Positions
    { 
       menial,
       Supervisor,
       Coordinator,
       HR,
       CEO
    }
    public class Employee : AbstractPerson
    {
        public string Workplace { get; set; }
        public Positions position { get; set; }
        public string Bossfirstname { get; set; }
        public string Bossmiddlename { get; set; }
        public string Bosslastname { get; set; }
        public double Salary { get; set; }

        public static explicit operator Employee(Customer item)
        {
            return new Employee()
            {
                Firstname = item.Firstname,
                Middlename = item.Middlename,
                Lastname = item.Lastname,
                Telephonenumber = item.Telephonenumber,
                Streetname = item.Streetname,
                Postalcode = item.Postalcode,
                Streetnumber = item.Streetnumber
            };
        }
        public static explicit operator Employee(Person item)
        {
            return new Employee()
            {
                Firstname = item.Firstname,
                Middlename = item.Middlename,
                Lastname = item.Lastname,
                Telephonenumber = item.Telephonenumber,
                Streetname = item.Streetname,
                Postalcode = item.Postalcode,
                Streetnumber = item.Streetnumber
            };
        }


    }
}
