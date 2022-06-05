using System;
using System.Collections.Generic;

namespace ConversorNumero.Dominio
{
    public class ConversorNumeroRomanoParaArabico
    {
        //Dictionary<string, int> numeros = new Dictionary<string, int>();

        //public ConversorNumeroRomanoParaArabico()
        //{
        //    numeros.Add("", 0);
        //    numeros.Add("I", 1);
        //    numeros.Add("II", 2);
        //    numeros.Add("III", 3);
        //    numeros.Add("IV", 4);
        //    numeros.Add("V", 5);
        //    numeros.Add("VI", 6);
        //    numeros.Add("VII", 7);
        //    numeros.Add("VIII", 8);
        //    numeros.Add("IX", 9);
        //    numeros.Add("X", 10);
        //    numeros.Add("L", 50);
        //    numeros.Add("C", 100);
        //    numeros.Add("D", 500);
        //    numeros.Add("M", 1000);
        //}
        public String ConverteParaRomano(int num)
        {
            // armazenando valores romanos de dígitos de 0-9 quando colocado em lugares diferentes
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
            String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
            String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };

            // Convertendo para romano
            String milhares = m[num / 1000];
            String centenas = c[(num % 1000) / 100];
            String dezenas = x[(num % 100) / 10];
            String unidades = i[num % 10];

            String ans = milhares + centenas + dezenas + unidades;

            return ans;
        }

        //public int Converter(string numeroRomano)
        //{
        //    if (numeroRomano.StartsWith("MMM"))
        //    {
        //        numeroRomano = numeroRomano.Substring(3);
        //        return numeros[numeroRomano] + 3000;
        //    }
        //    else if (numeroRomano.StartsWith("LX"))
        //    {
        //        numeroRomano = numeroRomano.Substring(2);
        //        return numeros[numeroRomano] + 60;
        //    }
        //    else if (numeroRomano.StartsWith("L"))
        //    {
        //        numeroRomano = numeroRomano.Substring(1);
        //        return numeros[numeroRomano] + 50;
        //    }
        //    else if (numeroRomano.StartsWith("XL"))
        //    {
        //        numeroRomano = numeroRomano.Substring(2);
        //        return numeros[numeroRomano] + 40;
        //    }
        //    else if (numeroRomano.StartsWith("XXX"))
        //    {
        //        numeroRomano = numeroRomano.Substring(3);
        //        return numeros[numeroRomano] + 30;
        //    }
        //    else if (numeroRomano.StartsWith("XX"))
        //    {
        //        numeroRomano = numeroRomano.Substring(2);
        //        return numeros[numeroRomano] + 20;
        //    }
        //    else if (numeroRomano.StartsWith("X"))
        //    {
        //        numeroRomano = numeroRomano.Substring(1);
        //        return numeros[numeroRomano] + 10;
        //    }

        //    return numeros[numeroRomano];
        //}
    }
}
