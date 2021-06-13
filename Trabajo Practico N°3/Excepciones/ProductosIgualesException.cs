using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductosIgualesException : Exception
    {
        /// <summary>
        /// Excepcion producida cuando dos productos son iguales
        /// </summary>
        /// <param name="mensaje"></param>
        public ProductosIgualesException(string mensaje)
            :base(mensaje)
        {
        }
    }
}
