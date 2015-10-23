using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public int currSpeed;
        public String carName;
        //функциональность класа
        public Car() // стандартный констуктор
        {
            carName = "Limbo";
            currSpeed = 60;
        }

         
        // тут карСпид получает стандортное значения для типа инт (0)
        public Car(string cn)
        {
            carName = cn;
        }
        // позволяет вызывающему коду установить полное состояние Кар
        public Car(int cs, string cn)
        {
            currSpeed = cs;
            carName = cn;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", carName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
