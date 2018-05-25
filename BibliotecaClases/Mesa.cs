using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Mesa
    {
        private int numero;
        private int cantidadPersonas;
        private Boolean estado;

        private Pedido pedido;

        public Mesa(Pedido pedido,
            int numero,
            int cantidadPersonas,
            bool estado
            )
        {
            this.pedido = pedido;
            this.numero = numero;
            this.cantidadPersonas = cantidadPersonas;
            this.estado = estado;
        }
        public Mesa(int numero,
            int cantidadPersonas,
            bool estado)
        {
            this.numero = numero;
            this.cantidadPersonas = cantidadPersonas;
            this.estado = estado;
        }

        public void registrar(Boolean tipo)
        {
        }
        public Boolean consultaEstado()
        {
            return estado;
        }
        public List<Mesa> disponibles()
        {
            return new List<Mesa>();
        }
    }
}
