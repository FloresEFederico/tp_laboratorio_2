using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ElementoNullException : Exception
    {

        /// <summary>
        /// Excepcion producida cuando un elemento es null
        /// </summary>
        /// <param name="mensaje"></param>
        public ElementoNullException(string mensaje) :base(mensaje)
        {

        }
    }
}
