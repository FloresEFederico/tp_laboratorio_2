using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero() :this(0)
        {
        }
        public Numero(double numero) :this(numero.ToString())
        {
        }
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        private double ValidarNumero(string strNumero)
        {
            double numeroRetorno;
            if(!double.TryParse(strNumero,out numeroRetorno))
            {
                numeroRetorno = 0;
            }
            return numeroRetorno;
        }

        private bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (char digito in binario)
            {
                if(digito != '0' && digito != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            string strRetorno = "Valor inválido";
            double numero = 0;
            int cantidadDeBits = (int)Math.Pow(2,binario.Length-1);
            if(EsBinario(binario))
            {
                foreach (char digito in binario)
                {
                    if(digito == '1')
                    {
                        numero += cantidadDeBits;
                    }
                    cantidadDeBits /= 2;
                }
                strRetorno = numero.ToString();
            }
            return strRetorno;
        }

        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        public string DecimalBinario(string numero)
        {
            string strRetorno = string.Empty;
            double auxNum;
            int dividendo;
            int divisor = 2;
            if(double.TryParse(numero,out auxNum) && auxNum >= 0)
            {
                dividendo = (int)auxNum;
                do
                {
                    if(dividendo%divisor == 0)
                    {
                        strRetorno = "0" + strRetorno;
                    }
                    else
                    {
                        strRetorno = "1" + strRetorno;

                    }
                    dividendo = dividendo / divisor;
                } while (dividendo > 0);
            }
            else
            {
                strRetorno = "Valor inválido";
            }
            return strRetorno;
        }

        public static double operator +(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
    }
}
