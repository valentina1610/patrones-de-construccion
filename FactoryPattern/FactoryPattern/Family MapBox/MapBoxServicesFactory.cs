using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Family_Google;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_MapBox
{
    public class MapBoxServicesFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new MapBoxMapa();
        }
        public IGeoCoder CreateGeocoder()
        {
            return new MapBoxGeocoder();
        }
        public IRuteador CreateRuteador()
        {
            return new MapBoxRuteador();
        }
    }
}
