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

            Console.WriteLine("My drink is " + cocacola.Brand + ", it has " + cocacola.Flavor + " flavor and it's a " + cocacola.Qty + " bottle.");
            Console.WriteLine("I smoke " + west.Type + " " + west.Brand + " and I usually buy a pack that has " + west.Pack + " cigarettes in it.");
        }
    }
}
