using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;
using FactoryPattern.Family_Google;

namespace FactoryPattern.Family_Google
{
    public class GoogleServicesFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new GoogleMaps();
        }
        public IGeoCoder CreateGeocoder()
        {
            return new GoogleGeocoder();
        }
    }
}
