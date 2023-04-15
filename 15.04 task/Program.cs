namespace _15._04_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ayxan","Karimli","123");
            Student student2 = new Student("Malik", "Aliyev", "12321");
            Student student3 = new Student("Ramin", "Babirli", "231");
            Group qrup = new Group();
            qrup.Add(student1);
            qrup.Add(student2);
            qrup.Add(student3);
            //qrup.Update(1, student2);\
            qrup.Search("Asfa");
            //qrup.Remove(2);
            qrup.GetStudents();

            //Dictionary<int,string> methodd = new Dictionary<int,string>();
            //methodd.Add(1,student1.Name);
            //methodd.Add(2,student2.Name);
            //methodd.Add(3,student3.Name);
            //foreach (KeyValuePair<int,string> item in methodd)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            
        }
    }
}