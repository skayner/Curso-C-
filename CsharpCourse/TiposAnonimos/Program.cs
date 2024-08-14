﻿using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var hector = new
            {
                Name= "Hector",
                Country= "Mexico"

            };

            Console.WriteLine($"{hector.Name} {hector.Country}");

            var beers = new[]
            {
                new { Name = "Red", Brand = "Delirium" },
                new { Name = "London Porter", Brand = "Fullers" }
            };

            foreach ( var b in beers )
            {
                Console.WriteLine($"Cerveza {b.Name} {b.Brand} ");
            }
        }
    }
}