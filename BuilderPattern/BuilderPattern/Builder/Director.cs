using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public class Director
    {
        public Hamburguesa Clasica(IHamburguesaBuilder builder)
        {
            return builder
                .ConPan("Clasico")
                .ConCarne("Simple")
                .ConQueso(true)
                .ConLechuga(true)
                .ConTomate(true)
                .ConSalsa("Ketchup")
                .Build();
        }
        public Hamburguesa DobleCheddar(IHamburguesaBuilder builder)
        {
            return builder
               .ConPan("Brioche")
               .ConCarne("Doble")
               .ConQueso(true)
               .ConCebolla(true)
               .ConSalsa("Cheddar")
               .Build();
        }
        public Hamburguesa Veggie(IHamburguesaBuilder builder)
        {
            return builder
                .ConPan("Integral")
                .ConCarne("Vegana")
                .ConLechuga()
                .ConTomate()
                .ConCebolla()
                .ConPepinillos()
                .ConSalsa("Alioli")
                .Build();
        }
        public Hamburguesa TripleConBacon(IHamburguesaBuilder builder)
        {
            return builder
                .ConPan("Brioche")
                .ConCarne("Triple")
                .ConQueso()
                .ConBacon()
                .ConCebolla()
                .ConSalsa("Cheddar y Barbacoa")
                .Build();
        }
    }
}
