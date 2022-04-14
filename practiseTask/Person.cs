using System;
using System.Collections.Generic;
using System.Text;

namespace practiseTask
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age; 
        public int Age { 
            get => _age;
            set
            {
                if (value>0 && value<=100)
                {
                    _age = value;
                }
            }

        }
        

    }
}
