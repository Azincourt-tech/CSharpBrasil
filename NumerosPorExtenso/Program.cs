using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPorExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo por extenso valor pequeno
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            //Imprimindo por extenso valor grande
            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            //Imprimindo na moeda BRL, com reais e centavos
            string extensoBRL =  new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);

            valor = 1532987.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);

            Console.ReadLine();
        }
    }
}
