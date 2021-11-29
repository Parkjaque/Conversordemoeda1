using System;
using System.Collections.Generic;
using System.Text;

class ConversorDeMoeda
{
    private static float iof = 0.0295f;

    static public void reaisParaDolar()
    {
        Console.Write("Qual é a cotação do dólar? ");
        float cotaDolar = float.Parse(Console.ReadLine());

        Console.Write("Quantos doláres você irá comprar? $");
        float dolarParaComprar = float.Parse(Console.ReadLine());

        float totalEmReais = dolarParaComprar * cotaDolar;

        Console.WriteLine("Valor a ser pago em reais = R$ " + totalEmReais);
        Console.WriteLine("Valor a ser pago de IOF = " + (ConversorDeMoeda.iof * 100) + "%");
        Console.WriteLine("Valor total da compra com IOF = R$" + (totalEmReais + totalEmReais * ConversorDeMoeda.iof));
    }
}
