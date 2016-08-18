using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram
{
    /* The console application that creates instances of Car class and runs class methods*/
    class someProgram
    {
        static void Main(String[] args)
        {
            //Creatin a myCar instance which takes year as a parameter and calculates mileage method
            Car myCar = new Car(2001);
            Console.WriteLine(myCar.VehicleInfo());            
            Console.WriteLine(myCar.mileage(2.1, 15));

            Car beetle = new Car(2010);
            Console.WriteLine(beetle.VehicleInfo());
            Console.WriteLine(beetle.mileage(5.3, 20.1));
            Console.ReadKey();

        }
    }

    /*An abstract class called a Vehicle that does not take any parameter and has two virutal methods */
    abstract class Vehicle
    {
        //A virtual method that returns a string 
        public virtual string VehicleInfo()
        {
            return "This is some type of vehicle.";
        }

        /*A vitual method takes two paramaters: a double value that represents fuel consumed and 
         * another double that represents distance travelled
         * the method returns a double a division of passed parameters*/
        public virtual double mileage(double fuelConsumed, double distanceTravelled)
        {
            return fuelConsumed/distanceTravelled;
        }        
    }

    /* A Car class that inherits for Vehicle class, this class has a private int variable 
     * and two methods that it inherits and overrides from the base class*/
    class Car : Vehicle
    {
        //Private variable
        private int year;

        //Constructor 
        public Car(int year)
        {
            this.year = year;
        }

        //Method inherited from base class and uses private variable
        public override string VehicleInfo()
        {
            return base.VehicleInfo() + "A car model of year "+ this.year;
            
        }

        /*Method inherited from base class has two parameters as the base class
         * returns overridden double value, uses the private variable of the class*/
        public override double mileage(double fuel, double distance)
        {
            if (this.year <= 2010)
            {
                fuel = 10 + fuel;
                return Math.Round((fuel / distance),2);
            }
            return Math.Round(base.mileage(fuel, distance),2);
        }
        
    }
}