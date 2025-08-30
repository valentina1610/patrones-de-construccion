using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_MapBox
{
    public class MapBoxGeocoder : IGeoCoder
    {
        public string Buscar(string textoDireccion)
        {
            return ($"Coords MapBox: -38.00, -57.55 para {textoDireccion}");
        }
    }
}