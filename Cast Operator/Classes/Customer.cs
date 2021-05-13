using System;
using System.Collections.Generic;
using System.Text;

namespace Cast_Operator.Classes
{
    public class Customer : AbstractPerson
    {
        public List<BoughtItem> BoughtItems { get; set; }
        public string Bussinesscustomer { get; set; }
        public DateTime Timeofcreation { get; set; }
    }
}
