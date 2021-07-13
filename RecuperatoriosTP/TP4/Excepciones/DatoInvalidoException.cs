using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DatoInvalidoException : Exception
    {

        /// <summary>
        /// Excepcion producida cuando se ingreso un dato invalido.
        /// </summary>
        /// <param name="mensaje"></param>
        public DatoInvalidoException(string mensaje):base(mensaje)
        {
        }
    }
}
