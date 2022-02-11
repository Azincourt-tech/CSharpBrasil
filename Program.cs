using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBrasil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Validação de CPF---------");
            

            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            Console.WriteLine();
            Console.WriteLine("--------Validação de CNPJ---------");

            string cnpj1 = "69562011000161";
            string cnpj2 = "66187672000166";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            Console.WriteLine();
            Console.WriteLine("--------Validação de Titulo Eleitoral---------");

            string titulo1 = "273881301023";
            string titulo2 = "768581181041";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Console.WriteLine();
            Console.WriteLine("--------Formatação de CPF, CNPJ e Titulo Eleitoral---------");

            string cpfFormatdo = new CPFFormatter().Format(cpf1);
            Console.WriteLine(cpfFormatdo);


            string cnpjFormatdo = new CNPJFormatter().Format(cnpj1);
            Console.WriteLine(cnpjFormatdo);


            string tituloFormatdo = new TituloEleitoralFormatter().Format(titulo1);
            Console.WriteLine(tituloFormatdo);

            Console.ReadLine();
        }




        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Console.WriteLine("TITULO VALIDO: " + titulo);
            }
            else
            {
                Console.WriteLine("TITULO INVALIDO: " + titulo);
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj)){

                Console.WriteLine("CNPJ VALIDO: " + cnpj);
            }
            else
            {
                Console.WriteLine("CNPJ INVALIDO: " + cnpj);
            }
        }


        private static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Console.WriteLine("CPF VALIDO: " + cpf);
            }
            else 
            {

                Console.WriteLine("CPF INVALIDO: " + cpf);
            }
        }
    }



    #region Validação de CPF

    //private static void ValidarCPF(string cpf)
    //{
    //    try
    //    {
    //        new CPFValidator().AssertValid(cpf);
    //        Console.WriteLine("CPF VALIDO: " + cpf);
    //    }
    //    catch (Exception exc)
    //    {

    //        Console.WriteLine("CPF INVALIDO: " + cpf + " : " + exc.ToString());
    //    }
    //}

    #endregion
}
