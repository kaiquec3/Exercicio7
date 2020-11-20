using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_7
{
    class Dolar
    {
        double valor;
        double convertido;

        public void SetValor(double p)
        {
            valor = p;
        }

        public double GetValor()
        {
            return valor;
        }

        public double GetConvertido()
        {
            return convertido;
        }

        public double ConverterDolarParaReal()
        {
            convertido = valor * 5.46;
            return convertido;
        }
    }
}
