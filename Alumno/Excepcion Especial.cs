using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    public class Excepcion_Especial: ApplicationException
    {
        //Creamos el metodo Exception_Especial
        public Excepcion_Especial()
        {

        }

        //Creamos la sobrecarga del metodo Excpetion_Especial
        public Excepcion_Especial(string msg): base(msg)
        {

        }
    }
}
