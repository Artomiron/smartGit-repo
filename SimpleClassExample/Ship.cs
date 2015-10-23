using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Ship
    {
        public string name;
        public int weight;

        public Ship()
        {
 
        }

        public Ship(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void printShip()
        {
            Console.WriteLine("Ship name is: {0}", name);
            Console.WriteLine("Ship weight is: {0}", weight);
        }
    }
}
