using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza una cuenta matematica de dos numeros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> El resultado de la operacion.
        public static double Operar(Numero num1,Numero num2,string operador)
        {
            double resultado = 0;
            switch(ValidarOperador(operador))
            {
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida si el operador recibido por parametro es un operador valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> De ser un operador valido, retorna ese operador. De lo contrario, retorna el operador +
        private static string ValidarOperador(string operador)
        {
            string retorno;
            if((operador != "+") && (operador != "-") && (operador != "/") && (operador != "*"))
            {
                retorno = "+";
            }
            else
            {
                retorno = operador;
            }
            return retorno;
        }


    }
}
