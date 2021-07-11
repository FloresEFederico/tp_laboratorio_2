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
namespace FrmFabrica
{
    public partial class FrmVideoJuego : Form
    {
        private Fabrica<Producto> fabricaDeJuegos;
        public FrmVideoJuego(Fabrica<Producto> fabrica)
        {
            this.fabricaDeJuegos = fabrica;
            InitializeComponent();
        }
        public Fabrica<Producto> FabricaDeJuegos
        {
            get
            {
                return this.fabricaDeJuegos;
            }
        }
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            this.cmbFormato.DataSource = Enum.GetValues(typeof(EFormato));
            this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipoVideoJuego));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VideoJuego videoJuego = CargarVideoJuego();
                this.fabricaDeJuegos += videoJuego;
                MessageBox.Show("Se ha fabricado el juego!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (videoJuego.BugsDeFabrica > 0)
                {
                    MessageBox.Show($"Se han encontrado un total de: {videoJuego.BugsDeFabrica} bugs en el juego. Por favor, ir a la zona de testeo para arreglarlos.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarDatosIngresados();
                }
            }
            catch(DatoInvalidoException noDato)
            {
                MessageBox.Show(noDato.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch(NoEspacioException noSpace)
            {
                MessageBox.Show(noSpace.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ProductosIgualesException equalProducts)
            {
                MessageBox.Show(equalProducts.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ListaNullException listaNull)
            {
                MessageBox.Show(listaNull.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error a la hora de cargar los datos", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private VideoJuego CargarVideoJuego()
        {
            try
            {
                string nombre;
                int clasificacion;
                string descripcion;
                int duracion;
                ETipoVideoJuego tipo;
                EFormato formato;
                List<EPlataforma> plataformas = null; 
                
                if (this.txtNombre.Text == "" || this.txtNombre.Text.StartsWith(" "))
                {
                    throw new DatoInvalidoException("No se ha ingresado un nombre valido!");
                }
                else
                {
                    nombre = this.txtNombre.Text;
                }

                if(!int.TryParse(this.txtClasificacion.Text,out clasificacion))
                {
                    throw new DatoInvalidoException("No se ha ingresado una clasificacion valida!");
                }

                if(this.rtbDescripcion.Text == "" || this.rtbDescripcion.Text.StartsWith(" "))
                {
                    throw new DatoInvalidoException("No se ha ingresado una Descripcion valida!");
                }
                else
                {
                    descripcion = this.rtbDescripcion.Text;
                }
               
                if(!int.TryParse(this.txtDuracion.Text,out duracion))
                {
                    throw new DatoInvalidoException("No se ha ingresado una duracion valida!");
                }
                if(this.cmbTipo.SelectedValue is null || !Enum.TryParse<ETipoVideoJuego>(this.cmbTipo.SelectedValue.ToString(), out tipo))
                {
                    throw new DatoInvalidoException("No se ha ingresado un tipo valido!");
                }
                
                if(this.cmbFormato.SelectedValue is null || !Enum.TryParse<EFormato>(this.cmbFormato.SelectedValue.ToString(), out formato))
                {
                    throw new DatoInvalidoException("No se ha ingresado un Formato valido!");
                }

                plataformas = CargarListaPlataformas();
                
                return new VideoJuego(nombre, clasificacion, descripcion, tipo, plataformas, formato, duracion);

            }
            catch(ListaNullException listaNull)
            {
                throw listaNull;
            }
            catch(DatoInvalidoException noDato)
            {
                throw new DatoInvalidoException(noDato.Message);
            }
        }
        private void LimpiarDatosIngresados()
        {
            this.txtNombre.Text = "";
            this.rtbDescripcion.Text = "";
            this.txtDuracion.Text = "";
            this.txtClasificacion.Text = "";
            foreach (Control plat in this.grpPlataformas.Controls)
            {
                if (plat is CheckBox && ((CheckBox)plat).Checked)
                {
                    ((CheckBox)plat).Checked = false;
                }
            }
        }
        private List<EPlataforma> CargarListaPlataformas()
        {
            List<EPlataforma> plataformas = new List<EPlataforma>();
            bool flagIn = false;
            if(plataformas is null)
            {
                throw new ListaNullException("Lista de plataformas fue null");
            }
            foreach (Control plat in this.grpPlataformas.Controls)
            {
                if (plat is CheckBox && ((CheckBox)plat).Checked)
                {
                    EPlataforma auxPlat;
                    Enum.TryParse<EPlataforma>(plat.Text, out auxPlat);
                    plataformas.Add(auxPlat);
                    flagIn = true;
                }
            }
            if(!flagIn)
            {
                throw new DatoInvalidoException("No se ha elegido ninguna plataforma");
            }
            return plataformas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
