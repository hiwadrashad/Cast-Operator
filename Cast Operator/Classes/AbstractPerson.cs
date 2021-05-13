using System;
using System.Collections.Generic;
using System.Text;

namespace Cast_Operator.Classes
{
    public abstract class AbstractPerson
    {
        public virtual string id { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Middlename { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Telephonenumber { get; set; }
        public virtual string Streetname { get; set; }
        public virtual string Postalcode { get; set; }
        public virtual int Streetnumber { get; set; }
    }
}
