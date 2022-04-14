using System;

namespace practiseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp;
            int age;
            //do
            //{

            //    Console.WriteLine("Age yeniden daxil edin");
            //    age = Convert.ToInt32(Console.ReadLine());

            //} while (age < 0);
            //do
            //{
            //    exp = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Experience yeniden daxil edin");
            //    Console.Clear();

            //} while (exp < 1 || exp > 80);
            Teacher tc = new Teacher();
            Student st = new Student();
            Student st1 = new Student();
            Group gr = new Group();
            //tc.Age = age;
            //st.Age = age;

            //Console.WriteLine(tc.Age);
            //Console.WriteLine(st.Age);
            //tc.Experience = exp;
            st.Name = "Fatima";
            st1.Name = "Aynura";
            //Console.WriteLine(tc.Experience);
            gr.AddStudent(st);
            gr.AddStudent(st1);
            foreach (var item in gr.students)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
