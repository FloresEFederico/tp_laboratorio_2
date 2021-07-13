using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre dos numeros dependiendo del operador pasado por parametro
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns> el resultado de la operacion
        public static double Operar(Numero num1,Numero num2, char operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida si el operador pasado por parametro es un operador valido y lo convierte a string
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> retorna el operador convertido a string. De ser un operador invalido, retornara el operador "+"
        private static string ValidarOperador(char operador)
        {
            string operadorRetorno = "+";
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                operadorRetorno = operador.ToString();
            }

            return operadorRetorno;
        }
    }
}
