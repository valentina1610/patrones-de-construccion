using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public class Hamburguesa
    {
        public string Pan { get; set; }
        public string Carne { get; set; }
        public bool Queso { get; set; }
        public bool Lechuga { get; set; }
        public bool Tomate { get; set; }
        public bool Cebolla { get; set; }
        public string Salsa { get; set; }
        public bool Pepinillos { get; set; }
        public bool Bacon { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(); //StringBuilder es una clase especial
                                          //que permite ir agregando texto sin tener que
                                          //ir creando cada vez un nuevo string
            sb.AppendLine($"Pan: {Pan}"); //AppendLine significa que le agrega una linea al string
            sb.AppendLine($"Carne: {Carne}");
            sb.AppendLine($"Queso: {(Queso ? "Sí" : "No")}"); //Si es true ingresa "Si" y si es false ingresa "No"
            sb.AppendLine($"Lechuga: {(Lechuga ? "Sí" : "No")}");
            sb.AppendLine($"Tomate: {(Tomate ? "Sí" : "No")}");
            sb.AppendLine($"Cebolla: {(Cebolla ? "Sí" : "No")}");
            sb.AppendLine($"Pepinillos: {(Pepinillos ? "Sí" : "No")}");
            sb.AppendLine($"Bacon: {(Bacon ? "Sí" : "No")}");
            sb.AppendLine($"Salsa: {Salsa}");
            return sb.ToString(); //comvierte todo lo armado en un string normal
        }
    }
}
