using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singleton
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> inst = new Lazy<Logger>(() => new Logger());
        public static Logger instancia => inst.Value;
        private readonly List<string> historial = new List<string>();

        private Logger()
        {

        }
        
        public void Info(string mensaje)
        {
            string msg = $"[INFO]: {mensaje}";
            historial.Add(msg);
            Console.WriteLine(msg);
        }

        public void Dump()
        {
            Console.WriteLine("-- HISTORIAL DE MENSAJES --");
            foreach (var i in historial)
            {
                Console.WriteLine(i);
            }
        }

    }
}
