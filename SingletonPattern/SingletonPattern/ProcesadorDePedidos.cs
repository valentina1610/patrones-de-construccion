using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPattern.Singleton;

namespace SingletonPattern
{
    public class ProcesadorDePedidos
    {
        public void Ejecutar()
        {
            var log = Logger.instancia;
            log.Info("Prueba de multiples lugares.");
        }
    }
}
