using System;
using System.Collections.Generic;
using System.Text;

namespace Cast_Operator.Classes
{
    public class Person : AbstractPerson
    {

        public static explicit operator Person(Employee item)
        {
            return new Person()
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
        public static explicit operator Person(Customer item)
        {
            return new Person()
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
