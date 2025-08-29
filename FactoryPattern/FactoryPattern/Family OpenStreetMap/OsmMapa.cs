using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_OpenStreetMap
{
    public class OsmMapa : IMapa
    {
        public void Render(string ubicacion)
        {
            Console.WriteLine($"OSM mostrando: {ubicacion}");
        }
    }
}
