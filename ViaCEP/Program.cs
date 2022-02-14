using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ViaCEP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cep = "74971740";
            string result = GetEndereco(cep);
            Console.WriteLine(result);


            Console.ReadLine();
        }

        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
