using System;

namespace VehicleApp
{
   
    interface IVehicle
    {
        void Drive();               
        bool Refuel(int amount);    
    }

    class Car : IVehicle
    {
        private int gasoline; 

     
        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

       
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Yoqilg‘i yo‘q, hayday olmaysiz.");
            }
        }

      
        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
         
            Car myCar = new Car(0);

            
            Console.Write("Necha litr benzin quymoqchisiz? ");
            int amount = int.Parse(Console.ReadLine());

            
            myCar.Refuel(amount);

            
            myCar.Drive();

            Console.ReadLine(); 
        }
    }
}
