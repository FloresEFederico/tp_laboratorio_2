using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

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
