using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class Student: Person
    {
        public string Branch { get; set; }

        public Student() { }

        public Student(int id, string address, DateOnly doB, string branch):base(id, address, doB)
        {
            Branch = branch;       
        }

        public override string PrintDetails()
        {
            return $"{base.PrintDetails()}\n" +
                $"Branch: {Branch}\n";
        }
    }
}
