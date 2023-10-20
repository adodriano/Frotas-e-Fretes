namespace Frotas_e_Fretes.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fuel
    {
        public string name { get; set; }
        public double price { get; set; }

        public static void AddToList(Fuel fuel)
        {
            List<Fuel> fuelList = new List<Fuel>(Data.FUEL_PRICES);
            foreach(var item in fuelList)
            {
                if (item.name.ToLower().Equals(fuel.name.ToLower()))
                {
                    Data.FUEL_PRICES.Remove(item);
                }

            }

            Data.FUEL_PRICES.Add(fuel);
        }
    }
}
