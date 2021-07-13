using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DirectorioInvalidoException : Exception
    {

        /// <summary>
        /// Excepcion producida al pasar un directorio invalido
        /// </summary>
        /// <param name="mensaje"></param>
        public DirectorioInvalidoException(string mensaje):base(mensaje)
        {

        }
    }
}
