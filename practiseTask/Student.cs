using System;
using System.Collections.Generic;
using System.Text;

namespace practiseTask
{
    class Student : Person
    {
        private static int _id;
        public int Id { get; set; }
        public string[] Lessons = new string[0];
        public Student()
        {
            _id++;
            Id = _id;

        }
    }
}
