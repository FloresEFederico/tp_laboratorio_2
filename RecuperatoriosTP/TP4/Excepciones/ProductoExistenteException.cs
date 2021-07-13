using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductoExistenteException : Exception
    {

        /// <summary>
        /// Exception que se produce cuando se quiere subir un producto que ya se encuentra dentro de la base de datos.
        /// </summary>
        /// <param name="mensaje"></param>
        public ProductoExistenteException(string mensaje) : base(mensaje)
        {
        }
    }
}
