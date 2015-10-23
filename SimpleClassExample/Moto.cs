using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Moto
    {
        public int driveIntensivity;
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driveIntensivity; i++)
            {
                Console.WriteLine("Yeeee Haaaaa");
            }
        }

        public Moto()
        {

        }

        public Moto(int intensity)
        {
            driveIntensivity = intensity;
        }
    }
}
