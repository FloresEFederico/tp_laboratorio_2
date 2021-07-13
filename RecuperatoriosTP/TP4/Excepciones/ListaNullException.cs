using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaNullException : Exception
    {

        /// <summary>
        /// Excepcion producida cuando un listado es null
        /// </summary>
        /// <param name="mensaje"></param>
        public ListaNullException(string mensaje) :base(mensaje)
        {
        }
    }
}
