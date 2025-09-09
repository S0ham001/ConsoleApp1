using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicles
    {
        public string type;
        public string engine_type;
        public string headlight_type;
        public int speed;

    }
    public class Car : Vehicles
    {
        public string name;
        public string date;
        public int wheels;

        public void set_car_details(string type, string engine_type, string headlight_type, int speed, string name,string date,int wheels)
        {
            this.type = type;
            this.engine_type = engine_type;
            this.headlight_type = headlight_type;
            this.speed = speed;

            this.name = name;
            this.date = date;
            this.wheels = wheels;
        }
        public void get_car_detailes()
        {
            Console.WriteLine("car name is " + name);
            Console.WriteLine("car date is " + date);
            Console.WriteLine("car type is " + type);
            Console.WriteLine("car engine type is " + engine_type);
            Console.WriteLine("car headlights type is " + headlight_type);
            Console.WriteLine("car top speed is " + speed + "KMph");
            Console.WriteLine("car numbers of wheels is " + wheels);
            Console.WriteLine();
        }
    }
    internal class vehicle
    {
        static void Main()
        {
            Car c1 = new Car();
            c1.set_car_details("car","v6","LED",240,"m4","20/8/2023",4);

            Car c2 = new Car();
            c2.set_car_details("car", "inline 6", "LED", 223, "supra", "20/3/2024", 4);

            c1.get_car_detailes();
            c2.get_car_detailes();
        }
    }
}
