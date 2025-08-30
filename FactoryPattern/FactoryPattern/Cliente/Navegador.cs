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
        private IRuteador ruteador;

        public Navegador(IMapServicesFactory factory)
        {
            map = factory.CreateMapa();
            geocoder = factory.CreateGeocoder();
            ruteador = factory.CreateRuteador();
        }

        public void Explorar(string ubicacion, string consultaDireccion, string desde, string hasta)
        {
            map.Render(ubicacion);
            Console.WriteLine(geocoder.Buscar(consultaDireccion));
            ruteador.CalcularRuta(desde, hasta);
        }

    }
}
