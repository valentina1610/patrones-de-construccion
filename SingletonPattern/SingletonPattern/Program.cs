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

            var b = Logger.instancia;
            b.Dump();

            Console.WriteLine($"¿a y b referencian el mismo obj?: {ReferenceEquals(a, b)}");



        }
    }
}
