using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public class VideoJuego : Producto,IBugs,IPesoByte
    {
        private ETipoVideoJuego tipo;
        private List<EPlataforma> plataformas;
        private EFormato formato;
        int duracion;
        int bugsDeFabrica;
        bool testeado;

        /// <summary>
        /// Constructor VideoJuego con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clasificacion"></param>
        /// <param name="descripcion"></param>
        /// <param name="tipo"></param>
        /// <param name="plataformas"></param>
        /// <param name="formato"></param>
        /// <param name="duracion"></param>
        public VideoJuego(string nombre, int clasificacion, string descripcion,ETipoVideoJuego tipo,List<EPlataforma> plataformas, EFormato formato, int duracion) 
            :base(nombre,clasificacion,descripcion)
        {
            this.Tipo = tipo;
            this.Plataformas = plataformas;
            this.BugsDeFabrica = CalcularBugs();
            if(this.bugsDeFabrica == 0)
            {
                this.Testeado = true;
            }
            else
            {
                this.Testeado = false;
            }
            this.Formato = formato;
            this.Duracion = duracion;
        }
        /// <summary>
        /// Constructor VideoJuego sin parametros
        /// </summary>
        public VideoJuego() :base()
        {
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Formato
        /// </summary>
        public EFormato Formato
        {
            get
            {
                return this.formato;
            }
            set
            {
                this.formato = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Tipo
        /// </summary>
        public ETipoVideoJuego Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Plataformas
        /// </summary>
        public List<EPlataforma> Plataformas
        {
            get
            {
                return this.plataformas;
            }
            set
            {
                this.plataformas = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Duracion
        /// </summary>
        public int Duracion
        {
            get
            {
                return this.duracion;
            }
            set
            {
                this.duracion = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Bugs de fabrica
        /// </summary>
        public int BugsDeFabrica
        {
            get
            {
                return this.bugsDeFabrica;
            }
            set
            {
                this.bugsDeFabrica = value;
            }
        }

        /// <summary>
        /// Propiedad de escritura y lectura de Testeado
        /// </summary>
        public bool Testeado
        {
            get
            {
                return this.testeado;
            }
            set
            {
                this.testeado = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura que retorna un string con todas las plataformas en la lista
        /// </summary>
        public string ListadoDePlataformas
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (EPlataforma item in this.plataformas)
                {
                    sb.AppendLine(item.ToString());
                }
                return sb.ToString();
            }
            
        }

        /// <summary>
        /// Calcula una cantidad random de bugs
        /// </summary>
        /// <returns></returns> numero random de 0 a 20
        public int CalcularBugs()
        {
            int randomBugs = new Random().Next(0, 20);
            System.Threading.Thread.Sleep(2);
            return randomBugs;
        }

        /// <summary>
        /// Arregla los bugs que tenga el juego, en caso de tenerlos.
        /// </summary>
        /// <returns></returns> false si el juego ya fue testeado, true si se arreglaron los bugs
        public bool FixearBugs()
        {
            bool retorno = false;
            
            if(!this.testeado)
            {
                this.bugsDeFabrica = 0;
                this.testeado = true;
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Calcula el peso del video juego
        /// </summary>
        /// <returns></returns> un string con el peso del juego 
        public string CalcularPesoDelJuego()
        {
            string pesototal = string.Empty;
            int pesoDelJuego = 0;
            switch (this.tipo)
            {
                case ETipoVideoJuego.Plataformas:
                case ETipoVideoJuego.Accion:
                case ETipoVideoJuego.Terror:
                case ETipoVideoJuego.Carreras:
                    pesoDelJuego = this.duracion * 2;
                    break;
                case ETipoVideoJuego.RPG:
                case ETipoVideoJuego.Aventura:
                    pesoDelJuego = this.duracion * 4;
                    break;
                default:
                    pesoDelJuego = this.duracion * 1;
                    break;
            }
            switch (this.formato)
            {
                case EFormato.Fisico:
                    pesototal = $"El juego pesa {pesoDelJuego}GB. No incluye artwork digital.";
                    break;
                case EFormato.Digital:
                    pesoDelJuego += 8;
                    pesototal = $"El juego pesa {pesoDelJuego}GB. Incluye artwork original dentro!";
                    break;
                default:
                    pesototal = $"El juego formato fisico pesa: {pesoDelJuego}GB.\n" +
                                $"En formato digital pesa: {pesoDelJuego+8}GB. Incluye artwork original dentro!";
                    break;
            }
            return pesototal;
        }

        /// <summary>
        /// Muestra todos los datos del VideoJuego
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string strTest = "No testeado!";
            
            sb.AppendLine("VIDEO JUEGO:");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Genero del juego:{ this.tipo}");
            sb.AppendLine($"Formato: {this.formato}.");
            sb.AppendLine($"Duracion: {this.duracion}Hrs.");
            sb.AppendLine(this.CalcularPesoDelJuego());
            if(this.testeado)
            {
                strTest = "Sin Bugs!";
                sb.AppendLine($"Estado: {strTest}");
            }
            else
            {
                sb.AppendLine($"{strTest}.Cantidad de bugs encontrados: {this.BugsDeFabrica}. por favor, arreglarlos!");
            }
            sb.Append($"Listado de plataformas:\n{this.ListadoDePlataformas}");
            return sb.ToString();
        }

        
      
    }
}
