﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12UMLDiagramProgram
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            set
            {
                school = value;
            }
            get
            {
                return school;
            }

        }

        public double Pay
        {
            set
            {
                pay = value;
            }
            get
            {
                return pay;
            }

        }
        public Staff(string _school, double _pay, string _name, string _address) : base(_name, _address)
        {
            _school = school;
            _pay = pay;
        }

        public virtual string Persons()
        {
            return "Something";
        }

        public override string ToString()
        {
            return base.ToString() + school + pay;
        }
    }
}
