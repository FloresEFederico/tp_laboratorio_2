using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class JuegoDeMesa : Producto,IArmado
    {

        private  List<EElementos> elementos;
        private bool tablero;
        private string objetivo;

        /// <summary>
        /// Constructor JuegoDeMesa con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clasificacion"></param>
        /// <param name="descripcion"></param>
        /// <param name="elementos"></param>
        /// <param name="tablero"></param>
        /// <param name="objetivo"></param>
        public JuegoDeMesa(string nombre,int clasificacion,string descripcion,List<EElementos> elementos,bool tablero,string objetivo) :base(nombre,clasificacion,descripcion)
        {
            this.elementos = elementos;
            this.tablero = tablero;
            this.objetivo = objetivo;
        }
        /// <summary>
        /// Constructor JuegoDeMesa Sin parametros.
        /// </summary>
        public JuegoDeMesa() : base()
        {
            this.elementos = new List<EElementos>();
            this.tablero = false;
            this.objetivo = "Sin objetivo definido";
        }

        /// <summary>
        /// Propiedad de escritura y lectura de la lista de Elementos
        /// </summary>
        public List<EElementos> Elementos
        {
            get
            {
                return this.elementos;
            }
            set
            {
                this.elementos = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de tablero
        /// </summary>
        public bool Tablero
        {
            get
            {
                return this.tablero;
            }
            set
            {
                this.tablero = value;
            }
        }
        /// <summary>
        /// Propiedad de escritura y lectura de Objetivo
        /// </summary>
        public string Objetivo
        {
            get
            {
                return this.objetivo;
            }
            set
            {
                this.objetivo = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura que retorna el listado de elementos en string
        /// </summary>
        public string ListadoDeLosElementos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (EElementos item in this.elementos)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
            
        }

        /// <summary>
        /// Creja una caja a partir de los elementos que tenga el juego
        /// </summary>
        /// <returns></returns> un string con el ancho longitud alto de la caja
        public string CrearCaja()
        {
            StringBuilder sb = new StringBuilder();
            int ancho = 3*this.elementos.Count;
            int longitud = 4*this.elementos.Count;
            int alto = 2*this.elementos.Count;
            string strTablero = "No incluye tablero.";
            if(tablero)
            {
                longitud += 2;
                ancho += 2;
                strTablero = "Incluye tablero.";
            }
            sb.AppendLine($"Dimensiones: ancho:{ancho} x longitud:{longitud} x alto: {alto} centímetros.{strTablero}");
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos del juego de mesa
        /// </summary>
        /// <returns></returns> string con todos los datos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string strTablero = "No";
            if(this.tablero)
            {
                strTablero = "Si";
            }
            sb.AppendLine("JUEGO DE MESA:");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Objetivo: {this.Objetivo}");
            sb.AppendLine($"Elementos:\n{ this.ListadoDeLosElementos}");
            sb.AppendLine($"Tablero: {strTablero}.");
            sb.AppendLine(this.CrearCaja());
            return sb.ToString();
        }

    }
}
