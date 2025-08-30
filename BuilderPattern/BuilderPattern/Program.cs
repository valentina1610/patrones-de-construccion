using System;
using BuilderPattern.Builder;
using BuilderPattern;
using BuilderPattern.Product;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new HamburguesaBuilder();

            var cocinero = new Director();

            var clasica = cocinero.Clasica(builder);
            Console.WriteLine("Hamburguesa clasica:");
            Console.WriteLine(clasica);

            var manual = builder
                .ConPan("Brioche")
                .ConCarne("triple")
                .ConQueso(true)
                .ConLechuga(true)
                .ConTomate(true)
                .ConCebolla(true)
                .ConSalsa("Barbacoa")
                .Build();
            Console.WriteLine("Hamburguesa manual:");
            Console.WriteLine(manual);

            /* 

             var sinCarne = builder
                 .ConPan("Normal")
                 .ConSalsa("Mayonesa")
                 .Build();
             Console.WriteLine("Hambuirguesa sin carne:");
                     Console.WriteLine(sinCarne);
             */

            var builderCeliaca = new HamburguesaCeliacaBuilder();
            var celiaca = builderCeliaca
                .ConCarne("Pollo")
                .ConQueso()
                .ConLechuga()
                .ConSalsa("Alioli")
                .Build();

            Console.WriteLine("Hamburguesa celiaca");
            Console.WriteLine(celiaca);

            Console.WriteLine();

            var builderGourmet = new HamburguesaGourmetBuilder();
            var gourmet = builderGourmet
                .ConCarne("Pescado")
                .ConQueso()
                .ConPan("Papa")
                .ConSalsa("Salsa de soja")
                .ConPepinillos()
                .ConTomate()
                .ConBacon()
                .ConLechuga()
                .ConCebolla()
                .Build();
            Console.WriteLine("Hamburguesa gourmet");
            Console.WriteLine(gourmet);

        }
    }
}
