using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Cliente
{
    public class Navegador
    {
        private IMapa map;
        private IGeoCoder geocoder;

        public Navegador(IMapServicesFactory factory)
        {
            map = factory.CreateMapa();
            geocoder = factory.CreateGeocoder();
        }

        public void Explorar(string ubicacion, string consultaDireccion)
        {
            map.Render(ubicacion);
            Console.WriteLine(geocoder.Buscar(consultaDireccion));
        }

    }
}
