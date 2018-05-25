using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Trabajador : Persona
    {
        private int sueldo;
        private DateTime fechaContratacion;

        public void agregarBono(int bono)
        {

        }
        public int obtieneSueldo(Trabajador trabajador)
        {
            return sueldo;
        }
    }
}
