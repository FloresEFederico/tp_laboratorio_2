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
            this.Close();
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

        private static double Operar(string numero1,string numero2,string operador)
        {
           return Calculadora.Operar((Numero)numero1,(Numero)numero2, operador);
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.cmbOperador.Text = string.Empty;
            
            this.lblResultado.Text = "0";
        }

    }
}
