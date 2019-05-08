using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12UMLDiagramProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person newPerson = new Person("Jeff", "Oak Park");
            Console.WriteLine(newPerson.ToString());

        }
    }
}
