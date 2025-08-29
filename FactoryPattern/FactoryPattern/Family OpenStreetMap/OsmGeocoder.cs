using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_OpenStreetMap
{
    public class OsmGeocoder : IGeoCoder
    {
        public string Buscar(string textoDireccion)
        {
            return ($"Coords OSM: -38.00, -57.55 para {textoDireccion}");

        }
    }
}
