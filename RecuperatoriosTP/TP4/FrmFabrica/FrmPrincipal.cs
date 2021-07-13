using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using Excepciones;
using System.Threading;
namespace FrmFabrica
{
    public delegate void DelegadoTitulo(int numero);
    public partial class FrmPrincipal : Form
    {
        private Fabrica<Producto> fabricaDeJuegos;
        private bool flagLectura;
        private bool flagGuardado;
        private Thread hiloTitulo;
        private event DelegadoTitulo eventoTitulo;

        public FrmPrincipal()
        {
            this.fabricaDeJuegos = new Fabrica<Producto>("Sueños Felices", 10);
            this.flagLectura = false;
            this.flagGuardado = true;
            this.hiloTitulo = new Thread(MostrarTitulo);
            eventoTitulo += CambiarImagen;
            InitializeComponent();
        }

        private void btnVideoJuego_Click(object sender, EventArgs e)
        {
            try
            {
                int espacioLibreAnterior = this.fabricaDeJuegos.EspacioLibre;
                FrmVideoJuego frmJuego = new FrmVideoJuego(this.fabricaDeJuegos);
                frmJuego.ShowDialog();
                this.fabricaDeJuegos = frmJuego.FabricaDeJuegos;
                if(espacioLibreAnterior > this.fabricaDeJuegos.EspacioLibre)
                {
                    this.flagGuardado = false;
                }
            }
            catch(InvalidOperationException invalidOperation)
            {
                MessageBox.Show(invalidOperation.Message, "OPERACION INVALIDA");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.Message, "Error");

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.rtbListaDeJuegos.Text = this.fabricaDeJuegos.MostrarDatosDeLaFabrica();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta;
                string nombreArchivo;
                DestinoXml(out ruta, out nombreArchivo);
                SerializadorXml<Fabrica<Producto>> guardar = new SerializadorXml<Fabrica<Producto>>(ruta,nombreArchivo);
                guardar.Guardar(this.fabricaDeJuegos);
                this.flagGuardado = true;
                MessageBox.Show("Se han guardado los datos!", "Success");
            }
            catch(ElementoNullException nullString)
            {
                MessageBox.Show(nullString.Message, "Error");
            }
            catch(DirectorioInvalidoException directoryInvalid)
            {
                MessageBox.Show(directoryInvalid.Message, "Error");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message, "Error de excepcion inesperada u.u?");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!flagLectura)
                {
                    string ruta;
                    string nombreDeArchivo;
                    DestinoXml(out ruta,out nombreDeArchivo);
                    SerializadorXml<Fabrica<Producto>> cargar = new SerializadorXml<Fabrica<Producto>>(ruta, nombreDeArchivo);
                    this.fabricaDeJuegos = cargar.Leer();
                    this.flagLectura = true;
                    MessageBox.Show("Se han cargado los datos exitosamente!", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ya se ha cargado el archivo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            catch(ElementoNullException nullString)
            {
                MessageBox.Show(nullString.Message,"Error");
            }
            catch(ArchivoNoEncontradoException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message, "Error");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.Message, "Error");
            }
        }
        private void DestinoXml(out string ruta,out string nombreDeArchivo)
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            nombreDeArchivo = "FabricaXml.txt";
        }
        
        private void btnArreglo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBugs frmBugs = new FrmBugs(this.fabricaDeJuegos);
                frmBugs.ShowDialog();
                this.fabricaDeJuegos = frmBugs.FabricaDeJuegos;
                if(!frmBugs.Guardado)
                {
                    this.flagGuardado = frmBugs.Guardado;
                }
            }
            catch (InvalidOperationException invalidOperation)
            {
                MessageBox.Show(invalidOperation.Message, "OPERACION INVALIDA");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message, "Error");

            }
        }

        private void btnJuegoDeMesa_Click(object sender, EventArgs e)
        {
            try
            {
                int espacioLibreAnterior = this.fabricaDeJuegos.EspacioLibre;
                FrmJuegoDeMesa frmJuegoDeMesa = new FrmJuegoDeMesa(this.fabricaDeJuegos);
                frmJuegoDeMesa.ShowDialog();
                this.fabricaDeJuegos = frmJuegoDeMesa.FabricaDeJuegos;
                if(espacioLibreAnterior > this.fabricaDeJuegos.EspacioLibre)
                {
                    this.flagGuardado = false;
                }
            }
            catch(InvalidOperationException invalidOperation)
            {
                MessageBox.Show(invalidOperation.Message, "OPERACION INVALIDA");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.Message, "Error");

            }
        }

        private void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            int incremento = 5;
            if(this.fabricaDeJuegos.AgregarEspacioALaFabrica(incremento))
            {
                MessageBox.Show($"Se agrego una cantidad de 5 al espacio de juegos de la fabrica.\nCantidad De espacios libres: {this.fabricaDeJuegos.EspacioLibre}");
                this.flagGuardado = false;
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(!this.flagGuardado  && MessageBox.Show("¿Esta seguro que desea salir sin guardar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if(this.hiloTitulo.IsAlive)
                {
                    this.hiloTitulo.Abort();
                }
            }
            
        }
        
        /// <summary>
        /// Destino donde se guardara el archivo de texto. 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="nombreDeArchivo"></param>
        private void DestinoTexto(out string ruta, out string nombreDeArchivo)
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            nombreDeArchivo = "FabricaTexto.txt";
        }

        private void btnGuardarTexto_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta;
                string nombreArchivo;
                DestinoTexto(out ruta, out nombreArchivo);
                ArchivoTexto<Fabrica<Producto>> archivoDeTexto = new ArchivoTexto<Fabrica<Producto>>(ruta,nombreArchivo);
                archivoDeTexto.GuardarTexto(this.fabricaDeJuegos);

                MessageBox.Show("Se ha generado un archivo de texto con los datos de la fabrica!", "Success");
            }
            catch (ElementoNullException nullString)
            {
                MessageBox.Show(nullString.Message, "Error");
            }
            catch (DirectorioInvalidoException directoryInvalid)
            {
                MessageBox.Show(directoryInvalid.Message, "Error");

            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message, "Error de excepcion inesperada u.u?");
            }
        }

        private void btnLeerTexto_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta;
                string nombreDeArchivo;
                DestinoTexto(out ruta, out nombreDeArchivo);
                ArchivoTexto<Fabrica<Producto>> archivoDeTexto = new ArchivoTexto<Fabrica<Producto>>(ruta, nombreDeArchivo);
                this.rtbListaDeJuegos.Text = archivoDeTexto.LeerTexto();
                MessageBox.Show("Se ha cargado el texto exitosamente!", "Success", MessageBoxButtons.OK);
            }
            catch (ElementoNullException nullString)
            {
                MessageBox.Show(nullString.Message, "Error");
            }
            catch (ArchivoNoEncontradoException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message, "Error");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message, "Error");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            if(flagLectura)
            {
                FrmBaseDeDatos frmBaseDeDatos = new FrmBaseDeDatos(this.fabricaDeJuegos.JuegosFabricados);
                frmBaseDeDatos.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Para poder acceder primero hay que cargar los datos xml.", "No se cargo datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.hiloTitulo.Start();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message,"Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Muestra el titulo del formulario principal: "Fabrica de Juegos"
        /// </summary>
        private void MostrarTitulo()
        {
            int contador = 1;
            bool flagUpAndDown = false;
            while(true)
            {
                this.eventoTitulo.Invoke(contador);
                if(!flagUpAndDown)
                {
                    contador++;
                    if(contador == 6)
                    {
                        flagUpAndDown = true;
                    }
                }
                else
                {
                    contador--;
                    if(contador == 1)
                    {
                        flagUpAndDown = false;
                    }
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Cambia la imagen del titulo segun el numero que se pasa por parametro
        /// </summary>
        /// <param name="numero"></param>
        private void CambiarImagen(int numero)
        {
            if(this.btnTitulo.InvokeRequired)
            {
                DelegadoTitulo delegado = new DelegadoTitulo(CambiarImagen);
                object[] objeto = new object[] { numero };
                this.Invoke(delegado, objeto);
            }
            else
            {
                switch (numero)
                {
                    case 1:
                        this.btnTitulo.Image = Properties.Resources._1;
                        break;
                    case 2:
                        this.btnTitulo.Image = Properties.Resources._2;
                        break;
                    case 3:
                        this.btnTitulo.Image = Properties.Resources._3;
                        break;
                    case 4:
                        this.btnTitulo.Image = Properties.Resources._4;
                        break;
                    case 5:
                        this.btnTitulo.Image = Properties.Resources._5;
                        break;
                    case 6:
                        this.btnTitulo.Image = Properties.Resources._6;
                        break;
                }
            }
        }

        private void btnControlDeCalidad_Click(object sender, EventArgs e)
        {
            if(this.flagLectura)
            {
                FrmControlDeCalidad frmControlDeCalidad = new FrmControlDeCalidad(this.fabricaDeJuegos);
                frmControlDeCalidad.ShowDialog();
                this.fabricaDeJuegos = frmControlDeCalidad.FabricaDeJuegos;
                if(!frmControlDeCalidad.Guardado)
                {
                    this.flagGuardado = frmControlDeCalidad.Guardado;
                }
            }
            else
            {
                MessageBox.Show("Para poder acceder primero hay que cargar los datos xml.", "No se cargo datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
