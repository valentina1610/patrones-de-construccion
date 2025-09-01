using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SingletonPattern.Singleton
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }
    public sealed class Logger
    {
        private static readonly Lazy<Logger> inst = new Lazy<Logger>(() => new Logger());
        public static Logger instancia => inst.Value;
        private readonly List<string> historial = new List<string>();
        private bool usarArchivo = false;
        private string rutaArchivo;
        private string context;

        public void UsarConsola()
        {
            usarArchivo = false;
        }
        public void UsarArchivo(string ruta)
        {
            usarArchivo = true;
            rutaArchivo = ruta;
        }
        public void SetContext(string nombre)
        {
            context = nombre;
        }

        private Logger()
        {

        }
        private void Escribir(string mensaje)
        {
            if (usarArchivo)
            {
                //escribir en archivo (append)
                File.AppendAllText(rutaArchivo, mensaje + Environment.NewLine);
            }
            else
            {
                //consola
                usarArchivo = false;
                Console.WriteLine(mensaje);
            }
        }
        public void Log(LogLevel nivel, string mensaje)
        {
            string prefijo = nivel switch 
            {
                LogLevel.Info => "[INFO]",
                LogLevel.Warning => "[WARNING]",
                LogLevel.Error => "[ERROR]",
                _ => "[LOG]"
            };
            string fecha = DateTime.Now.ToString("HH:mm:ss");
            string ctx = string.IsNullOrEmpty(context) ? "" : $"[{context}]";

            string final = $"{prefijo}[{fecha}]{ctx} {mensaje}";
            historial.Add(final);
            Escribir(final);
        }

        public void Info(string mensaje) => Log(LogLevel.Info, mensaje);
        public void Warning(string mensaje) => Log(LogLevel.Warning, mensaje);
        public void Error(string mensaje) => Log(LogLevel.Error, mensaje);


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
