using Cast_Operator.Classes;
using System;

namespace Cast_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"_________                  __  .__                                          .__                    .___.__                ");
            Console.WriteLine(@"\_   ___ \_____    _______/  |_|__| ____    ____     _______  __ ___________|  |   _________     __| _/|__| ____    ____  ");
            Console.WriteLine(@"/    \  \/\__  \  /  ___/\   __\  |/    \  / ___\   /  _ \  \/ // __ \_  __ \  |  /  _ \__  \   / __ | |  |/    \  / ___\ ");
            Console.WriteLine(@"\     \____/ __ \_\___ \  |  | |  |   |  \/ /_/  > (  <_> )   /\  ___/|  | \/  |_(  <_> ) __ \_/ /_/ | |  |   |  \/ /_/  >");
            Console.WriteLine(@" \______  (____  /____  > |__| |__|___|  /\___  /   \____/ \_/  \___  >__|  |____/\____(____  /\____ | |__|___|  /\___  / ");
            Console.WriteLine(@"        \/     \/     \/               \//_____/                    \/                      \/      \/         \//_____/  ");
            Console.WriteLine("\n");
            Console.WriteLine("====================== Cast from employee to person ======================");
            Console.WriteLine("\n");
            Console.WriteLine("intializing objects");
            var person1 = new Person() { };
            var employee1 = new Employee() 
            { 
                Firstname = "firstname placeholder",
                Middlename = "middlename placeholder",
                Lastname = "lastname placeholder",
                Telephonenumber = "telephonenumber placeholder",
                Streetname = "streetname placeholder",
                Postalcode = "postal code placeholder ",
                Streetnumber = 999
            };
            Console.WriteLine("\n");
            Console.WriteLine("Casting from employee to person");
            person1 = (Person)employee1;
            Console.WriteLine("\n");
            Console.WriteLine("transfered data from casting are:");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Firstname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Middlename}");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Lastname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Telephonenumber}");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Streetname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{person1.Streetnumber}");
            Console.WriteLine("\n");

            Console.WriteLine("====================== Cast from customer to person ======================");
            Console.WriteLine("\n");
            Console.WriteLine("intializing objects");
            var person2 = new Person() { };
            var customer1 = new Customer()
            {
                Firstname = "firstname placeholder",
                Middlename = "middlename placeholder",
                Lastname = "lastname placeholder",
                Telephonenumber = "telephonenumber placeholder",
                Streetname = "streetname placeholder",
                Postalcode = "postal code placeholder ",
                Streetnumber = 999
            };
            Console.WriteLine("\n");
            Console.WriteLine("Casting from customer to person");
            person2 = (Person)customer1;
            Console.WriteLine("\n");
            Console.WriteLine("transfered data from casting are:");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Firstname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Middlename}");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Lastname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Telephonenumber}");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Streetname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{customer1.Streetnumber}");
            Console.WriteLine("\n");

            Console.WriteLine("====================== Cast from customer to employee ======================");
            Console.WriteLine("\n");
            Console.WriteLine("intializing objects");
            var employee2 = new Employee() { };
            var customer2= new Customer()
            {
                Firstname = "firstname placeholder",
                Middlename = "middlename placeholder",
                Lastname = "lastname placeholder",
                Telephonenumber = "telephonenumber placeholder",
                Streetname = "streetname placeholder",
                Postalcode = "postal code placeholder ",
                Streetnumber = 999
            };
            Console.WriteLine("\n");
            Console.WriteLine("Casting from customer to employee");
            employee2 = (Employee)customer2;
            Console.WriteLine("\n");
            Console.WriteLine("transfered data from casting are:");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Firstname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Middlename}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Lastname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Telephonenumber}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Streetname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee2.Streetnumber}");
            Console.WriteLine("\n");

            Console.WriteLine("====================== Cast from person to employee ======================");
            Console.WriteLine("\n");
            Console.WriteLine("intializing objects");
            var employee3 = new Employee() { };
            var person3 = new Person()
            {
                Firstname = "firstname placeholder",
                Middlename = "middlename placeholder",
                Lastname = "lastname placeholder",
                Telephonenumber = "telephonenumber placeholder",
                Streetname = "streetname placeholder",
                Postalcode = "postal code placeholder ",
                Streetnumber = 999
            };
            Console.WriteLine("\n");
            Console.WriteLine("Casting from customer to employee");
            employee3 = (Employee)person3;
            Console.WriteLine("\n");
            Console.WriteLine("transfered data from casting are:");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Firstname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Middlename}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Lastname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Telephonenumber}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Streetname}");
            Console.WriteLine("\n");
            Console.WriteLine($"{employee3.Streetnumber}");
            Console.WriteLine("\n");

            Console.WriteLine("====================== End of project ======================");

        }
    }
}
