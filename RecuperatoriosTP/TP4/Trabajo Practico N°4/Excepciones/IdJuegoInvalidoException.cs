using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class IdJuegoInvalidoException : Exception
    {
        /// <summary>
        /// Exception que se produce cuando un IdJuego es invalido
        /// </summary>
        /// <param name="mensaje"></param>
        public IdJuegoInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
