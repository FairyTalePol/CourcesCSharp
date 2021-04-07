using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Student
    {
        public string name;
        public string lastName;

        //public int Age {get; set;}

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        
    }
}
