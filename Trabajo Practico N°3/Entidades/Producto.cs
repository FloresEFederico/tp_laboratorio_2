using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(JuegoDeMesa))]
    [XmlInclude(typeof(VideoJuego))]
    public abstract class Producto
    {
        private string nombre;
        private int clasificacionPorEdad;
        private string descripcion;

        /// <summary>
        /// Constructor Producto con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clasificacion"></param>
        /// <param name="descripcion"></param>
        public Producto(string nombre,int clasificacion,string descripcion)
        {
            this.Nombre = nombre;
            this.ClasificacionPorEdad = clasificacion;
            this.Descripcion = descripcion;
        }
        /// <summary>
        /// Constructor Producto sin parametros
        /// </summary>
        public Producto()
        {
        }
        /// <summary>
        /// Propieda de escritura y lectura de Nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Clasificacion por edad
        /// </summary>
        public int ClasificacionPorEdad
        {
            get
            {
                return this.clasificacionPorEdad;
            }
            set
            {
                this.clasificacionPorEdad = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Descripion
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <summary>
        /// Sobrecarga del operador = 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns> true si los elementos son iguales, false si no lo son 
        public static bool operator ==(Producto p1,Producto p2)
        {
            return p1.nombre == p2.nombre;
        }

        /// <summary>
        /// Sobrecarga del operador != 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns> true si los elementos son desiguales, false si son iguales
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Muestra los datos del producto
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                $"Nombre: {this.nombre}.\n" +
                $"Para mayores de: {this.clasificacionPorEdad} años.\n" +
                $"Descripcion: \n{this.descripcion}.");
            return sb.ToString();
        }

        /// <summary>
        /// sobrescritura del metodo ToString()
        /// </summary>
        /// <returns></returns> Retorna el nombre del producto
        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
