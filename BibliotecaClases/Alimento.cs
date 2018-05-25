using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Alimento
    {
        private string nombre;
        private int precio;

        private Pedido pedido;

        public Alimento(Pedido pedido,
            string nombre,
            int precio)
        {
            this.pedido = pedido;
            this.nombre = nombre;
            this.precio = precio;
        }
        public Alimento(string nombre,
            int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }


    }
    public class Plato { }
    public class Bebida { }
    public class Postre { }
    public class Ensalada { }
    public class Agregado { }
}
