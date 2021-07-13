using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;
namespace FrmFabrica
{
    public delegate void TablaDelegado();
    public partial class FrmBaseDeDatos : Form
    {
        private List<Producto> listaDeJuegos;
        private DataTable tabla;
        private Thread hiloBaseDeDatos;
        private event TablaDelegado eventoTabla;
        
        public FrmBaseDeDatos(List<Producto> listado)
        {
            this.listaDeJuegos = listado;
            this.hiloBaseDeDatos = new Thread(ActualizarDatosDeTabla);
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad de lectura de HiloBaseDeDatos
        /// </summary>
        public Thread HiloBaseDeDatos
        {
            get
            {
                return this.hiloBaseDeDatos;
            }
        }

        private void FrmBaseDeDatos_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in this.listaDeJuegos)
            {
                this.lstProductos.Items.Add(producto);
            }
            foreach (Control control in this.pnlMostrarPorTipo.Controls)
            {
                ((Button)control).Click += MostrarPorTipo;
            }
            this.eventoTabla += this.CargarDatosALaTabla;
            this.hiloBaseDeDatos.Start();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto auxProducto = (Producto)this.lstProductos.SelectedItem;
                
                if(!FabricaDAO.BuscarProductoExistente(auxProducto))
                {
                    int cantidadDeFilasModificadas = FabricaDAO.InsertarJuego(auxProducto);
                    MessageBox.Show($"Numero de filas afectadas: {cantidadDeFilasModificadas}.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.LimpiarTabla();
                }
            }
            catch(ProductoExistenteException productFound)
            {
                MessageBox.Show(productFound.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(ElementoNullException productNull)
            {
                MessageBox.Show(productNull.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("No se eligio ningun producto del listado.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Actualiza los datos de la tabla 
        /// </summary>
        public void ActualizarDatosDeTabla()
        {
            while(true)
            {
                if(this.tabla is null)
                {
                    this.eventoTabla.Invoke();
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Carga los datos en la tabla. 
        /// </summary>
        public void CargarDatosALaTabla()
        {
            try
            {
                if(this.dgvTabla.InvokeRequired)
                {
                    TablaDelegado delegado = new TablaDelegado(CargarDatosALaTabla);
                    this.Invoke(delegado);
                }
                else
                {
                    this.tabla = FabricaDAO.CargarDatosALaTabla();
                    this.dgvTabla.DataSource = this.tabla;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idABorrar;
            int numeroDeColumnasAfectadas = 0;
            try
            {
                if(int.TryParse(this.txtIdABorrar.Text,out idABorrar))
                {
                    numeroDeColumnasAfectadas = FabricaDAO.BorrarJuegoPorId(idABorrar);
                    if(numeroDeColumnasAfectadas != 0)
                    {
                        MessageBox.Show($"Numero de filas afectadas: {numeroDeColumnasAfectadas}.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show($"Numero de filas afectadas: {numeroDeColumnasAfectadas}. No existe el idJuego ingresado.", "FAILURE", MessageBoxButtons.OK);
                    }
                    this.LimpiarTabla();
                }
                else
                {
                    throw new IdJuegoInvalidoException("IdJuego fue invalido!");
                }
            }catch(IdJuegoInvalidoException idInvalid)
            {
                MessageBox.Show(idInvalid.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia los datos de la tabla.
        /// </summary>
        private void LimpiarTabla()
        {
            this.tabla.Clear();
            this.tabla = null;
        }

        /// <summary>
        /// Muestra los productos de la tabla segun su tipo. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarPorTipo(object sender, EventArgs e)
        {
            string tipoDeProducto = ((Button)sender).Tag.ToString();
            LimpiarTabla();
            if(tipoDeProducto != "Todos")
            {
                this.tabla = FabricaDAO.CargarDatosALaTablaPorTipo(tipoDeProducto);
            }
            try
            {

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmBaseDeDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hiloBaseDeDatos.IsAlive)
            {
                this.hiloBaseDeDatos.Abort();
            }
            LimpiarTabla();
        }
    }
}
