using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Extensiones
{
    public static class TipoDeJuego
    {

        /// <summary>
        /// Extension de Producto que obtiene el tipo del Producto.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns> retorna un string con el nombre del tipo del Producto.
        public static string ObtenerTipoDeJuego(this Producto producto)
        {
            string tipoDeJuego = string.Empty;
            if(producto is VideoJuego)
            {
                tipoDeJuego = "VideoJuego";
            }
            else
            {
                tipoDeJuego = "JuegoDeMesa";
            }
            return tipoDeJuego;
        }

    }
}
