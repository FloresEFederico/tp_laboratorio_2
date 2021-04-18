using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double numeroDecimal)
        {
            string numeroBinario = string.Empty;
            double dividendo = numeroDecimal;
            int divisor = 2;
            int resto;
            int cociente;
            do
            {
                cociente = (int)dividendo / divisor;
                resto = (int)dividendo % divisor;
                if(resto == 0)
                {
                    numeroBinario = "0" + numeroBinario;
                }
                else
                {
                    numeroBinario = "1" + numeroBinario;
                }
                if(cociente == 1)
                {
                    numeroBinario = "1" + numeroBinario;
                }
                dividendo = cociente;
            } while (dividendo >= divisor);

            return numeroBinario;
        }

        public static double BinarioDecimal(string numeroBinario)
        {
            double numeroDecimal = 0;
            double longitudBinario = Math.Pow(2, numeroBinario.Length - 1);
            foreach (char auxNum in numeroBinario)
            {
                if (auxNum == '1')
                {
                    numeroDecimal += longitudBinario;
                }
                longitudBinario /= 2;
            }
            return numeroDecimal;
        }
    }
}
