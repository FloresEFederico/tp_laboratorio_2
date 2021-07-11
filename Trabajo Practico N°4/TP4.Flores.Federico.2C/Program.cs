using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TP3.Flores.Federico._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoJuego videoJuego = new VideoJuego("Need for Speed Underground", 13, "Juegazo de fuchibol", ETipoVideoJuego.Carreras, new List<EPlataforma>() { EPlataforma.Playstation }, EFormato.Fisico, 40);
            JuegoDeMesa juegoDeMesa = new JuegoDeMesa("OCA", 8, "El juego de la oca ya empezo iha iha oh", new List<EElementos>() { { EElementos.Dados },{ EElementos.Piezas } }, true, "Ganar");
            Fabrica<Producto> fabrica = new Fabrica<Producto>("Fabrica sueños felices", 5);
            Console.WriteLine("DATOS DEL VIDEOJUEGO:");
            Console.WriteLine(videoJuego.Mostrar());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("DATOS DEL JUEGO DE MESA");
            Console.WriteLine(juegoDeMesa.Mostrar());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("presionar cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("LE ARREGLAMOS LOS BUGS AL VIDEOJUEGO");
            if(videoJuego.FixearBugs())
            {
                Console.WriteLine("Fixeado");
            }
            else
            {
                Console.WriteLine("No tenia bugs :D");
            }
            Console.WriteLine("VOLVEMOS A MOSTRAR LOS DATOS DEL JUEGO CON LO BUGS CORREGIDOS");
            Console.WriteLine(videoJuego.Mostrar());
            Console.WriteLine("presionar cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("FABRICA INSTANCIADA");
            Console.WriteLine(fabrica.MostrarDatosDeLaFabrica());
            Console.WriteLine("presionar cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("AGREGAMOS EL VIDEOJUEGO Y EL JUEGO DE MESA A LA FABRICA");
            fabrica += videoJuego;
            fabrica += juegoDeMesa;
            Console.WriteLine("FABRICA CON LOS OBJETOS DENTRO DE LA LISTA:");
            Console.WriteLine(fabrica.MostrarDatosDeLaFabrica());
            Console.WriteLine("presionar cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("AGREGAMOS ESPACIO A LA FABRICA");
            Console.WriteLine($"FABRICA ESPACIO ANTES: {fabrica.EspacioLibre}");
            fabrica.AgregarEspacioALaFabrica(5);
            Console.WriteLine($"FABRICA ESPACIO AHORA: {fabrica.EspacioLibre}");
            Console.ReadKey();
        }
    }
}//(ouo)/
