using Caelum.Stella.CSharp.Vault;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo na moeda BRL
            Money money = 10.00;

            Console.WriteLine(money.ToString());

            double valor1 = 10.00;
            double valor2 = 20.00;

            Money valorTotal = valor1 + valor2;
            Console.WriteLine(valorTotal.ToString());

            decimal minuendo = 20m;
            decimal subtraendo = 15m;
            Money diferenca = minuendo - subtraendo;
            Console.WriteLine(diferenca.ToString());


            //Imprimindo na moeda EUR
            Money euro = new Money(Currency.EUR, 1000);
            Console.WriteLine(euro.ToString());

            //Imprimindo na moeda USD
            Money dolar = new Money(Currency.USD, 1000);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(dolar.ToString());



            Console.ReadLine();

        }
    }
}
