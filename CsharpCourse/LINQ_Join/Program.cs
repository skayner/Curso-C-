using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creo lista de cervezas con sus nombres y pais de origen
            var beers = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Corona", Country = "México"
                },
                new Beer()
                {
                    Name = "Delirium", Country = "Bélgica"
                },
                new Beer()
                {
                    Name = "Erdinger", Country = "Alemanía"
                },
                new Beer()
                {
                    Name = "Minerva", Country = "México"
                },
            };

            // Creo lista de paises con sus nombres y continentes donde se encuentran
            var countries = new List<Country>()
            {
                new Country()
                {
                    Name = "México", Continent = "América"
                },
                new Country()
                {
                    Name = "Bélgica", Continent = "Europa"
                },
                new Country()
                {
                    Name = "Alemanía", Continent = "Europa"
                }
            };


            /* Creo otra lista que seleccione el nombre de la cerveza junto con su pais, y gracias al pais, obtiene
            el nombre del continente comparando con los paises de la lista de paises usando join de LINQ */
            var beersWithContinent = from beer in beers
                                     join country in countries
                                     on beer.Country equals country.Name
                                     select new
                                     {
                                         Name = beer.Name,
                                         Country = beer.Country,
                                         Continent = country.Continent
                                     };

            foreach (var beer in beersWithContinent)
            {
                Console.WriteLine($"{beer.Name} {beer.Country} {beer.Continent}");
            }
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

    }

    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }

    }
}