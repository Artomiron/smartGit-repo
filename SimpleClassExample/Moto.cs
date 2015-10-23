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

        public Moto() {}
        
        public Moto(int intensivity)
            :this(intensivity, "") {}
       
        //main constructor
        public Moto(int intensivity, string name)
        {
            if(intensivity > 10)
            {
                intensivity = 10;
            }
            this.driveIntensivity = intensivity;
            this.name = name;
        }

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



    }
}
