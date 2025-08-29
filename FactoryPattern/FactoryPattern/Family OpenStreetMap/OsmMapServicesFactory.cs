using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;
using FactoryPattern.Family_OpenStreetMap;

namespace FactoryPattern.Family_OpenStreetMap
{
    public class OsmMapServicesFactory : IMapServicesFactory
    {
        public IMapa CreateMapa()
        {
            return new OsmMapa();
        }
        public IGeoCoder CreateGeocoder()
        {
            return new OsmGeocoder();
        }
    }
}
