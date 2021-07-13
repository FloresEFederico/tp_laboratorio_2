using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using System.IO;
namespace Extensiones
{
    public static class Control
    {
        /// <summary>
        /// Guarda un archivo de texto de los juegos controlados.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="textoCalidad"></param>
        public static bool GuardarArchivoControl(this Producto producto,string textoCalidad)
        {
            bool append = false;
            if(textoCalidad != null)
            {
                string nameOfFile = "ControlDeCalidad.txt";
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = path + nameOfFile;
                if(producto is null)
                {
                    throw new ElementoNullException("El producto utilizado para llamar la funcion GuardarArchivoControl fue null!");
                }
                if(!Directory.Exists(path))
                {
                    throw new DirectorioInvalidoException("No existe el directorio donde se quiere guardar el archivo");
                }
                if(File.Exists(fullPath))
                {
                    append = true;
                }
                using (StreamWriter writer = new StreamWriter(fullPath, append))
                {
                    writer.WriteLine($"Nombre de juego: {producto.Nombre}. Tipo: {producto.ObtenerTipoDeJuego()}\nCalidad: {textoCalidad}");
                }
                return append;
            }
            else
            {
                throw new ElementoNullException("No se recibio ningun texto de calidad!");
            }
        }

        /// <summary>
        /// Controla la calidad de un juego.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns> retorna un string detallando la calidad del juego.
        public static string ControlarCalidadDeJuego(this Producto producto)
        {
            string calidadDelJuego = string.Empty;
            Random random = new Random();
            System.Threading.Thread.Sleep(100);
            int calidadNumerica = random.Next(10, 101);
            if (calidadNumerica < 40)
            {
                calidadDelJuego = "El juego es bastante aburrido.";
            }else if(calidadNumerica >= 40 && calidadNumerica < 60)
            {
                calidadDelJuego = "Tiene sus momentos, pero es mas malo que bueno.";
            }else if(calidadNumerica >= 60 && calidadNumerica < 80)
            {
                calidadDelJuego = "Buen juego. Entretenido y divertido.";
            }
            else
            {
                calidadDelJuego = "$$$ ¡¡¡HERE COMES THE MONEY!!! Fantastico juego $$$.";
            }
            if(producto is VideoJuego)
            {
                calidadDelJuego += ControlVideoJuego(((VideoJuego)producto), calidadNumerica);
            }
            else
            {
                calidadDelJuego += ControlJuegoDeMesa(((JuegoDeMesa)producto),calidadNumerica);
            }
            calidadDelJuego += $" Rating esperado: {calidadNumerica}/100.";
            return calidadDelJuego;
        }


        /// <summary>
        /// Controla la calidad de un videoJuego.
        /// </summary>
        /// <param name="videoJuego"></param>
        /// <param name="calidadNumerica"></param>
        /// <returns></returns> un string que describe la calidad del videojuego.
        private static string ControlVideoJuego(VideoJuego videoJuego, int calidadNumerica)
        {
            string calidadDelJuego = string.Empty;
            if (videoJuego.BugsDeFabrica > 0)
            {
                if (calidadNumerica < 80)
                {
                    calidadDelJuego = "Se encontraron bugs en el juego que afectaron la experiencia.";
                }
                else
                {
                    calidadDelJuego = "Se encontraron un par de bugs pero nada que haya arruinado la experiencia.";
                }
            }
            else
            {
                if (calidadNumerica < 80)
                {
                    calidadDelJuego = " No se encontraron bugs.";
                }
                else
                {
                    calidadDelJuego = " Ni siquiera se encontraron bugs! Una belleza.";
                }
            }
            return calidadDelJuego;
        }


        /// <summary>
        /// Controla la calidad de un JuegoDeMesa.
        /// </summary>
        /// <param name="videoJuego"></param>
        /// <param name="calidadNumerica"></param>
        /// <returns></returns> un string que describe la calidad de un JuegoDeMesa.
        private static string ControlJuegoDeMesa(JuegoDeMesa juegoDeMesa, int calidadNumerica)
        {
            string calidadDelJuego = string.Empty;
            int cantidadDeElementos = juegoDeMesa.Elementos.Count;
            if(cantidadDeElementos == 1)
            {
                switch (juegoDeMesa.Elementos[0])
                {
                    case EElementos.Cartas:
                        if (calidadNumerica < 80)
                        {
                            calidadDelJuego = "Solo tiene cartas, bastante monotono.";
                        }
                        else
                        {
                            calidadDelJuego = "Podria quedarme mirando las cartas por horas y aun asi divertirme!";
                        }
                        break;
                    case EElementos.Dados:
                        if (calidadNumerica < 80)
                        {
                            calidadDelJuego = "Los dados por cada tirada se vuelven mas pesados.";
                        }
                        else
                        {
                            calidadDelJuego = "El juego incluye dados de excelente calidad.";
                        }
                        break;
                    case EElementos.Piezas:
                        if (calidadNumerica < 80)
                        {
                            calidadDelJuego = "Algunas piezas son mas chiquita que otras y no me gustan.";
                        }
                        else
                        {
                            calidadDelJuego = "Excelente eleccion de piezas, lo que hacen mas divertido al juego a pesar de su escaces de elementos.";
                        }
                        break;
                    default:
                        break;
                }
                
            }else if(cantidadDeElementos == 2)
            {
                if(calidadNumerica < 80)
                {
                    calidadDelJuego = " Hay variedad de elementos, pero hasta ahi.";
                }
                else
                {
                    calidadDelJuego = " Hay variedad de elementos y eso le suma diez puntos.";
                }
            }
            else
            {
                if (calidadNumerica < 80)
                {
                    calidadDelJuego = " Hay gran variedad de elementos, pero no se entiende el proposito.";
                }
                else
                {
                    calidadDelJuego = " Tenes de todo para jugar! Cartas, dados, hasta piezas! Una maravilla para los amantes de los juegos de mesa.";
                }
            }
            return calidadDelJuego;
        }

    }
}
