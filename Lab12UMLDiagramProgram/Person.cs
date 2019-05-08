using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12UMLDiagramProgram
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public String Address
        {
            set { address = value; }
            get { return name; }
        }

        public Person (string _name, string _address)
        {
            name = _name;
            address = _address;
        }

        public virtual string Persons()
        {
            return "Something";
        }

        public override string ToString()
        {
            return $"This persons name is {name} and there address is {address}"; 
        }


    }
}
