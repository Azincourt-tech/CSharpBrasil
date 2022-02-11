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

            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            Console.ReadLine();
        }


        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Console.WriteLine("CPF VALIDO: " + cpf);
            }
            catch (Exception exc)
            {

                Console.WriteLine("CPF INVALIDO: " + cpf + " : " + exc.ToString());
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
