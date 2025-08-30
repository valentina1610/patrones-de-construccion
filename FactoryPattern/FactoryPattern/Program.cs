using System;
using FactoryPattern.Family_Google;
using FactoryPattern.Interfaces;
using FactoryPattern.Cliente;
using FactoryPattern.Family_OpenStreetMap;
using FactoryPattern.Family_MapBox;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Google Maps
            IMapServicesFactory googleFactory = new GoogleServicesFactory();
            var navegadorGoogle = new Navegador(googleFactory);
            navegadorGoogle.Explorar("Mar del Plata", "Av. Colón 1234", "La rioja 3192", "Av. independencia 2323");

            Console.WriteLine();

            //Map Box
            IMapServicesFactory mapBoxFactory = new MapBoxServicesFactory();
            var navegadorMapBox = new Navegador(mapBoxFactory);
            navegadorMapBox.Explorar("Mar del Plata", "Av. Colón 1234", "La rioja 3192", "Av. independencia 2323");

            Console.WriteLine();

            // OpenStreetMap
            IMapServicesFactory osmFactory = new OsmMapServicesFactory(); 
            var navegadorOsm = new Navegador(osmFactory);
            navegadorOsm.Explorar("Mar del Plata", "Av. Colón 1234", "La rioja 3192", "Av. independencia 2323");
        }
    }
}
