using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IHamburguesaBuilder
    {
        IHamburguesaBuilder ConPan(string pan);
        IHamburguesaBuilder ConCarne(string carne);
        IHamburguesaBuilder ConQueso(bool agregar = true);
        IHamburguesaBuilder ConLechuga(bool agregar = true);
        IHamburguesaBuilder ConTomate(bool agregar = true);
        IHamburguesaBuilder ConCebolla(bool agregar = true);
        IHamburguesaBuilder ConSalsa(string salsa);
        IHamburguesaBuilder ConPepinillos(bool pepinillos = true);
        IHamburguesaBuilder ConBacon(bool bacon = true);

        // Devuelve el producto final
        Hamburguesa Build();
    }
}
