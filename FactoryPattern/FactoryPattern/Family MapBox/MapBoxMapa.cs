using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_MapBox
{
    public class MapBoxMapa : IMapa
    {
        public void Render(string ubicacion)
        {
            Console.WriteLine($"Map Box Mostrando: {ubicacion}");
        }

    }
}
