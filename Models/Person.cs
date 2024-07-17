using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateOnly DoB {  get; set; }

        public Person(){}
        public Person(int id, string address,DateOnly dob)
        {
            Id = id;
            Address = address;
            DoB = dob;
        }

        public virtual string PrintDetails()
        {
            return $"Person Id: {Id}\n" +
                $"Person Address: {Address}\n" +
                $"Person Date of Birth: {DoB}";
        }
    }
}
