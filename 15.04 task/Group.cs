using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04_task
{
    internal class Group : BaseClass
    {
        private static int _id { get; set; }
        public string Name { get; set; }
        public Student[] students = { };
        public Group() 
        {
            ID = ++_id;
        }
        public override string GetInfo()
        {
            return $"{ID} {Name}";
        }
        public void Add(Student student)
        {
            if(!students.Contains(student))
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else 
            {
                Console.WriteLine("Bu telebe artg movcuddur");
            }      
        }
        public void Update(int id,Student student)
        {
            foreach (Student item in students)
            {
                if(item.ID == id)
                {
                    item.ID = student.ID;
                    item.Name = student.Name;
                    item.Lastname = student.Lastname;
                    item.StudentId = student.StudentId;
                }
                else Console.WriteLine("bele telebe yoxdur");
            }
        }
        public void Remove(int id)
        {
            Student[] newstudents = { };
            foreach (Student item in students)
            {
                if(item.ID != id)
                {
                    Array.Resize(ref newstudents, newstudents.Length + 1);
                    newstudents[newstudents.Length - 1] = item;
                }
                if(students.Length == newstudents.Length)  Console.WriteLine("bu telebe tapilmadi");
                students = newstudents;
               
            }
        }
        public void Search(string search)
        {
            Student[] newstudents = { };
            foreach (Student item in students)
            {
                if(item.Name.Contains(search) || item.Lastname.Contains(search) || item.StudentId.Contains(search))
                {
                    Array.Resize(ref newstudents,newstudents.Length +1);
                    newstudents[newstudents.Length - 1] = item;
                }
            }
                foreach (Student s in newstudents)
                {
                    Console.WriteLine(s.GetInfo());
                }
        }
        public void GetStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetInfo());
            }
        }
    }
}
