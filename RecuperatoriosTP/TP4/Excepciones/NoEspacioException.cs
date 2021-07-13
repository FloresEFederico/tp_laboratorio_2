using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoEspacioException : Exception
    {
        /// <summary>
        /// Excepcion producida cuando no hay mas espacio libre en la fabrica
        /// </summary>
        /// <param name="mensaje"></param>
        public NoEspacioException(string mensaje): base(mensaje)
        {
        }
    }
}
