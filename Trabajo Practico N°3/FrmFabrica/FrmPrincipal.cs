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
namespace FrmFabrica
{
    public partial class FrmPrincipal : Form
    {
        private Fabrica<Producto> fabricaDeJuegos;
        private bool flagLectura;
        public FrmPrincipal()
        {
            this.fabricaDeJuegos = new Fabrica<Producto>("Sueños Felices", 10);
            this.flagLectura = false;
            InitializeComponent();
        }

        private void btnVideoJuego_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVideoJuego frmJuego = new FrmVideoJuego(this.fabricaDeJuegos);
                frmJuego.ShowDialog();
                this.fabricaDeJuegos = frmJuego.FabricaDeJuegos;
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
                MessageBox.Show("Se ha guardado los juegos fabricados!", "Success");

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
                FrmJuegoDeMesa frmJuegoDeMesa = new FrmJuegoDeMesa(this.fabricaDeJuegos);
                frmJuegoDeMesa.ShowDialog();
                this.fabricaDeJuegos = frmJuegoDeMesa.FabricaDeJuegos;
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
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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
    }
}
