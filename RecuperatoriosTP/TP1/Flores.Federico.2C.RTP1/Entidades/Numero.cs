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

        /// <summary>
        /// Constructor sin parametros de Numero
        /// </summary>
        public Numero() :this(0)
        {
        }
        /// <summary>
        /// Constructor de un parametro del tipo double de Numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) :this(numero.ToString())
        {
        }
        /// <summary>
        /// Constructor de un parametro del tipo string de Numero.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Propiedad de escritura SetNumero. Setea en el atributo numero del tipo double un valor previamente validado.
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Valida que el string pasado por parametro sea un numero valido
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns> retorna el numero string convertido a double, de lo contrario retorna 0.
        private double ValidarNumero(string strNumero)
        {
            double numeroRetorno;
            if(!double.TryParse(strNumero,out numeroRetorno))
            {
                numeroRetorno = 0;
            }
            return numeroRetorno;
        }

        /// <summary>
        /// Se fija que el string pasado por parametro sea un binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> true si es un numero binario valido, false si no lo es.
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

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> un string con el binario convertido a decimal, de lo contrario retorna Valor invalido
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

        /// <summary>
        /// Convierte un numero decimal del tipo double a binario 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> el numero decimal convertido a binario, de lo contrario retorna valor invalido
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Convierte un numero decimal del tipo string a binario 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> el numero decimal convertido a binario, de lo contrario retorna valor invalido
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

        /// <summary>
        /// Sobrecarga del operador +. Suma dos objetos de la clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> el resultado de la suma de los dos numeros
        public static double operator +(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -. Resta dos objetos de la clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> el resultado de la resta de los dos numeros
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador *. Multiplica dos objetos de la clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> el resultado de la multiplicacion de los dos numeros
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /. divide dos objetos de la clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> el resultado de la division de los dos numeros. En caso de que el n2 sea 0 retornara el valor minimo de double.
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
