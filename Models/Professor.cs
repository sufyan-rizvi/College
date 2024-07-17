﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class Professor:Person
    {
        public double Salary {  get; set; }

        public Professor() { }

        public Professor(int id, string address, DateOnly doB, double sal):base(id, address, doB)
        {
            Salary = sal;               
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\n" +
                $"Salary: {Salary}\n";
        }


    } 
}
