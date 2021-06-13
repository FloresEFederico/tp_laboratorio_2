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
    public partial class FrmBugs : Form
    {
        private Fabrica<Producto> fabricaDeJuegos;
        public FrmBugs(Fabrica<Producto> fabrica)
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

        private void FrmBugs_Load(object sender, EventArgs e)
        {
            ActualizarListaDeJuegosBugeados();
        }

        private void btnArreglar_Click(object sender, EventArgs e)
        {
            if(this.lstJuegosBugueados.Items.Count != 0)
            {
                VideoJuego videoJuego = (VideoJuego)this.lstJuegosBugueados.SelectedItem;
                if(videoJuego.FixearBugs())
                {
                    MessageBox.Show("Se ha fixeado el juego!", "Success", MessageBoxButtons.OK);
                }
                ActualizarListaDeJuegosBugeados();
            }
            else
            {
                MessageBox.Show("No hay juegos bugueados!", "Buenas noticias!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarListaDeJuegosBugeados()
        {
            this.lstJuegosBugueados.Items.Clear();
            foreach (Producto videoJuego in this.fabricaDeJuegos.JuegosFabricados)
            {
                if (videoJuego is VideoJuego && !((VideoJuego)videoJuego).Testeado)
                {
                    this.lstJuegosBugueados.Items.Add(videoJuego);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
