using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Pedido
    {
        private DateTime fecha;
        private DateTime hora;
        private Boolean estado;

        private Cliente cliente;
        private Garzon garzon;
        private List<Menu> menu;
        private List<Alimento> alimentos;
        private Mesa mesa;


        public Pedido(DateTime fecha,
            DateTime hora,
            Boolean estado
            )
        {
            this.fecha = fecha;
            this.hora = hora;
            this.estado = estado;
        }

        public Boolean registrarse(string[] parametros)
        {

            return true;
        }


    }
}
