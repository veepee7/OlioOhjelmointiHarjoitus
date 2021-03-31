using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink cocacola = new Drink();
            cocacola.Brand = "Coca Cola";
            cocacola.Flavor = "Raspberry";
            cocacola.Qty = "500 ml";

            Cigarettes west = new Cigarettes();
            west.Brand = "West";
            west.Type = "Red";
            west.Pack = "20";
        }
    }
}
