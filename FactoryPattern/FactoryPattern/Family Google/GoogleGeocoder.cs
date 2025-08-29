using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_Google
{
    public class GoogleGeocoder : IGeoCoder
    {
        public string Buscar(string textoDireccion)
        {
            return ($"Coords GoogleMaps: -38.00, -57.55 para {textoDireccion}");
        }
    }
}
