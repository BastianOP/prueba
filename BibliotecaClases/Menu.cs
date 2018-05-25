using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Menu
    {
        private int precio;
        private string nombre;

        private List<Alimento> alimentos;
        private Pedido pedido;

        public Menu(Pedido pedido,
            int precio,
            string nombre)
        {
        }
        public Menu(int precio,
            string nombre)
        {
        }

        public void agregarAlimento(Alimento alimento)
        {
            Alimento alimentos = new Alimento("pan", 24);
        }
        public void quitarAlimento(Alimento alimento)
        {
            Alimento alimentos = new Alimento("pan", 24);
        }
        public int obtienePrecio()
        {
            return 10500;
        }
        public int cambiarPrecio(int precio)
        {
            return 10700;
        }
    }
}
