using System;
using FactoryPattern.Family_Google;
using FactoryPattern.Interfaces;
using FactoryPattern.Cliente;
using FactoryPattern.Family_OpenStreetMap;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Google Maps
            IMapServicesFactory googleFactory = new GoogleServicesFactory();
            var navegadorGoogle = new Navegador(googleFactory);
            navegadorGoogle.Explorar("Mar del Plata", "Av. Colón 1234");

            Console.WriteLine(); 

            // OpenStreetMap
            IMapServicesFactory osmFactory = new OsmMapServicesFactory(); 
            var navegadorOsm = new Navegador(osmFactory);
            navegadorOsm.Explorar("Mar del Plata", "Av. Colón 1234");
        }
    }
}
