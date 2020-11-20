using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Dolar();
            double k;

            do
            {
                Console.Write("Informe o valor em dolar: ");
                k = double.Parse(Console.ReadLine());
                if (k >= 0) a1.SetValor(k);
            }
            while (k < 0);


            if (a1.GetValor() == 1) Console.WriteLine($"{a1.GetValor()} dolar é igual a {a1.ConverterDolarParaReal()} reais");
            else if (a1.ConverterDolarParaReal() == 1)
            {
                Console.WriteLine($"{a1.GetValor()} dolares é igual a {a1.ConverterDolarParaReal()} real");
            }
            else Console.WriteLine($"{a1.GetValor()} dolares é igual a {a1.ConverterDolarParaReal()} reais");
        }
    }
}
