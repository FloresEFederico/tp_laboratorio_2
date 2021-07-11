using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivoNoEncontradoException : Exception
    {

        /// <summary>
        /// Excepcion producida cuando no se encontro la ruta deun archivo.
        /// </summary>
        /// <param name="mensaje"></param>
        public ArchivoNoEncontradoException(string mensaje) : base(mensaje)
        {

        }
    }
}
