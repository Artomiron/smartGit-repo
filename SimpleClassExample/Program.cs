using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Claa Type****");
            Console.WriteLine("Just write it's");
            // розместить в памяти и конфигурировать обьект типа Car
            Car firstCar = new Car();
            firstCar.PrintState();
            firstCar.currSpeed = 17;
            firstCar.carName = "zapar";
            // SpeedUP
            for (int i = 0; i <= 3; i++)
            {
                firstCar.SpeedUp(10);
                firstCar.PrintState();
            }

            Car secondCar = new Car(100, "Maliby");
            secondCar.PrintState();
            Car thredCar = new Car("Lover");
            thredCar.PrintState();
            Console.WriteLine("MOTO");
            Moto firstMoto = new Moto();
            firstMoto.PopAWheely();
            Moto secondMoto = new Moto(3);
            secondMoto.PopAWheely();
            Console.WriteLine("Rider name is {0}", secondMoto.name);
            

            Ship firstShip = new Ship("Ship", 160);
            firstShip.printShip();
            Console.ReadLine();
            //firstShip.weight = 150;
            //firstShip.name = "Chippo";
        }
    }
}
