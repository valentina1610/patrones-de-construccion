using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Family_Google
{
    public class GoogleRuteador : IRuteador
    {
        public void CalcularRuta(string desde, string hasta)
        {
            Console.WriteLine($"Google Mostrando: ruta desde {desde} hasta {hasta}");
        }
    }
}
