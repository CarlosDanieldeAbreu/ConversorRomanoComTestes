using System;
using System.Collections.Generic;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroRomanoParaArabico
    {
        Dictionary<string, int> numeros = new Dictionary<string, int>();

        public ConversorNumeroRomanoParaArabico()
        {
            numeros.Add("", 0);
            numeros.Add("I", 1);
            numeros.Add("V", 5);
            numeros.Add("X", 10);
            numeros.Add("L", 50);
            numeros.Add("C", 100);
            numeros.Add("D", 500);
            numeros.Add("M", 1000);
        }

        public int Converter(string numeroRomano)
        {
            if (numeroRomano.StartsWith("X"))
            {
                numeroRomano = numeroRomano.Substring(1);
                return numeros[numeroRomano] + 10;
            }

            return numeros[numeroRomano];
        }
    }
}
