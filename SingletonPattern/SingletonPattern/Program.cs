using System;
using SingletonPattern.Singleton;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Logger.instancia;
            a.Info("Primer mensaje");
            a.Info("Segundo mensaje");
            a.Info("Tercer mensaje");

            a.UsarArchivo("log.txt");
            a.Warning("Esto se guarda en el archivo log.txt");
            a.Error("otro mensaje en archivo");
            a.UsarConsola();
            a.Info("de nuevo consola");

            a.SetContext("contexto1");
            a.Log(LogLevel.Info, "Iniciando el sistema");
            a.SetContext("contexto2");
            a.Log(LogLevel.Error, "Se rompio todo!");
            var b = Logger.instancia;
            b.Dump();

            ProcesadorDePedidos pruebaLugares = new ProcesadorDePedidos();
            pruebaLugares.Ejecutar();

            Console.WriteLine($"¿a y b referencian el mismo obj?: {ReferenceEquals(a, b)}");
        }
    }
}