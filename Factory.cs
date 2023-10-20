namespace Frotas_e_Fretes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Model;

    class Factory
    {
        private List<Vehicle> vehicles;

        public Factory()
        {
            vehicles = new List<Vehicle>();
        }

        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void listVehicles()
        {
            Console.WriteLine("Lista de Veículos:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ModelName);
                Console.WriteLine("-------------------------");
            }
        }

        public static Vehicle createNewVehicle(string _type)
        {
            switch (_type.ToLower())
            {
                case "carro":
                    return new Car();
                case "moto":
                    return new Motorcycle();
                case "caminhão":
                    return new Truck();
                case "avião":
                    return new AirPlane();
                default:
                    return new Car();
            }
        }
    }
}
