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
        /// Constructor sin parametros que inicializa el atributo numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que inicializa el atributo numero  con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero):this()
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que inicializa el atributo numero con el valor pasado por parametro
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero):this()
        {
            this.SetNumero = strNumero;         
        }

        /// <summary>
        /// Valida si el numero en formato string es un numero valido y lo convierte en una variable tipo double.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns> el strNumero convertido en double si es un numero valido. De lo contrario, retorna 0.
        private static double ValidarNumero(string strNumero)
        {
            double auxNum;
            if(!Double.TryParse(strNumero, out auxNum))
            {
                auxNum = 0;
            }
            return auxNum;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Determina si el string pasado por parametro es un numero binario valido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns> true si es binario, false si no lo es.
        private static  bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (char auxChar in binario)
            {
                if((auxChar != '0') && (auxChar != '1'))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal mayor a 0  en binario.
        /// </summary>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns> string numero binario
        public static string DecimalBinario(double numeroDecimal)
        {
            string numeroBinario = string.Empty;
            double dividendo = numeroDecimal;
            int divisor = 2;
            int resto;
            int cociente;
            if(numeroDecimal >= 0)
            {
                do
                {
                    cociente = (int)dividendo / divisor;
                    resto = (int)dividendo % divisor;
                    if (resto == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    if (cociente == 1)
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    dividendo = cociente;
                } while (dividendo >= divisor);
            }
            else
            {
                numeroBinario = "Valor invalido";
            }
            return numeroBinario;
        }

        /// <summary>
        /// Convierte un numero decimal mayor a 0  en binario.
        /// </summary>
        /// <param name="strNumeroDecimal"></param>
        /// <returns></returns>
        public static string DecimalBinario(string strNumeroDecimal)
        {
            return DecimalBinario(ValidarNumero(strNumeroDecimal));
        }

        /// <summary>
        /// Convierte un numero binario en un numero decimal.
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string numeroBinario)
        {
            double numeroDecimal = 0;
            string strNumeroDecimal = "Valor invalido";
            double longitudBinario = Math.Pow(2, numeroBinario.Length - 1);
          
            if(EsBinario(numeroBinario))
            {
                foreach (char auxNum in numeroBinario)
                {
                    if (auxNum == '1')
                    {
                        numeroDecimal += longitudBinario;
                    }
                    longitudBinario /= 2;
                }
                strNumeroDecimal = $"{numeroDecimal}";
            }
            return strNumeroDecimal;
        }
        /// <summary>
        /// sobrecarga del operador +. Hace la suma entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> la suma de los numeros
        public static double operator +(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador -. Hace la resta entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> la resta de los numeros
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador /. Hace la division entre dos objetos del tipo Numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> en caso de que n2 sea distinto a 0, retorna la division de los dos numeros. Caso contrario, retorna double.MinValue.
        public static double operator /(Numero n1, Numero n2)
        {
            double auxResult = double.MinValue; 
            if(n2.numero != 0)
            {
                auxResult = n1.numero / n2.numero;
            }
            return auxResult;
        }

        /// <summary>
        /// sobrecarga del operador *. multiplica  dos objetos del tipo Numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns> la multiplicacion de los numeros
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga de Numero
        /// </summary>
        /// <param name="strNumero"></param>
        public static explicit operator Numero(string strNumero)
        {
            return new Numero(strNumero);
        }

    }
}
