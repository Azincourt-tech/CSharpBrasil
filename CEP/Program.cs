using Caelum.Stella.CSharp.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //busca inicial padrão em Json
            string cep = "74971740";
            //string result = GetEndereco(cep);
            //Console.WriteLine(result);

            //imprimindo em Json
            ViaCEP viaCEP = new ViaCEP();
            string enderecojson = viaCEP.GetEnderecoJson(cep);
            Console.WriteLine(enderecojson);

            //outra forma de imrpimir em Json
            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Console.WriteLine(task.Result);

            //Imprimindo em XML
            string enderecoXml = viaCEP.GetEnderecoXml(cep);
            Console.WriteLine(enderecoXml);

            //Buscando apenas pelo objeto endereco
            var endereco = viaCEP.GetEndereco(cep);
            Console.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}", endereco.Logradouro, endereco.Bairro));



            Console.ReadLine();
        }

        //metodo de requisição do cep
        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
