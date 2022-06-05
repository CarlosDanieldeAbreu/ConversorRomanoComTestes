using NumerosRomanos.Input;
using System;

namespace ConversorRomano.ConsoleApp
{
    internal class Program
    {
        static InputarOnumero inputar;
        static void Main(string[] args)
        {
            inputar = new InputarOnumero();
            inputar.InputDeDado();
        }
    }
}
