using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Car
    {
        private bool _started;
        public Car()
        {
            _started = false;
        }

        public Car(bool started)
        {
            _started = started;
        }
        public void Drive()
        {
            if (!_started)
                Resrart();
            Console.WriteLine("BRRRRRRRRRRRRRRR");
        }

        private void Resrart()
        {
           
            Console.WriteLine("WRRRRRUM");
            _started = true;
        }
    }
}
