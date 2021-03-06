using ConversorNumero.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorNumero.Teste
{
    [TestClass]
    public class ConversorNumeroRomanoParaArabicoTest
    {
        private ConversorNumeroRomanoParaArabico conversor;

        public ConversorNumeroRomanoParaArabicoTest()
        {
            conversor = new ConversorNumeroRomanoParaArabico();
        }

        [TestMethod]
        [DataRow("LVIII", 58)]
        [DataRow("XVIII", 18)]
        [DataRow("XIX", 19)]
        [DataRow("MMMD", 3500)]
        public void Deve_converter_numero_romano_58(string numero, int resultadoEsperado)
        {
            //cen?rio - arrange
            string numeroRomano = numero;

            //a??o - action 
            var resultado = conversor.ConverteParaRomano(resultadoEsperado);

            //verifica??o - assert
            Assert.AreEqual(numeroRomano, resultado);
        }

        //[TestMethod]
        //[DataRow("I", 1)]
        //[DataRow("II", 2)]
        //[DataRow("III", 3)]
        //[DataRow("IV", 4)]
        //[DataRow("V", 5)]
        //[DataRow("VI", 6)]
        //[DataRow("VII", 7)]
        //[DataRow("VIII", 8)]
        //[DataRow("IX", 9)]
        //[DataRow("X", 10)]
        //public void Deve_converter_numeros_romanos_do_1_ao_10(string numero, int resultadoEsperado)
        //{
        //    //cen?rio - arrange
        //    string numeroRomano = numero;

        //    //a??o - action 
        //    var resultado = conversor.Converter(numeroRomano);

        //    //verifica??o - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        //[TestMethod]
        //[DataRow("XI", 11)]
        //[DataRow("XII", 12)]
        //[DataRow("XIII", 13)]
        //[DataRow("XIV", 14)]
        //[DataRow("XV", 15)]
        //[DataRow("XVI", 16)]
        //[DataRow("XVII", 17)]
        //[DataRow("XVIII", 18)]
        //[DataRow("XIX", 19)]
        //[DataRow("XX", 20)]
        //public void Deve_converter_numeros_romanos_do_11_ao_20(string numero, int resultadoEsperado)
        //{
        //    string numeroRomano = numero;

        //    //a??o - action 
        //    var resultado = conversor.Converter(numeroRomano);

        //    //verifica??o - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        //[TestMethod]
        //[DataRow("LI", 51)]
        ////[DataRow("LII", 52)]
        ////[DataRow("LIII", 53)]
        ////[DataRow("LIV", 54)]
        ////[DataRow("LV", 55)]
        ////[DataRow("LVI", 56)]
        ////[DataRow("LVII", 57)]
        ////[DataRow("LVIII", 58)]
        ////[DataRow("LIX", 59)]
        //[DataRow("LX", 60)]
        //public void Deve_converter_numeros_romanos_do_51_ao_60(string numero, int resultadoEsperado)
        //{
        //    string numeroRomano = numero;

        //    //a??o - action 
        //    var resultado = conversor.Converter(numeroRomano);

        //    //verifica??o - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        //[TestMethod]
        //[DataRow("MMMD", 3500)]

        //public void Deve_converter_numero_romano_3500(string numero, int resultadoEsperado)
        //{
        //    string numeroRomano = numero;

        //    //a??o - action 
        //    var resultado = conversor.Converter(numeroRomano);

        //    //verifica??o - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        ////[TestMethod]
        ////[DataRow("DXLVI", 546)]

        ////public void Deve_converter_numero_romano_500(string numero, int resultadoEsperado)
        ////{
        ////    string numeroRomano = numero;

        ////    //a??o - action 
        ////    var resultado = conversor.Converter(numeroRomano);

        ////    //verifica??o - assert
        ////    Assert.AreEqual(resultadoEsperado, resultado);
        ////}

        //[TestMethod]
        //[DataRow("XXX", 30)]

        //public void Deve_converter_numero_romano_30(string numero, int resultadoEsperado)
        //{
        //    string numeroRomano = numero;

        //    //a??o - action 
        //    var resultado = conversor.Converter(numeroRomano);

        //    //verifica??o - assert
        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}
    }
}
