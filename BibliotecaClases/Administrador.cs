using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Administrador : Trabajador
    {
        public void agregarEmpleado(Empleado empleado)
        {

        }
        public void quitarEmpleado(Empleado empleado)
        {

        }
        public void agregaBonificacion(Empleado empleado, int monto)
        {
        }
        public List<Pedido> visualizaVentas(DateTime inicio, DateTime termino)
        {
            List<Pedido> pedidos = new List<Pedido>();
            return pedidos;
        }
        public List<Pedido> visualizaVentas()
        {

            List<Pedido> pedidos = new List<Pedido>();
            return pedidos;
        }
        public void pagarEmpleados(Empleado empleado, int mes, int anio)
        {
        }
    }
}
