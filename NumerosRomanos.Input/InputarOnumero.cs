using ConversorNumero.Dominio;
using System;

namespace NumerosRomanos.Input
{
    public class InputarOnumero
    {
        private ConversorNumeroRomanoParaArabico conversor;

        public InputarOnumero()
        {
            conversor = new ConversorNumeroRomanoParaArabico();
        }

        public void InputDeDado()
        {
            int numeroDecimal = 0;
            Console.WriteLine("Insira o número que deseja converter para Romano: ");
            string valor = Console.ReadLine();
            numeroDecimal = Convert.ToInt32(valor);
            string resultado = conversor.ConverteParaRomano(numeroDecimal);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
