using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente:Persona
    
    {
        private Pedido pedido;

        public Cliente(Pedido pedido)
        {
        }
        public Cliente()
        {
        }
        public Boolean registrarse(string[] parametros)
        {
            return true;
        }
        public void reservaMesa()
        {
            Mesa mesa = new Mesa(1, 2, true);

        }
        public void quitarMesa()
        {
            Mesa mesa = new Mesa(1, 2, false);
        }
    }
}
