using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Name
    {
        static void Main()
        {
            Person aPerson = new Person("Ha-Mim","Hyder");
            Person bPerson = new Person("Shah","Alam","Sumon");

       

            Console.WriteLine(aPerson.GetFullName());
            Console.WriteLine(aPerson.GetReverseFullName());

            Console.WriteLine(bPerson.GetFullName());
            Console.WriteLine(bPerson.GetReverseFullName());
            Console.ReadKey();
        }
    }
}
