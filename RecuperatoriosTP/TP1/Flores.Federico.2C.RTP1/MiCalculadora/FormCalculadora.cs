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
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }


        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro de querer salir?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia los valores ingresados en los numeros y en el resultado. 
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.lblResultado.Text = string.Empty;
        }

        /// <summary>
        /// realiza la operacion entre dos numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> retorna el resultado de la operacion
        public static double Operar(string numero1,string numero2,string operador)
        {
            char operadorChar = operador[0];
            return Calculadora.Operar(new Numero(numero1),new Numero(numero2),operadorChar);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.cmbOperador.Text.Length > 0)
            {
                this.lblResultado.Text = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero decimalABinario = new Numero();
            this.lblResultado.Text = decimalABinario.DecimalBinario(this.lblResultado.Text);

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero binarioADecimal = new Numero();
            this.lblResultado.Text = binarioADecimal.BinarioDecimal(this.lblResultado.Text);
        }

    }
}
