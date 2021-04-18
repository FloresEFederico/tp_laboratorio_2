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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != "Valor invalido")
            {
                this.lblResultado.Text = Numero.DecimalBinario(double.Parse(lblResultado.Text));
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "Valor invalido")
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string auxNumUno = this.txtNumero1.Text;
            string auxNumDos = this.txtNumero2.Text;
            string auxOperador = string.Empty;
            double auxResult;
            if(this.cmbOperador.SelectedIndex == -1)
            {
                if(this.cmbOperador.Text != string.Empty)
                {
                    auxOperador = this.cmbOperador.Text;
                }
            }
            else
            {
                auxOperador = this.cmbOperador.SelectedItem.ToString();
            }
            auxResult =  Operar(auxNumUno,auxNumDos,auxOperador);
            lblResultado.Text = auxResult.ToString();   
        }

        /// <summary>
        /// Hace la operacion entre dos numeros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> resultado de la operacion.
        private static double Operar(string numero1,string numero2,string operador)
        {
           return Calculadora.Operar((Numero)numero1,(Numero)numero2, operador);
        }

        /// <summary>
        /// Limpia los controles del programa.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = -1;
            this.cmbOperador.Text = string.Empty;
            
            this.lblResultado.Text = "0";
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <= '0' || e.KeyChar >= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= '0' || e.KeyChar >= '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
