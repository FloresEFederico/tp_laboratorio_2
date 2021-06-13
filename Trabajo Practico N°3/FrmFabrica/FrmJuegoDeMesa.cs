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
    public partial class FrmJuegoDeMesa : Form
    {
        private Fabrica<Producto> fabricaDeJuegos;

        public FrmJuegoDeMesa(Fabrica<Producto> fabrica)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                JuegoDeMesa juegoDeMesa = CargarJuegoDeMesa();
                this.fabricaDeJuegos += juegoDeMesa;
                MessageBox.Show("Se ha fabricado el juego!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosIngresados();
            }
            catch (DatoInvalidoException noDato)
            {
                MessageBox.Show(noDato.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NoEspacioException noSpace)
            {
                MessageBox.Show(noSpace.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ProductosIgualesException equalProducts)
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

        private void LimpiarDatosIngresados()
        {
            this.txtNombre.Text = "";
            this.rtbDescripcion.Text = "";
            this.rtbObjetivo.Text = "";
            this.txtClasificacion.Text = "";
            foreach (Control elmt in this.grpElementos.Controls)
            {
                if (elmt is CheckBox && ((CheckBox)elmt).Checked)
                {
                    ((CheckBox)elmt).Checked = false;
                }
            }
        }

        private JuegoDeMesa CargarJuegoDeMesa()
        {
            try
            {
                string nombre;
                int clasificacion;
                string descripcion;
                string objetivo;
                bool tablero = false;
                string strTablero = this.cmbTablero.Text;
                List<EElementos> elementos = null;

                if (this.txtNombre.Text == "" || !this.txtNombre.Text.StartsWith(""))
                {
                    throw new DatoInvalidoException("No se ha ingresado un nombre valido!");
                }
                else
                {
                    nombre = this.txtNombre.Text;
                }

                if (!int.TryParse(this.txtClasificacion.Text, out clasificacion))
                {
                    throw new DatoInvalidoException("No se ha ingresado una clasificacion valida!");
                }

                if (this.rtbDescripcion.Text == "" || !this.rtbDescripcion.Text.StartsWith(""))
                {
                    throw new DatoInvalidoException("No se ha ingresado una Descripcion valida!");
                }
                else
                {
                    descripcion = this.rtbDescripcion.Text;
                }
                if(this.rtbObjetivo.Text == "" || !this.rtbObjetivo.Text.StartsWith(""))
                {
                    throw new DatoInvalidoException("No se ha ingresado un objetivo valido!");

                }
                else
                {
                    objetivo = this.rtbObjetivo.Text;
                }
                if(strTablero == "Si")
                {
                    tablero = true;
                }else if(strTablero == "No")
                {
                    tablero = false;
                }
                else
                {
                    throw new DatoInvalidoException("No se ha ingresado una opcion para tablero valido!");
                }

                elementos = CargarListaElementos();

                return new JuegoDeMesa(nombre, clasificacion, descripcion,elementos,tablero,objetivo);

            }
            catch (DatoInvalidoException noDato)
            {
                throw new DatoInvalidoException(noDato.Message);
            }
            catch(ListaNullException listaNull)
            {
                throw listaNull;
            }
        }

        private List<EElementos> CargarListaElementos()
        {
            List<EElementos> elementos = new List<EElementos>();
            bool flagIn = false;
            if(elementos is null)
            {
                throw new ListaNullException("Lista de elementos dio null");
            }
            foreach (Control elm in this.grpElementos.Controls)
            {
                if (elm is CheckBox && ((CheckBox)elm).Checked)
                {
                    EElementos auxElemento;
                    Enum.TryParse<EElementos>(elm.Text, out auxElemento);
                    elementos.Add(auxElemento);
                    flagIn = true;
                }
            }
            if (!flagIn)
            {
                throw new DatoInvalidoException("No se ha elegido ningun Elemento");
            }
            return elementos;
        }

        private void FrmJuegoDeMesa_Load(object sender, EventArgs e)
        {
            this.cmbTablero.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
