using System;
using System.Collections.Generic;
using System.Text;

namespace practiseTask
{
    class Teacher : Person
    {
        private static int _id;
        public int Id { get; set; }
        private int _experience;
        public int Experience
        {
            get => _experience;
            set
            {
                if (value>1 && value<80 )
                {
                    _experience = value;
                }
            }
        }
        public Teacher()
        {
            _id++;
            Id = _id;
        }

    }
}
