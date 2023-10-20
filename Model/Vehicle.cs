namespace Frotas_e_Fretes.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Vehicle
    {
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double WeightSupported { get; set; }
        public double Autonomy { get; set; }
        public string FuelType { get; set; }
        public double FuelPrice { get; set; }

        public abstract string Type();

        public virtual void showInfo()
        {
            Console.WriteLine($"Marca: {Brand}, Modelo: {ModelName}, Rodas: {Wheels}");
        }

        public Vehicle()
        {
        }

        public double CalculateDeliveryCost(double distance, double cargoWeight)
        {
            double requiredFuel = distance / Autonomy;
            double cost = requiredFuel * FuelPrice;
            return cost;
        }
    }
}
