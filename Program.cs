﻿using System;

namespace OlioOhjelmointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink cocacola = new()
            {
                Brand = "Coca Cola",
                Flavor = "Raspberry",
                Qty = "500 ml"
            };

            Cigarettes west = new()
            {
                Brand = "West",
                Type = "Red",
                Pack = "20"
            };

            Console.WriteLine("My drink is " + cocacola.Brand + ", it has " + cocacola.Flavor + " flavor and it's a " + cocacola.Qty + " bottle.");
            Console.WriteLine("I smoke " + west.Type + " " + west.Brand + " and I usually buy a pack that has " + west.Pack + " cigarettes in it.");

            

            CarClass car = new(200)
            {
                
            };

            car.Acc();
            car.Acc();
            car.Acc();
            car.Acc();
            car.Acc();
            car.Acc();
            car.Acc();

            Console.WriteLine("My car's speed now is " + car.Speed + " km/h");

            Sportscar sc = new(350)
            {
                NoRoof = true
            };
        }
    }
}
