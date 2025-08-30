using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public class HamburguesaCeliacaBuilder : IHamburguesaBuilder
    {
        private Hamburguesa hambur = new Hamburguesa();

        public IHamburguesaBuilder ConPan(string pan)
        {
            throw new InvalidOperationException("No se puede poner pan en hamburguesa celiaca.");

        }
        public IHamburguesaBuilder ConCarne(string carne)
        {
            hambur.Carne = carne;
            return this;
        }

        public IHamburguesaBuilder ConQueso(bool agregar = true)
        {
            hambur.Queso = agregar;
            return this;
        }

        public IHamburguesaBuilder ConLechuga(bool agregar = true)
        {
            hambur.Lechuga = agregar;
            return this;
        }

        public IHamburguesaBuilder ConTomate(bool agregar = true)
        {
            hambur.Tomate = agregar;
            return this;
        }

        public IHamburguesaBuilder ConCebolla(bool agregar = true)
        {
            hambur.Cebolla = agregar;
            return this;
        }

        public IHamburguesaBuilder ConSalsa(string salsa)
        {
            hambur.Salsa = salsa;
            return this;
        }
        public IHamburguesaBuilder ConPepinillos(bool agregar = true)
        {
            hambur.Pepinillos = agregar;
            return this;
        }

        public IHamburguesaBuilder ConBacon(bool agregar = true)
        {
            hambur.Bacon = agregar;
            return this;
        }
        public Hamburguesa Build()
        {
            
            if (string.IsNullOrWhiteSpace(hambur.Carne))
                throw new InvalidOperationException("La hamburguesa debe tener carne!");

            var resultado = hambur;
            hambur = new Hamburguesa();
            return resultado;
        }
    }
}
