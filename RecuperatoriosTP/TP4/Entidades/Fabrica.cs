using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public class Fabrica<T> where T: Producto
    {
        private List<T> juegosFabricados;
        private string nombre;
        private int espacioLibre;

        /// <summary>
        /// Constructor sin parametros Fabrica(Inicializa la lista juegosFabrica)
        /// </summary>
        public Fabrica()
        {
            this.juegosFabricados = new List<T>();
        }
        /// <summary>
        /// Constructor Fabrica con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Fabrica(string nombre,int stock) :this()
        {
            if(nombre is null)
            {
                this.nombre = "Fabrica De Juegos";
            }
            else
            {
                this.nombre = nombre;
            }
            if(stock < 0)
            {
                this.espacioLibre = 0;
            }
            else
            {
                this.EspacioLibre = stock;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Nombre
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
        /// Propiedad de escritura y lectura de Juegos Fabricados
        /// </summary>
        public List<T> JuegosFabricados
        {
            get
            {
                return this.juegosFabricados;
            }
            set
            {
                this.juegosFabricados = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Espacio libre
        /// </summary>
        public int EspacioLibre
        {
            get
            {
                return this.espacioLibre;
            }
            set
            {
                if(this.espacioLibre >= 0)
                {
                    this.espacioLibre = value;
                }
            }
        }

        /// <summary>
        /// Agrega mas espacio libre a la fabrica
        /// </summary>
        /// <param name="incremento"></param>
        /// <returns></returns> false si el incremento pasado por parametro es menor a 0 , true si se incremento el espacio
        public bool AgregarEspacioALaFabrica(int incremento)
        {
            bool retorno = false;
            if(incremento > 0)
            {
                this.EspacioLibre += incremento;
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Muestra todos los datos de la fabrica
        /// </summary>
        /// <returns></returns> string con todos los datos
        public string MostrarDatosDeLaFabrica()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"FABRICA:{this.nombre}");
            if(this.JuegosFabricados.Count != 0)
            {
                foreach (T item in this.JuegosFabricados)
                {
                    sb.AppendLine(item.Mostrar());
                    sb.AppendLine("------------------------------------------");
                }
            }
            else
            {
                sb.AppendLine("No se ha fabricado ningun juego!");
            }
                sb.AppendLine($"Espacio disponible: {this.espacioLibre}");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador +. Agrega un producto a la fabrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="producto"></param>
        /// <returns></returns> Fabrica<T>
        public static Fabrica<T> operator +(Fabrica<T> fabrica, T producto)
        {
            if(fabrica.EspacioLibre <= 0)
            {
                throw new NoEspacioException("No hay mas espacio para guardar juegos dentro de la fabrica!");
            }
            if (fabrica != producto)
            {
                fabrica.juegosFabricados.Add(producto);
                fabrica.espacioLibre--;
            }
            else
            {
                throw new ProductosIgualesException("No se pudo guardar ese producto, ya que existe un producto identico dentro de la lista");
            }
            return fabrica;
        }

        /// <summary>
        /// Sobrecarga del operador =
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="producto"></param>
        /// <returns></returns> true si son iguales, false si no lo son.
        public static bool operator ==(Fabrica<T>fabrica, T producto)
        {
            bool retorno = false;
            foreach (T item in fabrica.JuegosFabricados)
            {
                if(item.GetType() == producto.GetType() && item == producto)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrcarga del operador !=
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="producto"></param>
        /// <returns></returns> true si son desiguales, false si son iguales
        public static bool operator !=(Fabrica<T> fabrica, T producto)
        {
            return !(fabrica == producto);
        }
    }
}
