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
using Excepciones;
using Archivos;
using Extensiones;
using System.Threading;
using System.IO;
namespace FrmFabrica
{
    public delegate void Callback(int tiempo);
    public partial class FrmControlDeCalidad : Form
    {
        private Fabrica<Producto> fabrica;
        private Thread hiloControlDeCalidad;
        private Producto auxProduct;
        private string controlDelJuego;
        public event Callback eventoControlador;
        private bool controladoBoton;
        private bool flagGuardado;

        public FrmControlDeCalidad(Fabrica<Producto> fabrica)
        {
            this.fabrica = fabrica;
            this.flagGuardado = true;
            InitializeComponent();
        }

        public Fabrica<Producto> FabricaDeJuegos
        {
            get
            {
                return this.fabrica;
            }
        }

        public bool Guardado
        {
            get
            {
                return this.flagGuardado;
            }
        }

        private void FrmControlDeCalidad_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in this.fabrica.JuegosFabricados)
            {
                this.lstProductos.Items.Add(producto);
            }
            this.controladoBoton = false;
            this.eventoControlador += ProbarCalidadDelJuego;
        }

        private void btnProbarJuego_Click(object sender, EventArgs e)
        {
            try
            {
                if (Object.ReferenceEquals(this.lstProductos.SelectedItem, null))
                {
                    throw new ElementoNullException("No se ha seleccionado ningun juego de la lista");
                }
                if (!((Producto)this.lstProductos.SelectedItem).Controlado)
                {
                    if (!this.controladoBoton)
                    {
                        if(this.hiloControlDeCalidad == null || !this.hiloControlDeCalidad.IsAlive)
                        {
                            this.hiloControlDeCalidad = new Thread(Probar);
                            this.hiloControlDeCalidad.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya se ha controlado un juego, por favor ir al boton 'Resultado del Control'", "UPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El juego elegido ya fue controlado, no hay necesidad de volver a controlar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(ElementoNullException nullElement)
            {
                MessageBox.Show(nullElement.Message, "FAILURE", MessageBoxButtons.OK);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        /// <summary>
        /// Metodo que simula el control de un Juego.
        /// </summary>
        private void Probar()
        {
            int tiempo = 5;
            
            while(tiempo >= 0)
            {
                this.eventoControlador.Invoke(tiempo);    
                tiempo--;
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Prueba la calidad de un juego. 
        /// </summary>
        /// <param name="tiempo"></param>
        private void ProbarCalidadDelJuego(int tiempo)
        {
            try
            {
                if(this.InvokeRequired)
                {
                    Callback delegado = new Callback(ProbarCalidadDelJuego);
                    object[] obj = new object[] { tiempo };
                    this.Invoke(delegado,obj);
                }
                else
                {
                    if(tiempo > 0)
                    {
                        this.btnProbarJuego.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                        this.btnProbarJuego.Text = tiempo.ToString();
                    }
                    else
                    {
                        this.btnProbarJuego.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                        this.btnProbarJuego.Text = "PROBADO!";
                        Producto juego = (Producto)this.lstProductos.SelectedItem;
                        juego.Controlado = true;
                        this.controlDelJuego = juego.ControlarCalidadDeJuego();
                        MessageBox.Show("Se controlo el juego satisfactoriamente, ir al boton 'Resultado del Control'", "SUCCESS", MessageBoxButtons.OK);
                        this.auxProduct = juego;
                        this.controladoBoton = true;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que genera un achivo mostrando el resultado de el juego controlado. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResultado_Click(object sender, EventArgs e)
        {
            bool fileExist;
            try
            {
                if(this.controladoBoton)
                {
                    fileExist = this.auxProduct.GuardarArchivoControl(this.controlDelJuego);
                    MessageBox.Show(this.controlDelJuego, "SUCCESS", MessageBoxButtons.OK);
                    if (fileExist)
                    {
                        MessageBox.Show("Se agregó al archivo de texto los resultados nuevos", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se generó un archivo de texto con los resultados obtenidos", "SUCCESS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    this.btnProbarJuego.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnProbarJuego.Text = "Probar Juego";
                    this.controladoBoton = false;
                    this.flagGuardado = false;
                }
                else
                {
                    MessageBox.Show("Ya se ha dado los resultados de ese juego, por favor elija otro", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(DirectorioInvalidoException directoryNotFound)
            {
                MessageBox.Show(directoryNotFound.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ElementoNullException nullElement)
            {
                MessageBox.Show(nullElement.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se probo ningun juego", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmControlDeCalidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hiloControlDeCalidad != null && this.hiloControlDeCalidad.IsAlive)
            {
                this.hiloControlDeCalidad.Abort();
            }

        }

        private void btnVolverAProbar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que desea volver a probar los juegos?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Producto producto in this.fabrica.JuegosFabricados)
                {
                    producto.Controlado = false;
                }
                if(this.controladoBoton)
                {
                    this.btnProbarJuego.Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular, GraphicsUnit.Point);
                    this.btnProbarJuego.Text = "Probar Juego";
                    this.controladoBoton = false;
                }
                BorrarArchivoControl();     
                MessageBox.Show("Se borro el control anterior! Puede volver a probar los juegos!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            try
            {

            }
            catch(DirectorioInvalidoException invalidDirectory)
            {
                MessageBox.Show(invalidDirectory.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Borra el archivo de control. 
        /// </summary>
        private void BorrarArchivoControl()
        {
            string nameOfFile = "ControlDeCalidad.txt";
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = path + nameOfFile;
            if (!Directory.Exists(path))
            {
                throw new DirectorioInvalidoException("No existe el directorio donde se quiere guardar el archivo");
            }
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
