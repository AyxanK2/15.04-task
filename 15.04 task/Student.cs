using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _15._04_task
{
    internal class Student : BaseClass
    {
        private static int _id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string StudentId { get; set; }
        public Student(string name,string lastname,string studentid) 
        {
            ID = ++_id;
            Name = name;
            Lastname = lastname;
            StudentId = studentid;
        }
        public override string GetInfo()
        {
            return $"{ID} {Name} {Lastname}";
        }

    }
}
