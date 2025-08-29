using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_Google
{
    public class GoogleMaps : IMapa
    {
        public void Render(string ubicacion)
        {
            Console.WriteLine($"Google Maps: Mostrando {ubicacion}");
        }
    }
}
